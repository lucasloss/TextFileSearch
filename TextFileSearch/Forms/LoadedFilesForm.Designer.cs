namespace TextFileSearch
{
    partial class LoadedFilesForm
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
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.labelFilter = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelFileCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.Location = new System.Drawing.Point(12, 25);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(633, 20);
            this.textBoxFilter.TabIndex = 0;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.TextBoxFilter_TextChanged);
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AllowUserToAddRows = false;
            this.dataGridViewFiles.AllowUserToDeleteRows = false;
            this.dataGridViewFiles.AllowUserToResizeRows = false;
            this.dataGridViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFiles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.ColumnHeadersVisible = false;
            this.dataGridViewFiles.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.ReadOnly = true;
            this.dataGridViewFiles.RowHeadersVisible = false;
            this.dataGridViewFiles.RowHeadersWidth = 30;
            this.dataGridViewFiles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewFiles.Size = new System.Drawing.Size(633, 374);
            this.dataGridViewFiles.StandardTab = true;
            this.dataGridViewFiles.TabIndex = 1;
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(9, 9);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(29, 13);
            this.labelFilter.TabIndex = 2;
            this.labelFilter.Text = "Filter";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelFileCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(657, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 3;
            // 
            // labelFileCount
            // 
            this.labelFileCount.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.labelFileCount.Name = "labelFileCount";
            this.labelFileCount.Size = new System.Drawing.Size(39, 17);
            this.labelFileCount.Text = "0 Files";
            // 
            // LoadedFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.dataGridViewFiles);
            this.Controls.Add(this.textBoxFilter);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "LoadedFilesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loaded Files";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelFileCount;
    }
}