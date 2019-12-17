using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextFileSearch
{
    /// <summary>
    /// Represents a form where the <see cref="project"/> is configured.
    /// </summary>
    public partial class ProjectForm : Form
    {
        private readonly Project project;
        private readonly BindingList<PathInformation> paths = new BindingList<PathInformation>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectForm"/> class.
        /// </summary>
        /// <param name="project">The <see cref="project"/> to be handled by the form.</param>
        public ProjectForm(Project project)
        {
            this.project = project ?? throw new ArgumentNullException(nameof(project));
            InitializeComponent();
            ConfigureGrid();
            MapToView();

            buttonOK.Click += ButtonSave_Click;
            buttonSelectPath.Click += ButtonSelectPath_Click;
            buttonAddPath.Click += ButtonAddPath_Click;
            buttonRemoveSelectedPath.Click += ButtonRemoveSelectedPath_Click;
        }

        private void ButtonRemoveSelectedPath_Click(object sender, EventArgs e)
        {
            if (dataGridViewPath.CurrentRow != null
                && dataGridViewPath.CurrentRow.DataBoundItem is PathInformation path)
            {
                paths.Remove(path);
            }
        }

        private void ButtonAddPath_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPath.Text))
            {
                MessageBox.Show(
                    $"Please inform a valid path in the {labelPath.Text} field.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxPath.Focus();
                textBoxPath.SelectAll();
                return;
            }

            if (!Directory.Exists(textBoxPath.Text.Trim()))
            {
                MessageBox.Show(
                    $"Path \"{textBoxPath.Text.Trim()}\" is not valid or doesn't exist. Please inform a valid path in the {labelPath.Text} field.",
                    "Invalid Path",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxPath.Focus();
                textBoxPath.SelectAll();
                return;
            }

            if (!paths.Any(s => s.Path.Equals(textBoxPath.Text.Trim(), StringComparison.InvariantCultureIgnoreCase)))
            {
                foreach (PathInformation pathInformation in paths)
                {
                    if (textBoxPath.Text.Trim().IsSubPathOf(pathInformation.Path))
                    {
                        MessageBox.Show(
                            $"Path \"{textBoxPath.Text.Trim()}\" is a sub path of \"{pathInformation.Path}\".",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        textBoxPath.Focus();
                        textBoxPath.SelectAll();
                        return;
                    }
                }

                paths.Add(new PathInformation
                {
                    Exists = true,
                    RecursiveSearch = true,
                    Path = textBoxPath.Text.Trim(),
                });
            }
        }

        private void ButtonSelectPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxPath.Text = dialog.SelectedPath;
                }
            }
        }

        private void ConfigureGrid()
        {
            dataGridViewPath.DataSource = paths;

            var imageColumn = new DataGridViewImageColumn
            {
                Name = "StatusImage",
                HeaderText = string.Empty,
            };

            dataGridViewPath.Columns.Insert(0, imageColumn);
            dataGridViewPath.CellFormatting += DataGridViewPath_CellFormatting;
            dataGridViewPath.Columns[nameof(PathInformation.Exists)].Visible = false;
            dataGridViewPath.Columns[nameof(PathInformation.RecursiveSearch)].DisplayIndex = 1;
            dataGridViewPath.Columns[nameof(PathInformation.Path)].DisplayIndex = 2;
            dataGridViewPath.Columns[nameof(PathInformation.RecursiveSearch)].HeaderText = "Recursive";
            dataGridViewPath.Columns[nameof(PathInformation.Path)].ReadOnly = true;
        }

        private void DataGridViewPath_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewPath.Columns[e.ColumnIndex].Name == "StatusImage")
            {
                if (dataGridViewPath.Rows[e.RowIndex].DataBoundItem is PathInformation path && path.Exists)
                {
                    e.Value = Properties.Resources.Folder_16x;
                }
                else
                {
                    e.Value = Properties.Resources.FolderError_16x;
                }
            }
        }

        private void MapToView()
        {
            textBoxSearchPattern.Text = string.Join(Environment.NewLine, project.SearchPatterns);
            textBoxSearchItem.Text = string.Join(Environment.NewLine, project.SearchItems.Select(s => s.Value));

            foreach (PathInformation path in project.Paths)
            {
                paths.Add(path);
            }
        }

        private void MapToObject()
        {
            textBoxSearchPattern.Text = textBoxSearchPattern.Text.Trim();
            textBoxSearchItem.Text = textBoxSearchItem.Text.Trim();

            Project newProject = new Project
            {
                FileName = project.FileName,
            };

            foreach (string line in textBoxSearchPattern.Lines.Where(line => !string.IsNullOrEmpty(line)).Distinct())
            {
                newProject.SearchPatterns.Add(line);
            }

            foreach (string line in textBoxSearchItem.Lines.Where(line => !string.IsNullOrEmpty(line)).Distinct())
            {
                newProject.SearchItems.Add(new SearchItem { Value = line });
            }

            foreach (PathInformation path in paths)
            {
                if (!newProject.Paths.Any(p => p.Path == path.Path))
                {
                    newProject.Paths.Add(path);
                }
            }

            project.Update(newProject);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (UserInputIsValid())
            {
                MapToObject();
                DialogResult = DialogResult.OK;
            }
        }

        private bool UserInputIsValid()
        {
            if (string.IsNullOrWhiteSpace(textBoxSearchPattern.Text))
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("Please inform at least one File Filter.");
                builder.Append("Note: if you would like to search all files, ");
                builder.Append("use the following filter: *.*");

                MessageBox.Show(
                    builder.ToString(),
                    "Fields Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxSearchPattern.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxSearchItem.Text))
            {
                MessageBox.Show(
                    "Please inform at least one string to search for.",
                    "Fields Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBoxSearchItem.Focus();
                return false;
            }

            if (paths.Count == 0)
            {
                MessageBox.Show(
                    "Please inform at least one path.",
                    "Fields Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                buttonSelectPath.Focus();
                return false;
            }

            foreach (PathInformation path in paths)
            {
                path.Exists = Directory.Exists(path.Path);
            }

            if (paths.Any<PathInformation>(s => !s.Exists))
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("There is at least one path that doens't exist.");
                builder.Append("Please remove the invalid paths and try again.");

                MessageBox.Show(
                    builder.ToString(),
                    "Fields Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dataGridViewPath.Focus();
                return false;
            }

            return true;
        }
    }
}
