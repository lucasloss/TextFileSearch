namespace TextFileSearch
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSearching = new System.Windows.Forms.Panel();
            this.panelProgressTitle = new System.Windows.Forms.Panel();
            this.labelProgressPanelTitle = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveProjectAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.recentProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.panelSearchResult = new System.Windows.Forms.Panel();
            this.textBoxSearchResult = new System.Windows.Forms.RichTextBox();
            this.labelSearchResults = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTopRight = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelTopLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.buttonLoadedFiles = new System.Windows.Forms.Button();
            this.buttonReloadFiles = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCurrentProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSearching.SuspendLayout();
            this.panelProgressTitle.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel.SuspendLayout();
            this.panelSearchResult.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.flowLayoutPanelTopRight.SuspendLayout();
            this.flowLayoutPanelTopLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearching
            // 
            this.panelSearching.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSearching.BackColor = System.Drawing.Color.White;
            this.panelSearching.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearching.Controls.Add(this.panelProgressTitle);
            this.panelSearching.Controls.Add(this.textBoxSearch);
            this.panelSearching.Controls.Add(this.progressBar);
            this.panelSearching.Location = new System.Drawing.Point(143, 241);
            this.panelSearching.Name = "panelSearching";
            this.panelSearching.Size = new System.Drawing.Size(497, 81);
            this.panelSearching.TabIndex = 10;
            this.panelSearching.Visible = false;
            // 
            // panelProgressTitle
            // 
            this.panelProgressTitle.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelProgressTitle.Controls.Add(this.labelProgressPanelTitle);
            this.panelProgressTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProgressTitle.Location = new System.Drawing.Point(0, 0);
            this.panelProgressTitle.Name = "panelProgressTitle";
            this.panelProgressTitle.Size = new System.Drawing.Size(495, 22);
            this.panelProgressTitle.TabIndex = 13;
            // 
            // labelProgressPanelTitle
            // 
            this.labelProgressPanelTitle.AutoEllipsis = true;
            this.labelProgressPanelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelProgressPanelTitle.ForeColor = System.Drawing.Color.White;
            this.labelProgressPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelProgressPanelTitle.Name = "labelProgressPanelTitle";
            this.labelProgressPanelTitle.Size = new System.Drawing.Size(126, 22);
            this.labelProgressPanelTitle.TabIndex = 0;
            this.labelProgressPanelTitle.Text = "Please wait...";
            this.labelProgressPanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Enabled = false;
            this.textBoxSearch.Location = new System.Drawing.Point(11, 47);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.ReadOnly = true;
            this.textBoxSearch.Size = new System.Drawing.Size(471, 33);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.Text = "Loading/Searching...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(11, 28);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(471, 18);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveProjectToolStripMenuItem,
            this.saveProjectAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.editCurrentProjectToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator4,
            this.recentProjectsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(223, 6);
            // 
            // saveProjectAsToolStripMenuItem
            // 
            this.saveProjectAsToolStripMenuItem.Image = global::TextFileSearch.Properties.Resources.SaveAs_16x;
            this.saveProjectAsToolStripMenuItem.Name = "saveProjectAsToolStripMenuItem";
            this.saveProjectAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveProjectAsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.saveProjectAsToolStripMenuItem.Text = "Save Project As...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(223, 6);
            // 
            // recentProjectsToolStripMenuItem
            // 
            this.recentProjectsToolStripMenuItem.Name = "recentProjectsToolStripMenuItem";
            this.recentProjectsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.recentProjectsToolStripMenuItem.Text = "Recent Projects";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(223, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.panelSearching);
            this.panel.Controls.Add(this.panelSearchResult);
            this.panel.Controls.Add(this.panelTop);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 24);
            this.panel.Name = "panel";
            this.panel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 3);
            this.panel.Size = new System.Drawing.Size(784, 515);
            this.panel.TabIndex = 14;
            // 
            // panelSearchResult
            // 
            this.panelSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchResult.Controls.Add(this.textBoxSearchResult);
            this.panelSearchResult.Controls.Add(this.labelSearchResults);
            this.panelSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchResult.Location = new System.Drawing.Point(5, 46);
            this.panelSearchResult.Name = "panelSearchResult";
            this.panelSearchResult.Size = new System.Drawing.Size(774, 466);
            this.panelSearchResult.TabIndex = 21;
            // 
            // textBoxSearchResult
            // 
            this.textBoxSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearchResult.Font = new System.Drawing.Font("Consolas", 9F);
            this.textBoxSearchResult.Location = new System.Drawing.Point(0, 17);
            this.textBoxSearchResult.MaxLength = 0;
            this.textBoxSearchResult.Name = "textBoxSearchResult";
            this.textBoxSearchResult.Size = new System.Drawing.Size(772, 447);
            this.textBoxSearchResult.TabIndex = 20;
            this.textBoxSearchResult.Text = "";
            this.textBoxSearchResult.WordWrap = false;
            // 
            // labelSearchResults
            // 
            this.labelSearchResults.BackColor = System.Drawing.Color.DimGray;
            this.labelSearchResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSearchResults.Font = new System.Drawing.Font("Consolas", 9F);
            this.labelSearchResults.ForeColor = System.Drawing.Color.White;
            this.labelSearchResults.Location = new System.Drawing.Point(0, 0);
            this.labelSearchResults.Name = "labelSearchResults";
            this.labelSearchResults.Size = new System.Drawing.Size(772, 17);
            this.labelSearchResults.TabIndex = 19;
            this.labelSearchResults.Text = "Search Results";
            this.labelSearchResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.flowLayoutPanelTopRight);
            this.panelTop.Controls.Add(this.flowLayoutPanelTopLeft);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(5, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(774, 46);
            this.panelTop.TabIndex = 17;
            // 
            // flowLayoutPanelTopRight
            // 
            this.flowLayoutPanelTopRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelTopRight.AutoSize = true;
            this.flowLayoutPanelTopRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelTopRight.Controls.Add(this.buttonLoadedFiles);
            this.flowLayoutPanelTopRight.Controls.Add(this.buttonReloadFiles);
            this.flowLayoutPanelTopRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelTopRight.Location = new System.Drawing.Point(570, 17);
            this.flowLayoutPanelTopRight.Name = "flowLayoutPanelTopRight";
            this.flowLayoutPanelTopRight.Size = new System.Drawing.Size(204, 29);
            this.flowLayoutPanelTopRight.TabIndex = 18;
            // 
            // flowLayoutPanelTopLeft
            // 
            this.flowLayoutPanelTopLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelTopLeft.AutoSize = true;
            this.flowLayoutPanelTopLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelTopLeft.Controls.Add(this.buttonSearch);
            this.flowLayoutPanelTopLeft.Location = new System.Drawing.Point(0, 2);
            this.flowLayoutPanelTopLeft.Name = "flowLayoutPanelTopLeft";
            this.flowLayoutPanelTopLeft.Size = new System.Drawing.Size(86, 44);
            this.flowLayoutPanelTopLeft.TabIndex = 17;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Location = new System.Drawing.Point(0, 539);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(784, 22);
            this.statusStripMain.SizingGrip = false;
            this.statusStripMain.TabIndex = 16;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // buttonLoadedFiles
            // 
            this.buttonLoadedFiles.AutoSize = true;
            this.buttonLoadedFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLoadedFiles.Image = global::TextFileSearch.Properties.Resources.FileCollection_16x;
            this.buttonLoadedFiles.Location = new System.Drawing.Point(94, 3);
            this.buttonLoadedFiles.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.buttonLoadedFiles.Name = "buttonLoadedFiles";
            this.buttonLoadedFiles.Size = new System.Drawing.Size(110, 23);
            this.buttonLoadedFiles.TabIndex = 5;
            this.buttonLoadedFiles.Text = "No Files Loaded";
            this.buttonLoadedFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLoadedFiles.UseVisualStyleBackColor = true;
            // 
            // buttonReloadFiles
            // 
            this.buttonReloadFiles.AutoSize = true;
            this.buttonReloadFiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReloadFiles.Image = global::TextFileSearch.Properties.Resources.Refresh_16x;
            this.buttonReloadFiles.Location = new System.Drawing.Point(0, 3);
            this.buttonReloadFiles.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.buttonReloadFiles.Name = "buttonReloadFiles";
            this.buttonReloadFiles.Size = new System.Drawing.Size(91, 23);
            this.buttonReloadFiles.TabIndex = 3;
            this.buttonReloadFiles.Text = "Reload Files";
            this.buttonReloadFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReloadFiles.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearch.Image = global::TextFileSearch.Properties.Resources.Search_32x;
            this.buttonSearch.Location = new System.Drawing.Point(0, 3);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(83, 38);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Image = global::TextFileSearch.Properties.Resources.NewFile_16x;
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.newProjectToolStripMenuItem.Text = "New Project...";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Image = global::TextFileSearch.Properties.Resources.OpenFile_16x;
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project...";
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Image = global::TextFileSearch.Properties.Resources.Save_16x;
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.saveProjectToolStripMenuItem.Text = "Save Project...";
            // 
            // editCurrentProjectToolStripMenuItem
            // 
            this.editCurrentProjectToolStripMenuItem.Image = global::TextFileSearch.Properties.Resources.Edit_16x;
            this.editCurrentProjectToolStripMenuItem.Name = "editCurrentProjectToolStripMenuItem";
            this.editCurrentProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editCurrentProjectToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.editCurrentProjectToolStripMenuItem.Text = "Edit Project";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::TextFileSearch.Properties.Resources.Close_16x;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.closeToolStripMenuItem.Text = "Close Project";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::TextFileSearch.Properties.Resources.TextFileSearch_16x;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(635, 352);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text File Search";
            this.panelSearching.ResumeLayout(false);
            this.panelSearching.PerformLayout();
            this.panelProgressTitle.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panelSearchResult.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.flowLayoutPanelTopRight.ResumeLayout(false);
            this.flowLayoutPanelTopRight.PerformLayout();
            this.flowLayoutPanelTopLeft.ResumeLayout(false);
            this.flowLayoutPanelTopLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelSearching;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem editCurrentProjectToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTopRight;
        private System.Windows.Forms.Button buttonLoadedFiles;
        private System.Windows.Forms.Button buttonReloadFiles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTopLeft;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearchResults;
        private System.Windows.Forms.RichTextBox textBoxSearchResult;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelProgressTitle;
        private System.Windows.Forms.Label labelProgressPanelTitle;
        private System.Windows.Forms.Panel panelSearchResult;
    }
}

