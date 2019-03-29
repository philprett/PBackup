namespace PBackup
{
    partial class FormBackupBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackupBrowser));
            this.label1 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastModified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackupVersions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup Location";
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.BackgroundColor = System.Drawing.Color.White;
            this.Grid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Filename,
            this.LastModified,
            this.FileSize,
            this.BackupVersions});
            this.Grid.Location = new System.Drawing.Point(15, 86);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(804, 397);
            this.Grid.TabIndex = 2;
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestination.Enabled = false;
            this.txtDestination.Location = new System.Drawing.Point(106, 12);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(713, 20);
            this.txtDestination.TabIndex = 3;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(106, 38);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(713, 20);
            this.txtPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contents";
            // 
            // Filename
            // 
            this.Filename.HeaderText = "Name";
            this.Filename.Name = "Filename";
            this.Filename.ReadOnly = true;
            // 
            // LastModified
            // 
            this.LastModified.HeaderText = "Modified";
            this.LastModified.Name = "LastModified";
            this.LastModified.ReadOnly = true;
            // 
            // FileSize
            // 
            this.FileSize.HeaderText = "Size";
            this.FileSize.Name = "FileSize";
            this.FileSize.ReadOnly = true;
            // 
            // BackupVersions
            // 
            this.BackupVersions.HeaderText = "Versions";
            this.BackupVersions.Name = "BackupVersions";
            this.BackupVersions.ReadOnly = true;
            // 
            // FormBackupBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 495);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBackupBrowser";
            this.Text = "Backup Browser";
            this.Load += new System.EventHandler(this.FormBackupBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastModified;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackupVersions;
    }
}