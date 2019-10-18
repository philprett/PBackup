using PBackup.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBackup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshFromDB();
        }

        private void butIncludeAddFolder_Click(object sender, EventArgs e)
        {
            IncludeAddFolder();
        }

        private void butIncludeAddFile_Click(object sender, EventArgs e)
        {
            IncludeAddFile();
        }

        private void butIncludeDelete_Click(object sender, EventArgs e)
        {
            IncludeDelete();
        }

        private void lstIncludes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            ListBox lb = (ListBox)sender;
            IncludePath obj = (IncludePath)lb.Items[e.Index];
            string text = obj.Path;

            e.DrawBackground();

            Graphics g = e.Graphics;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                g.FillRectangle(SystemBrushes.Highlight, e.Bounds);
            }
            else
            {
                g.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            }
            g.DrawString(text, e.Font, new SolidBrush(e.ForeColor), new PointF(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }

        private void runBackupNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunBackup();
        }

        private void butDestinationBrowse_Click(object sender, EventArgs e)
        {
			ChangeDestination(txtDestination);
		}
		private void butDestination2Browse_Click(object sender, EventArgs e)
		{
			ChangeDestination(txtDestination2);
		}

		private void stopBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopBackup();
        }

        private void butExcludeAddFolder_Click(object sender, EventArgs e)
        {
            ExcludeAddFolder();
        }

        private void butExcludeAddFile_Click(object sender, EventArgs e)
        {
            ExcludeAddFile();
        }

        private void butExcludeDelete_Click(object sender, EventArgs e)
        {
            ExcludeDelete();
        }

        private void lstExcludes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            ListBox lb = (ListBox)sender;
            ExcludePath obj = (ExcludePath)lb.Items[e.Index];
            string text = obj.Path;

            e.DrawBackground();

            Graphics g = e.Graphics;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                g.FillRectangle(SystemBrushes.Highlight, e.Bounds);
            }
            else
            {
                g.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            }
            g.DrawString(text, e.Font, new SolidBrush(e.ForeColor), new PointF(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }

        private void butExcludeAddText_Click(object sender, EventArgs e)
        {
            ExcludeAddMask();
        }

        private void backUpBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBackupBrowser f = new FormBackupBrowser(BackupDbContext.Destination);
            f.ShowDialog();
        }

	}
}
