using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TextFileSearch.Properties;

namespace TextFileSearch
{
    /// <summary>
    /// The main form of the application.
    /// </summary>
    public partial class MainForm : Form
    {
        private const string ApplicationConfigurationFileName = "ApplicationConfiguration.json";
        private ApplicationConfiguration applicationConfigurarion;
        private Project project = new Project();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            buttonReloadFiles.Click += ButtonReloadFiles_Click;
            buttonSearch.Click += ButtonSearch_Click;
            buttonLoadedFiles.Click += ButtonLoadedFiles_Clicked;
            newProjectToolStripMenuItem.Click += NewProjectToolStripMenuItem_Click;
            saveProjectToolStripMenuItem.Click += SaveProjectToolStripMenuItem_Click;
            saveProjectAsToolStripMenuItem.Click += SaveProjectAsToolStripMenuItem_Click;
            openProjectToolStripMenuItem.Click += OpenProjectToolStripMenuItem_Click;
            editCurrentProjectToolStripMenuItem.Click += EditCurrentProjectToolStripMenuItem_Click;
            closeToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            FormClosing += MainForm_FormClosing;

            LoadApplicationConfiguration();
            LoadRecentProjects();
            UpdateControls();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBoxForm form = new AboutBoxForm())
            {
                form.ShowDialog();
            }
        }

        private void SaveProjectAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!project.IsEmpty())
                {
                    using (SaveFileDialog dialog = new SaveFileDialog())
                    {
                        dialog.DefaultExt = "json";
                        dialog.Filter = "Json File (*.json)|*.json";

                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            project.FileName = dialog.FileName;

                            if (!string.IsNullOrWhiteSpace(project.FileName))
                            {
                                File.WriteAllText(
                                    project.FileName,
                                    JsonConvert.SerializeObject(project, Formatting.Indented),
                                    Encoding.UTF8);

                                project.ChangesSavedToDisk();
                                AddCurrentProject();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                StringBuilder builder = new StringBuilder()
                    .AppendLine("An exception has occurred while trying to save the project.")
                    .AppendLine()
                    .AppendLine("Exception message:")
                    .Append(ex.Message);

                MessageBox.Show(builder.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateControls();
        }

        private void UpdateSaveStatus()
        {
            const string applicationTitle = "Text File Search";
            string fileName = project.IsEmpty() || string.IsNullOrEmpty(project.FileName) ? "New Project" : project.FileName;
            string savePending = project.HasUnsavedChanges() ? "*" : string.Empty;
            Text = $"{savePending}{fileName} - {applicationTitle}";
        }

        private void LoadRecentProjects()
        {
            recentProjectsToolStripMenuItem.Enabled = false;

            if (applicationConfigurarion.RecentProjects.Count > 0)
            {
                recentProjectsToolStripMenuItem.Enabled = true;

                foreach (var recentProject in applicationConfigurarion.RecentProjects.OrderByDescending(p => p.Timestamp))
                {
                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem
                    {
                        Image = Resources.TextFile_16x,
                        Text = recentProject.FileName,
                        Tag = recentProject,
                    };

                    toolStripMenuItem.Click += ToolStripMenuItemProject_Click;
                    recentProjectsToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);
                }

                recentProjectsToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());

                ToolStripMenuItem toolStripMenuItemClearRecentProjects = new ToolStripMenuItem
                {
                    Image = Resources.ClearCollection_16x,
                    Text = "Clear List",
                };

                toolStripMenuItemClearRecentProjects.Click += ToolStripMenuItemClearRecentProjects_Click;
                recentProjectsToolStripMenuItem.DropDownItems.Add(toolStripMenuItemClearRecentProjects);
            }
        }

        private void ToolStripMenuItemProject_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                if (menuItem.Tag is RecentProject recentProject)
                {
                    if (CloseCurrentProject())
                    {
                        if (File.Exists(recentProject.FileName))
                        {
                            OpenProject(recentProject.FileName);
                        }
                        else
                        {
                            StringBuilder builder = new StringBuilder()
                                .AppendLine($"The file \"{recentProject.FileName}\" doesn't exist or has been moved to another location.")
                                .Append("The project reference will be removed from the list of recent projects.");

                            MessageBox.Show(builder.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            recentProjectsToolStripMenuItem.DropDownItems.Remove(menuItem);
                            applicationConfigurarion.RecentProjects.Remove(recentProject);
                        }
                    }
                }
            }
        }

        private void ToolStripMenuItemClearRecentProjects_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to clear the list of recent projets?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                applicationConfigurarion.RecentProjects.Clear();
                recentProjectsToolStripMenuItem.DropDownItems.Clear();
                recentProjectsToolStripMenuItem.Enabled = false;
                AddCurrentProject();
            }
        }

        private void LoadApplicationConfiguration()
        {
            string path = Path.Combine(Application.StartupPath, ApplicationConfigurationFileName);

            if (File.Exists(path))
            {
                try
                {
                    applicationConfigurarion = JsonConvert.DeserializeObject<ApplicationConfiguration>(File.ReadAllText(path));
                }
                catch (Exception ex)
                {
                    StringBuilder builder = new StringBuilder()
                        .AppendLine("An error has occurred while loading the application's saved settings from file.")
                        .AppendLine("The application is now using the default factory settings.")
                        .AppendLine()
                        .AppendLine("Error message:")
                        .Append(ex.Message);

                    MessageBox.Show(builder.ToString(), "Application Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (applicationConfigurarion == null)
            {
                applicationConfigurarion = new ApplicationConfiguration();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseCurrentProject())
            {
                e.Cancel = true;
            }

            SaveApplicationConfiguration();
        }

        private void SaveApplicationConfiguration()
        {
            File.WriteAllText(
                Path.Combine(Application.StartupPath, ApplicationConfigurationFileName),
                JsonConvert.SerializeObject(applicationConfigurarion, Formatting.Indented),
                Encoding.UTF8);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentProject();
            UpdateControls();
        }

        private void EditCurrentProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ProjectForm form = new ProjectForm(project))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (project.HasUnsavedPaths || project.HasUnsavedSearchPatterns)
                    {
                        LoadFiles();
                    }

                    UpdateSaveStatus();
                }
            }
        }

        private void OpenProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CloseCurrentProject())
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.DefaultExt = "json";
                    dialog.Filter = "Json File (*.json)|*.json";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        OpenProject(dialog.FileName);
                    }
                }
            }
        }

        private void OpenProject(string fileName)
        {
            try
            {
                project = JsonConvert.DeserializeObject<Project>(File.ReadAllText(fileName));

                if (project.IsEmpty())
                {
                    StringBuilder builder = new StringBuilder()
                    .AppendLine("Unable to open project. The specified JSON file might not represent a Text File Search Project or the project is empty.")
                    .Append("File: ")
                    .Append(fileName);

                    MessageBox.Show(builder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Updates the file location because it might have changed.
                project.FileName = fileName;

                foreach (PathInformation path in project.Paths)
                {
                    path.Exists = Directory.Exists(path.Path);
                }

                using (ProjectForm projectForm = new ProjectForm(project))
                {
                    projectForm.ShowDialog();
                    LoadFiles();
                }

                AddCurrentProject();
            }
            catch (Exception ex)
            {
                StringBuilder builder = new StringBuilder()
                    .AppendLine("An exception has occurred while trying to open the project file.")
                    .Append("File: ")
                    .AppendLine(fileName)
                    .AppendLine()
                    .AppendLine("Exception message:")
                    .Append(ex.Message);

                MessageBox.Show(builder.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCurrentProject()
        {
            if (!project.IsEmpty()
                && !string.IsNullOrEmpty(project.FileName)
                && File.Exists(project.FileName))
            {
                applicationConfigurarion.RecentProjects.RemoveAll(r => r.FileName.Equals(project.FileName));
                applicationConfigurarion.RecentProjects.Add(new RecentProject
                {
                    FileName = project.FileName,
                    Timestamp = DateTime.Now,
                });
            }
        }

        private void SaveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!project.IsEmpty())
                {
                    if (string.IsNullOrWhiteSpace(project.FileName))
                    {
                        using (SaveFileDialog dialog = new SaveFileDialog())
                        {
                            dialog.DefaultExt = "json";
                            dialog.Filter = "Json File (*.json)|*.json";

                            if (dialog.ShowDialog() == DialogResult.OK)
                            {
                                project.FileName = dialog.FileName;
                            }
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(project.FileName))
                    {
                        File.WriteAllText(
                            project.FileName,
                            JsonConvert.SerializeObject(project, Formatting.Indented),
                            Encoding.UTF8);

                        project.ChangesSavedToDisk();
                        AddCurrentProject();
                    }
                }
            }
            catch (Exception ex)
            {
                StringBuilder builder = new StringBuilder()
                    .AppendLine("An exception has occurred while trying to save the project.")
                    .AppendLine()
                    .AppendLine("Exception message:")
                    .Append(ex.Message);

                MessageBox.Show(builder.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateControls();
        }

        private void UpdateControls()
        {
            newProjectToolStripMenuItem.Enabled = true;
            openProjectToolStripMenuItem.Enabled = true;
            editCurrentProjectToolStripMenuItem.Enabled = !project.IsEmpty();
            saveProjectToolStripMenuItem.Enabled = !project.IsEmpty();
            saveProjectAsToolStripMenuItem.Enabled = !project.IsEmpty();
            closeToolStripMenuItem.Enabled = !project.IsEmpty();
            buttonLoadedFiles.Text = $"{project.TextFiles.Count} loaded files";
            buttonLoadedFiles.Enabled = project.TextFiles.Count > 0;
            buttonReloadFiles.Enabled = project.TextFiles.Count > 0;
            buttonSearch.Enabled = project.TextFiles.Count > 0;
            UpdateSaveStatus();
        }

        private void NewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CloseCurrentProject())
            {
                UpdateControls();

                using (ProjectForm form = new ProjectForm(project))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadFiles();
                    }
                }
            }
        }

        private bool CloseCurrentProject()
        {
            bool result = true;

            if (project.HasUnsavedChanges())
            {
                result = MessageBox.Show(
                    "Discard the unsaved changes to the project?",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes;
            }

            if (result)
            {
                project = new Project();
                textBoxSearchResult.Clear();
            }

            return result;
        }

        private void LoadFiles()
        {
            if (project.Paths.Any(p => !p.Exists))
            {
                MessageBox.Show(
                    "There are invalid paths in your project configuration. Please remove the invalid paths and try again.",
                    "Invalid Paths",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            project.TextFiles.Clear();
            textBoxSearchResult.Clear();
            UpdateControls();
            LoadFilesWorker();
        }

        private void LoadFilesWorker()
        {
            using (BackgroundWorker loadFilesWorker = new BackgroundWorker())
            {
                loadFilesWorker.WorkerReportsProgress = true;
                loadFilesWorker.ProgressChanged += LoadFilesWorker_ProgressChanged;
                loadFilesWorker.RunWorkerCompleted += LoadFilesWorker_RunWorkerCompleted;
                loadFilesWorker.DoWork += LoadFilesWorker_DoWork;
                loadFilesWorker.RunWorkerAsync(project);
            }

            ShowProgressPanel();
            progressBar.Style = ProgressBarStyle.Marquee;
        }

        private void LoadFilesWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (sender is BackgroundWorker worker
                && e.Argument is Project project)
            {
                try
                {
                    foreach (PathInformation directory in project.Paths)
                    {
                        foreach (string pattern in project.SearchPatterns)
                        {
                            var searchOption = directory.RecursiveSearch ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

                            foreach (string file in Directory.EnumerateFiles(directory.Path, pattern, searchOption))
                            {
                                worker.ReportProgress(0, file);
                                project.TextFiles.Add(new TextFile { Path = file, Content = File.ReadAllText(file, Encoding.Default) });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    e.Result = ex;
                }
            }
        }

        private void LoadFilesWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HideProgresPanel();

            if (e.Result is Exception exception)
            {
                StringBuilder builder = new StringBuilder()
                    .AppendLine("An error has occurred while trying to load the files.")
                    .AppendLine("Error message:")
                    .Append(exception.Message);

                MessageBox.Show(
                    builder.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadFilesWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is string file)
            {
                textBoxSearch.Text = $"Loading file {Path.GetFileName(file)} ({Path.GetFullPath(file)})";
            }
        }

        private void ShowProgressPanel()
        {
            panelSearching.Visible = true;
            buttonSearch.Enabled = false;
            buttonReloadFiles.Enabled = false;
            buttonLoadedFiles.Enabled = false;
            textBoxSearchResult.Enabled = false;
            menuStrip.Enabled = false;
        }

        private void HideProgresPanel()
        {
            panelSearching.Visible = false;
            buttonSearch.Enabled = true;
            buttonReloadFiles.Enabled = true;
            buttonLoadedFiles.Enabled = true;
            textBoxSearchResult.Enabled = true;
            menuStrip.Enabled = true;
            UpdateControls();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (project.TextFiles.Count > 0 && project.SearchItems.Count > 0)
            {
                Search();
            }
        }

        private void Search()
        {
            ShowProgressPanel();
            progressBar.Style = ProgressBarStyle.Continuous;

            foreach (SearchItem item in project.SearchItems)
            {
                item.TextFileResults.Clear();
            }

            using (BackgroundWorker worker = new BackgroundWorker())
            {
                worker.WorkerReportsProgress = true;
                worker.ProgressChanged += Worker_ProgressChanged;
                worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
                worker.DoWork += Worker_DoWork;
                worker.RunWorkerAsync(project);
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (sender is BackgroundWorker worker)
                {
                    Project project = e.Argument as Project;
                    AhoCorasick.Trie trie = new AhoCorasick.Trie();

                    foreach (var searchItem in project.SearchItems)
                    {
                        trie.Add(searchItem.Value);
                    }

                    trie.Build();

                    int count = 0;

                    foreach (var textFile in project.TextFiles)
                    {
                        count++;
                        worker.ReportProgress(count * 100 / project.TextFiles.Count, new Tuple<int, int, string>(count, project.TextFiles.Count, Path.GetFileName(textFile.Path)));

                        foreach (string word in trie.Find(textFile.Content))
                        {
                            SearchItem searchItem = project.SearchItems.FirstOrDefault(s => s.Value == word);

                            if (searchItem != null)
                            {
                                var textFileResult = searchItem.TextFileResults.FirstOrDefault(t => t.TextFile == textFile);

                                if (textFileResult != null)
                                {
                                    textFileResult.Count++;
                                }
                                else
                                {
                                    searchItem.TextFileResults.Add(new TextFileResult { TextFile = textFile, Count = 1 });
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                e.Result = ex;
            }
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception exception)
            {
                StringBuilder builder = new StringBuilder()
                    .AppendLine("An unexpected error has occurred.")
                    .AppendLine("Error message:")
                    .Append(exception.Message);

                MessageBox.Show(
                    builder.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            try
            {
                StringBuilder sb = new StringBuilder();

                foreach (var searchItem in project.SearchItems)
                {
                    sb.AppendLine(searchItem.ToString());
                    sb.AppendLine();
                }

                textBoxSearchResult.Text = sb.ToString();
            }
            finally
            {
                HideProgresPanel();
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState is Tuple<int, int, string> tuple)
            {
                progressBar.Value = e.ProgressPercentage;
                textBoxSearch.Text = $"({tuple.Item1}/{tuple.Item2}) Searching file {Path.GetFileName(tuple.Item3)} ({Path.GetFullPath(tuple.Item3)})";
            }
        }

        private void ButtonLoadedFiles_Clicked(object sender, EventArgs e)
        {
            using (LoadedFilesForm form = new LoadedFilesForm(project.TextFiles))
            {
                form.ShowDialog();
            }
        }

        private void ButtonReloadFiles_Click(object sender, EventArgs e)
        {
            if (!project.IsEmpty())
            {
                project.TextFiles.Clear();
                UpdateControls();
                LoadFiles();
            }
        }
    }
}
