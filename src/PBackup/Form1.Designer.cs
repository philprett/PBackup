namespace PBackup
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.butIncludeAddFile = new System.Windows.Forms.Button();
            this.butIncludeDelete = new System.Windows.Forms.Button();
            this.butIncludeAddFolder = new System.Windows.Forms.Button();
            this.lstIncludes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butExcludeAddText = new System.Windows.Forms.Button();
            this.butExcludeAddFile = new System.Windows.Forms.Button();
            this.butExcludeAddFolder = new System.Windows.Forms.Button();
            this.butExcludeDelete = new System.Windows.Forms.Button();
            this.lstExcludes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBackupStatus2 = new System.Windows.Forms.Label();
            this.lblLastRun = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radRunEveryDays = new System.Windows.Forms.RadioButton();
            this.radRunEveryHours = new System.Windows.Forms.RadioButton();
            this.radRunEveryMinutes = new System.Windows.Forms.RadioButton();
            this.txtRunEvery = new System.Windows.Forms.TextBox();
            this.chkRunEvery = new System.Windows.Forms.CheckBox();
            this.lblBackupStatus1 = new System.Windows.Forms.Label();
            this.butDestinationBrowse = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.runBackupNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backedUpFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.butDestinationBrowse);
            this.splitContainer1.Panel2.Controls.Add(this.txtDestination);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(753, 351);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.butIncludeAddFile);
            this.splitContainer2.Panel1.Controls.Add(this.butIncludeDelete);
            this.splitContainer2.Panel1.Controls.Add(this.butIncludeAddFolder);
            this.splitContainer2.Panel1.Controls.Add(this.lstIncludes);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.butExcludeAddText);
            this.splitContainer2.Panel2.Controls.Add(this.butExcludeAddFile);
            this.splitContainer2.Panel2.Controls.Add(this.butExcludeAddFolder);
            this.splitContainer2.Panel2.Controls.Add(this.butExcludeDelete);
            this.splitContainer2.Panel2.Controls.Add(this.lstExcludes);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(753, 190);
            this.splitContainer2.SplitterDistance = 376;
            this.splitContainer2.TabIndex = 0;
            // 
            // butIncludeAddFile
            // 
            this.butIncludeAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butIncludeAddFile.Image = global::PBackup.Properties.Resources.page_add;
            this.butIncludeAddFile.Location = new System.Drawing.Point(38, 159);
            this.butIncludeAddFile.Name = "butIncludeAddFile";
            this.butIncludeAddFile.Size = new System.Drawing.Size(26, 26);
            this.butIncludeAddFile.TabIndex = 5;
            this.butIncludeAddFile.UseVisualStyleBackColor = true;
            this.butIncludeAddFile.Click += new System.EventHandler(this.butIncludeAddFile_Click);
            // 
            // butIncludeDelete
            // 
            this.butIncludeDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butIncludeDelete.Image = global::PBackup.Properties.Resources.delete;
            this.butIncludeDelete.Location = new System.Drawing.Point(70, 159);
            this.butIncludeDelete.Name = "butIncludeDelete";
            this.butIncludeDelete.Size = new System.Drawing.Size(26, 26);
            this.butIncludeDelete.TabIndex = 4;
            this.butIncludeDelete.UseVisualStyleBackColor = true;
            this.butIncludeDelete.Click += new System.EventHandler(this.butIncludeDelete_Click);
            // 
            // butIncludeAddFolder
            // 
            this.butIncludeAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butIncludeAddFolder.Image = global::PBackup.Properties.Resources.folder_add;
            this.butIncludeAddFolder.Location = new System.Drawing.Point(6, 159);
            this.butIncludeAddFolder.Name = "butIncludeAddFolder";
            this.butIncludeAddFolder.Size = new System.Drawing.Size(26, 26);
            this.butIncludeAddFolder.TabIndex = 2;
            this.butIncludeAddFolder.UseVisualStyleBackColor = true;
            this.butIncludeAddFolder.Click += new System.EventHandler(this.butIncludeAddFolder_Click);
            // 
            // lstIncludes
            // 
            this.lstIncludes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstIncludes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstIncludes.FormattingEnabled = true;
            this.lstIncludes.Location = new System.Drawing.Point(6, 25);
            this.lstIncludes.Name = "lstIncludes";
            this.lstIncludes.Size = new System.Drawing.Size(367, 121);
            this.lstIncludes.TabIndex = 1;
            this.lstIncludes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstIncludes_DrawItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Include";
            // 
            // butExcludeAddText
            // 
            this.butExcludeAddText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butExcludeAddText.Image = global::PBackup.Properties.Resources.add;
            this.butExcludeAddText.Location = new System.Drawing.Point(70, 159);
            this.butExcludeAddText.Name = "butExcludeAddText";
            this.butExcludeAddText.Size = new System.Drawing.Size(26, 26);
            this.butExcludeAddText.TabIndex = 11;
            this.butExcludeAddText.UseVisualStyleBackColor = true;
            this.butExcludeAddText.Click += new System.EventHandler(this.butExcludeAddText_Click);
            // 
            // butExcludeAddFile
            // 
            this.butExcludeAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butExcludeAddFile.Image = global::PBackup.Properties.Resources.page_add;
            this.butExcludeAddFile.Location = new System.Drawing.Point(38, 159);
            this.butExcludeAddFile.Name = "butExcludeAddFile";
            this.butExcludeAddFile.Size = new System.Drawing.Size(26, 26);
            this.butExcludeAddFile.TabIndex = 10;
            this.butExcludeAddFile.UseVisualStyleBackColor = true;
            this.butExcludeAddFile.Click += new System.EventHandler(this.butExcludeAddFile_Click);
            // 
            // butExcludeAddFolder
            // 
            this.butExcludeAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butExcludeAddFolder.Image = global::PBackup.Properties.Resources.folder_add;
            this.butExcludeAddFolder.Location = new System.Drawing.Point(6, 159);
            this.butExcludeAddFolder.Name = "butExcludeAddFolder";
            this.butExcludeAddFolder.Size = new System.Drawing.Size(26, 26);
            this.butExcludeAddFolder.TabIndex = 9;
            this.butExcludeAddFolder.UseVisualStyleBackColor = true;
            this.butExcludeAddFolder.Click += new System.EventHandler(this.butExcludeAddFolder_Click);
            // 
            // butExcludeDelete
            // 
            this.butExcludeDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butExcludeDelete.Image = global::PBackup.Properties.Resources.delete;
            this.butExcludeDelete.Location = new System.Drawing.Point(102, 159);
            this.butExcludeDelete.Name = "butExcludeDelete";
            this.butExcludeDelete.Size = new System.Drawing.Size(26, 26);
            this.butExcludeDelete.TabIndex = 8;
            this.butExcludeDelete.UseVisualStyleBackColor = true;
            this.butExcludeDelete.Click += new System.EventHandler(this.butExcludeDelete_Click);
            // 
            // lstExcludes
            // 
            this.lstExcludes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstExcludes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstExcludes.FormattingEnabled = true;
            this.lstExcludes.Location = new System.Drawing.Point(3, 25);
            this.lstExcludes.Name = "lstExcludes";
            this.lstExcludes.Size = new System.Drawing.Size(367, 121);
            this.lstExcludes.TabIndex = 5;
            this.lstExcludes.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstExcludes_DrawItem);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Exclude";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblBackupStatus2);
            this.groupBox1.Controls.Add(this.lblLastRun);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radRunEveryDays);
            this.groupBox1.Controls.Add(this.radRunEveryHours);
            this.groupBox1.Controls.Add(this.radRunEveryMinutes);
            this.groupBox1.Controls.Add(this.txtRunEvery);
            this.groupBox1.Controls.Add(this.chkRunEvery);
            this.groupBox1.Controls.Add(this.lblBackupStatus1);
            this.groupBox1.Location = new System.Drawing.Point(6, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 113);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup";
            // 
            // lblBackupStatus2
            // 
            this.lblBackupStatus2.AutoSize = true;
            this.lblBackupStatus2.Location = new System.Drawing.Point(6, 53);
            this.lblBackupStatus2.Name = "lblBackupStatus2";
            this.lblBackupStatus2.Size = new System.Drawing.Size(142, 13);
            this.lblBackupStatus2.TabIndex = 8;
            this.lblBackupStatus2.Text = "                                             ";
            // 
            // lblLastRun
            // 
            this.lblLastRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLastRun.AutoSize = true;
            this.lblLastRun.Location = new System.Drawing.Point(420, 90);
            this.lblLastRun.Name = "lblLastRun";
            this.lblLastRun.Size = new System.Drawing.Size(34, 13);
            this.lblLastRun.TabIndex = 7;
            this.lblLastRun.Text = "never";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last run:";
            // 
            // radRunEveryDays
            // 
            this.radRunEveryDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radRunEveryDays.AutoSize = true;
            this.radRunEveryDays.Location = new System.Drawing.Point(268, 88);
            this.radRunEveryDays.Name = "radRunEveryDays";
            this.radRunEveryDays.Size = new System.Drawing.Size(47, 17);
            this.radRunEveryDays.TabIndex = 5;
            this.radRunEveryDays.TabStop = true;
            this.radRunEveryDays.Text = "days";
            this.radRunEveryDays.UseVisualStyleBackColor = true;
            // 
            // radRunEveryHours
            // 
            this.radRunEveryHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radRunEveryHours.AutoSize = true;
            this.radRunEveryHours.Location = new System.Drawing.Point(211, 89);
            this.radRunEveryHours.Name = "radRunEveryHours";
            this.radRunEveryHours.Size = new System.Drawing.Size(51, 17);
            this.radRunEveryHours.TabIndex = 4;
            this.radRunEveryHours.TabStop = true;
            this.radRunEveryHours.Text = "hours";
            this.radRunEveryHours.UseVisualStyleBackColor = true;
            // 
            // radRunEveryMinutes
            // 
            this.radRunEveryMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radRunEveryMinutes.AutoSize = true;
            this.radRunEveryMinutes.Location = new System.Drawing.Point(144, 88);
            this.radRunEveryMinutes.Name = "radRunEveryMinutes";
            this.radRunEveryMinutes.Size = new System.Drawing.Size(61, 17);
            this.radRunEveryMinutes.TabIndex = 3;
            this.radRunEveryMinutes.TabStop = true;
            this.radRunEveryMinutes.Text = "minutes";
            this.radRunEveryMinutes.UseVisualStyleBackColor = true;
            // 
            // txtRunEvery
            // 
            this.txtRunEvery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRunEvery.Location = new System.Drawing.Point(87, 87);
            this.txtRunEvery.Name = "txtRunEvery";
            this.txtRunEvery.Size = new System.Drawing.Size(35, 20);
            this.txtRunEvery.TabIndex = 2;
            // 
            // chkRunEvery
            // 
            this.chkRunEvery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkRunEvery.AutoSize = true;
            this.chkRunEvery.Location = new System.Drawing.Point(6, 90);
            this.chkRunEvery.Name = "chkRunEvery";
            this.chkRunEvery.Size = new System.Drawing.Size(75, 17);
            this.chkRunEvery.TabIndex = 1;
            this.chkRunEvery.Text = "Run every";
            this.chkRunEvery.UseVisualStyleBackColor = true;
            // 
            // lblBackupStatus1
            // 
            this.lblBackupStatus1.AutoSize = true;
            this.lblBackupStatus1.Location = new System.Drawing.Point(6, 23);
            this.lblBackupStatus1.Name = "lblBackupStatus1";
            this.lblBackupStatus1.Size = new System.Drawing.Size(154, 13);
            this.lblBackupStatus1.TabIndex = 0;
            this.lblBackupStatus1.Text = "                                                 ";
            // 
            // butDestinationBrowse
            // 
            this.butDestinationBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butDestinationBrowse.Image = global::PBackup.Properties.Resources.pencil;
            this.butDestinationBrowse.Location = new System.Drawing.Point(724, 4);
            this.butDestinationBrowse.Name = "butDestinationBrowse";
            this.butDestinationBrowse.Size = new System.Drawing.Size(26, 26);
            this.butDestinationBrowse.TabIndex = 7;
            this.butDestinationBrowse.UseVisualStyleBackColor = true;
            this.butDestinationBrowse.Click += new System.EventHandler(this.butDestinationBrowse_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestination.Enabled = false;
            this.txtDestination.Location = new System.Drawing.Point(69, 7);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(649, 20);
            this.txtDestination.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Destination";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runBackupNowToolStripMenuItem,
            this.stopBackupToolStripMenuItem,
            this.backedUpFilesToolStripMenuItem,
            this.logToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // runBackupNowToolStripMenuItem
            // 
            this.runBackupNowToolStripMenuItem.Image = global::PBackup.Properties.Resources.shield_go;
            this.runBackupNowToolStripMenuItem.Name = "runBackupNowToolStripMenuItem";
            this.runBackupNowToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.runBackupNowToolStripMenuItem.Text = "Run Backup Now";
            this.runBackupNowToolStripMenuItem.Click += new System.EventHandler(this.runBackupNowToolStripMenuItem_Click);
            // 
            // stopBackupToolStripMenuItem
            // 
            this.stopBackupToolStripMenuItem.Enabled = false;
            this.stopBackupToolStripMenuItem.Image = global::PBackup.Properties.Resources.stop;
            this.stopBackupToolStripMenuItem.Name = "stopBackupToolStripMenuItem";
            this.stopBackupToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.stopBackupToolStripMenuItem.Text = "Stop Backup";
            this.stopBackupToolStripMenuItem.Click += new System.EventHandler(this.stopBackupToolStripMenuItem_Click);
            // 
            // backedUpFilesToolStripMenuItem
            // 
            this.backedUpFilesToolStripMenuItem.Image = global::PBackup.Properties.Resources.zoom;
            this.backedUpFilesToolStripMenuItem.Name = "backedUpFilesToolStripMenuItem";
            this.backedUpFilesToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.backedUpFilesToolStripMenuItem.Text = "Backed Up Files";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Image = global::PBackup.Properties.Resources.table;
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 379);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(628, 386);
            this.Name = "Form1";
            this.Text = "PBackup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button butIncludeAddFolder;
        private System.Windows.Forms.ListBox lstIncludes;
        private System.Windows.Forms.Button butIncludeAddFile;
        private System.Windows.Forms.Button butIncludeDelete;
        private System.Windows.Forms.Button butExcludeDelete;
        private System.Windows.Forms.ListBox lstExcludes;
        private System.Windows.Forms.Button butExcludeAddText;
        private System.Windows.Forms.Button butExcludeAddFile;
        private System.Windows.Forms.Button butExcludeAddFolder;
        private System.Windows.Forms.Button butDestinationBrowse;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLastRun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radRunEveryDays;
        private System.Windows.Forms.RadioButton radRunEveryHours;
        private System.Windows.Forms.RadioButton radRunEveryMinutes;
        private System.Windows.Forms.TextBox txtRunEvery;
        private System.Windows.Forms.CheckBox chkRunEvery;
        private System.Windows.Forms.Label lblBackupStatus1;
        private System.Windows.Forms.ToolStripMenuItem runBackupNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backedUpFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.Label lblBackupStatus2;
    }
}

