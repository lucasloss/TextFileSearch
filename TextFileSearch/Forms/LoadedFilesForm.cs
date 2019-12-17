using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TextFileSearch
{
    /// <summary>
    /// A form that lists the text files currently loaded in the application.
    /// </summary>
    public partial class LoadedFilesForm : Form
    {
        private readonly List<TextFile> textFiles;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadedFilesForm"/> class.
        /// </summary>
        /// <param name="textFiles">A list of <see cref="TextFile"/> objects that represents the text files loaded in the application.</param>
        public LoadedFilesForm(List<TextFile> textFiles)
        {
            this.textFiles = textFiles;
            InitializeComponent();

            dataGridViewFiles.DataSource = textFiles;
            dataGridViewFiles.Columns[nameof(TextFile.Path)].HeaderText = "File";
            labelFileCount.Text = $"{textFiles.Count} Files";

            KeyUp += LoadedFilesForm_KeyUp;
        }

        private void LoadedFilesForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void TextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            List<TextFile> result = textFiles.Where(t => t.Path.Contains(textBoxFilter.Text)).ToList();
            dataGridViewFiles.DataSource = result;
            labelFileCount.Text = $"{result.Count} Files";
        }
    }
}
