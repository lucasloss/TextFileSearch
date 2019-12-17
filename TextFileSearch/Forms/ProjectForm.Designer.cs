namespace TextFileSearch
{
    partial class ProjectForm
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
            this.labelFileFilters = new System.Windows.Forms.Label();
            this.textBoxSearchPattern = new System.Windows.Forms.TextBox();
            this.labelStringsToSearchFor = new System.Windows.Forms.Label();
            this.dataGridViewPath = new System.Windows.Forms.DataGridView();
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.textBoxSearchItem = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.labelBottomSeparator = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddPath = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonRemoveSelectedPath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPath)).BeginInit();
            this.flowLayoutPanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFileFilters
            // 
            this.labelFileFilters.AutoSize = true;
            this.labelFileFilters.Location = new System.Drawing.Point(9, 7);
            this.labelFileFilters.Name = "labelFileFilters";
            this.labelFileFilters.Size = new System.Drawing.Size(117, 13);
            this.labelFileFilters.TabIndex = 9;
            this.labelFileFilters.Text = "File Filters (one per line)";
            // 
            // textBoxSearchPattern
            // 
            this.textBoxSearchPattern.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchPattern.Location = new System.Drawing.Point(12, 22);
            this.textBoxSearchPattern.Multiline = true;
            this.textBoxSearchPattern.Name = "textBoxSearchPattern";
            this.textBoxSearchPattern.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSearchPattern.Size = new System.Drawing.Size(148, 174);
            this.textBoxSearchPattern.TabIndex = 0;
            // 
            // labelStringsToSearchFor
            // 
            this.labelStringsToSearchFor.AutoSize = true;
            this.labelStringsToSearchFor.Location = new System.Drawing.Point(163, 7);
            this.labelStringsToSearchFor.Name = "labelStringsToSearchFor";
            this.labelStringsToSearchFor.Size = new System.Drawing.Size(165, 13);
            this.labelStringsToSearchFor.TabIndex = 14;
            this.labelStringsToSearchFor.Text = "Strings to search for (one per line)";
            // 
            // dataGridViewPath
            // 
            this.dataGridViewPath.AllowUserToAddRows = false;
            this.dataGridViewPath.AllowUserToDeleteRows = false;
            this.dataGridViewPath.AllowUserToResizeColumns = false;
            this.dataGridViewPath.AllowUserToResizeRows = false;
            this.dataGridViewPath.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPath.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPath.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPath.Location = new System.Drawing.Point(12, 268);
            this.dataGridViewPath.MultiSelect = false;
            this.dataGridViewPath.Name = "dataGridViewPath";
            this.dataGridViewPath.RowHeadersVisible = false;
            this.dataGridViewPath.RowHeadersWidth = 30;
            this.dataGridViewPath.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPath.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPath.Size = new System.Drawing.Size(530, 120);
            this.dataGridViewPath.StandardTab = true;
            this.dataGridViewPath.TabIndex = 6;
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.AutoSize = true;
            this.buttonSelectPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSelectPath.Location = new System.Drawing.Point(486, 217);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(56, 23);
            this.buttonSelectPath.TabIndex = 3;
            this.buttonSelectPath.Text = "Select...";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchItem
            // 
            this.textBoxSearchItem.Font = new System.Drawing.Font("Consolas", 9F);
            this.textBoxSearchItem.Location = new System.Drawing.Point(166, 22);
            this.textBoxSearchItem.Multiline = true;
            this.textBoxSearchItem.Name = "textBoxSearchItem";
            this.textBoxSearchItem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSearchItem.Size = new System.Drawing.Size(376, 174);
            this.textBoxSearchItem.TabIndex = 1;
            // 
            // flowLayoutPanelBottom
            // 
            this.flowLayoutPanelBottom.AutoSize = true;
            this.flowLayoutPanelBottom.Controls.Add(this.buttonCancel);
            this.flowLayoutPanelBottom.Controls.Add(this.buttonOK);
            this.flowLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelBottom.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelBottom.Location = new System.Drawing.Point(0, 397);
            this.flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            this.flowLayoutPanelBottom.Padding = new System.Windows.Forms.Padding(8, 5, 0, 5);
            this.flowLayoutPanelBottom.Size = new System.Drawing.Size(554, 39);
            this.flowLayoutPanelBottom.TabIndex = 7;
            // 
            // labelBottomSeparator
            // 
            this.labelBottomSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBottomSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelBottomSeparator.Location = new System.Drawing.Point(0, 395);
            this.labelBottomSeparator.Name = "labelBottomSeparator";
            this.labelBottomSeparator.Size = new System.Drawing.Size(554, 2);
            this.labelBottomSeparator.TabIndex = 28;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 219);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(471, 20);
            this.textBoxPath.TabIndex = 2;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(9, 203);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(29, 13);
            this.labelPath.TabIndex = 31;
            this.labelPath.Text = "Path";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(468, 8);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAddPath
            // 
            this.buttonAddPath.AutoSize = true;
            this.buttonAddPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddPath.Image = global::TextFileSearch.Properties.Resources.Add_16x;
            this.buttonAddPath.Location = new System.Drawing.Point(12, 242);
            this.buttonAddPath.Name = "buttonAddPath";
            this.buttonAddPath.Size = new System.Drawing.Size(52, 23);
            this.buttonAddPath.TabIndex = 4;
            this.buttonAddPath.Text = "Add";
            this.buttonAddPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddPath.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(387, 8);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveSelectedPath
            // 
            this.buttonRemoveSelectedPath.AutoSize = true;
            this.buttonRemoveSelectedPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRemoveSelectedPath.Image = global::TextFileSearch.Properties.Resources.Remove_16x;
            this.buttonRemoveSelectedPath.Location = new System.Drawing.Point(67, 242);
            this.buttonRemoveSelectedPath.Name = "buttonRemoveSelectedPath";
            this.buttonRemoveSelectedPath.Size = new System.Drawing.Size(118, 23);
            this.buttonRemoveSelectedPath.TabIndex = 5;
            this.buttonRemoveSelectedPath.Text = "Remove Selected";
            this.buttonRemoveSelectedPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRemoveSelectedPath.UseVisualStyleBackColor = true;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(554, 436);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonAddPath);
            this.Controls.Add(this.labelBottomSeparator);
            this.Controls.Add(this.flowLayoutPanelBottom);
            this.Controls.Add(this.textBoxSearchItem);
            this.Controls.Add(this.buttonRemoveSelectedPath);
            this.Controls.Add(this.buttonSelectPath);
            this.Controls.Add(this.dataGridViewPath);
            this.Controls.Add(this.labelStringsToSearchFor);
            this.Controls.Add(this.textBoxSearchPattern);
            this.Controls.Add(this.labelFileFilters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Project Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPath)).EndInit();
            this.flowLayoutPanelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFileFilters;
        private System.Windows.Forms.TextBox textBoxSearchPattern;
        private System.Windows.Forms.Label labelStringsToSearchFor;
        private System.Windows.Forms.DataGridView dataGridViewPath;
        private System.Windows.Forms.Button buttonRemoveSelectedPath;
        private System.Windows.Forms.Button buttonSelectPath;
        private System.Windows.Forms.TextBox textBoxSearchItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBottom;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelBottomSeparator;
        private System.Windows.Forms.Button buttonAddPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelPath;
    }
}