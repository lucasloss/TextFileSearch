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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelBottomSeparator = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonAddPath = new System.Windows.Forms.Button();
            this.buttonRemoveSelectedPath = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPath)).BeginInit();
            this.flowLayoutPanelBottom.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFileFilters
            // 
            this.labelFileFilters.AutoSize = true;
            this.labelFileFilters.Location = new System.Drawing.Point(10, 8);
            this.labelFileFilters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFileFilters.Name = "labelFileFilters";
            this.labelFileFilters.Size = new System.Drawing.Size(132, 15);
            this.labelFileFilters.TabIndex = 9;
            this.labelFileFilters.Text = "File Filters (one per line)";
            // 
            // textBoxSearchPattern
            // 
            this.textBoxSearchPattern.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearchPattern.Location = new System.Drawing.Point(14, 25);
            this.textBoxSearchPattern.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSearchPattern.Multiline = true;
            this.textBoxSearchPattern.Name = "textBoxSearchPattern";
            this.textBoxSearchPattern.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSearchPattern.Size = new System.Drawing.Size(172, 200);
            this.textBoxSearchPattern.TabIndex = 0;
            // 
            // labelStringsToSearchFor
            // 
            this.labelStringsToSearchFor.AutoSize = true;
            this.labelStringsToSearchFor.Location = new System.Drawing.Point(190, 8);
            this.labelStringsToSearchFor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStringsToSearchFor.Name = "labelStringsToSearchFor";
            this.labelStringsToSearchFor.Size = new System.Drawing.Size(185, 15);
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
            this.dataGridViewPath.Location = new System.Drawing.Point(14, 309);
            this.dataGridViewPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewPath.MultiSelect = false;
            this.dataGridViewPath.Name = "dataGridViewPath";
            this.dataGridViewPath.RowHeadersVisible = false;
            this.dataGridViewPath.RowHeadersWidth = 30;
            this.dataGridViewPath.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPath.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPath.Size = new System.Drawing.Size(618, 138);
            this.dataGridViewPath.StandardTab = true;
            this.dataGridViewPath.TabIndex = 6;
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.AutoSize = true;
            this.buttonSelectPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSelectPath.Location = new System.Drawing.Point(567, 252);
            this.buttonSelectPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(57, 25);
            this.buttonSelectPath.TabIndex = 3;
            this.buttonSelectPath.Text = "Select...";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchItem
            // 
            this.textBoxSearchItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearchItem.Location = new System.Drawing.Point(194, 25);
            this.textBoxSearchItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSearchItem.Multiline = true;
            this.textBoxSearchItem.Name = "textBoxSearchItem";
            this.textBoxSearchItem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSearchItem.Size = new System.Drawing.Size(438, 200);
            this.textBoxSearchItem.TabIndex = 1;
            // 
            // flowLayoutPanelBottom
            // 
            this.flowLayoutPanelBottom.AutoSize = true;
            this.flowLayoutPanelBottom.Controls.Add(this.buttonCancel);
            this.flowLayoutPanelBottom.Controls.Add(this.buttonOK);
            this.flowLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelBottom.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelBottom.Location = new System.Drawing.Point(0, 458);
            this.flowLayoutPanelBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            this.flowLayoutPanelBottom.Padding = new System.Windows.Forms.Padding(9, 6, 0, 6);
            this.flowLayoutPanelBottom.Size = new System.Drawing.Size(646, 45);
            this.flowLayoutPanelBottom.TabIndex = 7;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(545, 9);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 27);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(449, 9);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(88, 27);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // labelBottomSeparator
            // 
            this.labelBottomSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBottomSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelBottomSeparator.Location = new System.Drawing.Point(0, 456);
            this.labelBottomSeparator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBottomSeparator.Name = "labelBottomSeparator";
            this.labelBottomSeparator.Size = new System.Drawing.Size(646, 2);
            this.labelBottomSeparator.TabIndex = 28;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(14, 253);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(549, 23);
            this.textBoxPath.TabIndex = 2;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(10, 234);
            this.labelPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(31, 15);
            this.labelPath.TabIndex = 31;
            this.labelPath.Text = "Path";
            // 
            // buttonAddPath
            // 
            this.buttonAddPath.AutoSize = true;
            this.buttonAddPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddPath.Location = new System.Drawing.Point(4, 3);
            this.buttonAddPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddPath.Name = "buttonAddPath";
            this.buttonAddPath.Size = new System.Drawing.Size(39, 25);
            this.buttonAddPath.TabIndex = 4;
            this.buttonAddPath.Text = "Add";
            this.buttonAddPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddPath.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveSelectedPath
            // 
            this.buttonRemoveSelectedPath.AutoSize = true;
            this.buttonRemoveSelectedPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRemoveSelectedPath.Location = new System.Drawing.Point(51, 3);
            this.buttonRemoveSelectedPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRemoveSelectedPath.Name = "buttonRemoveSelectedPath";
            this.buttonRemoveSelectedPath.Size = new System.Drawing.Size(107, 25);
            this.buttonRemoveSelectedPath.TabIndex = 5;
            this.buttonRemoveSelectedPath.Text = "Remove Selected";
            this.buttonRemoveSelectedPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRemoveSelectedPath.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.buttonAddPath);
            this.flowLayoutPanel1.Controls.Add(this.buttonRemoveSelectedPath);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 278);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(162, 31);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(646, 503);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelBottomSeparator);
            this.Controls.Add(this.flowLayoutPanelBottom);
            this.Controls.Add(this.textBoxSearchItem);
            this.Controls.Add(this.buttonSelectPath);
            this.Controls.Add(this.dataGridViewPath);
            this.Controls.Add(this.labelStringsToSearchFor);
            this.Controls.Add(this.textBoxSearchPattern);
            this.Controls.Add(this.labelFileFilters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}