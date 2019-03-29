namespace PBackup
{
    partial class FormAddExcludeText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddExcludeText));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.butCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.butOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your new exclude mask.";
            // 
            // txtMask
            // 
            this.txtMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMask.Location = new System.Drawing.Point(34, 81);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(356, 20);
            this.txtMask.TabIndex = 1;
            // 
            // butCancel
            // 
            this.butCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butCancel.Image = global::PBackup.Properties.Resources.cross;
            this.butCancel.Location = new System.Drawing.Point(238, 163);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 3;
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "You can add an asterix (*) at the beginning and/or end.";
            // 
            // butOK
            // 
            this.butOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butOK.Image = global::PBackup.Properties.Resources.add;
            this.butOK.Location = new System.Drawing.Point(114, 163);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 2;
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // FormAddExcludeText
            // 
            this.AcceptButton = this.butOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(426, 215);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.txtMask);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(9999, 254);
            this.MinimumSize = new System.Drawing.Size(360, 254);
            this.Name = "FormAddExcludeText";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Exclude";
            this.Load += new System.EventHandler(this.FormAddExcludeText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label label2;
    }
}