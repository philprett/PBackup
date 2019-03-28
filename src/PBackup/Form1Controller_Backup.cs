using PBackup.Data;
using PBackup.LongFilenames;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBackup
{
    public partial class Form1 : Form
    {

        public class BackgroundWorkerStatus
        {
            public string Status1 { get; set; }
            public string Status2 { get; set; }
        }

        private BackgroundWorker backgroundWorker = null;

        public void RunBackup()
        {
            if (backgroundWorker != null)
            {
                return;
            }


            runBackupNowToolStripMenuItem.Enabled = false;
            stopBackupToolStripMenuItem.Enabled = true;
            lstIncludes.Enabled = false;
            lstExcludes.Enabled = false;
            butIncludeAddFile.Enabled = false;
            butIncludeAddFolder.Enabled = false;
            butIncludeDelete.Enabled = false;
            butExcludeAddFile.Enabled = false;
            butExcludeAddFolder.Enabled = false;
            butExcludeAddText.Enabled = false;
            butExcludeDelete.Enabled = false;
            butDestinationBrowse.Enabled = false;
            chkRunEvery.Enabled = false;
            txtRunEvery.Enabled = false;
            radRunEveryDays.Enabled = false;
            radRunEveryHours.Enabled = false;
            radRunEveryMinutes.Enabled = false;

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.RunWorkerAsync();
        }

        public void StopBackup()
        {
            if (backgroundWorker == null)
            {
                return;
            }

            backgroundWorker.CancelAsync();
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BackgroundWorkerStatus status = (BackgroundWorkerStatus)e.UserState;
            if (status != null && status.Status1 != null) lblBackupStatus1.Text = status.Status1;
            if (status != null && status.Status2 != null) lblBackupStatus2.Text = status.Status2;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorkerStatus status = (BackgroundWorkerStatus)e.UserState;
            if (status != null && status.Status1 != null) lblBackupStatus1.Text = status.Status1;
            if (status != null && status.Status2 != null) lblBackupStatus2.Text = status.Status2;

            runBackupNowToolStripMenuItem.Enabled = true;
            stopBackupToolStripMenuItem.Enabled = false;
            lstIncludes.Enabled = true;
            lstExcludes.Enabled = true;
            butIncludeAddFile.Enabled = true;
            butIncludeAddFolder.Enabled = true;
            butIncludeDelete.Enabled = true;
            butExcludeAddFile.Enabled = true;
            butExcludeAddFolder.Enabled = true;
            butExcludeAddText.Enabled = true;
            butExcludeDelete.Enabled = true;
            butDestinationBrowse.Enabled = true;
            chkRunEvery.Enabled = true;
            txtRunEvery.Enabled = true;
            radRunEveryDays.Enabled = true;
            radRunEveryHours.Enabled = true;
            radRunEveryMinutes.Enabled = true;

            backgroundWorker = null;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker thisBackgroundWorker = (BackgroundWorker)sender;

            void FolderBackupStarted(object sender2, FFolder.FolderEventArgs e2)
            {
                thisBackgroundWorker.ReportProgress(0, new BackgroundWorkerStatus()
                {
                    Status1 = string.Format("Scanning {0}...", e2.Path),
                    Status2 = null
                });
            }
            void FolderBackupFinished(object sender2, FFolder.FolderEventArgs e2)
            {
                thisBackgroundWorker.ReportProgress(0, new BackgroundWorkerStatus()
                {
                    Status1 = string.Format("Scanned {0}", e2.Path),
                    Status2 = null
                });
            }

            void FileBackupStarted(object sender2, FFile.FileEventArgs e2)
            {
                return;
            }
            void FileBackupFinished(object sender2, FFile.FileEventArgs e2)
            {
                thisBackgroundWorker.ReportProgress(0, new BackgroundWorkerStatus()
                {
                    Status1 = null,
                    Status2 = string.Format("Backed up {0}", e2.Path)
                });
            }

            foreach (IncludePath includePath in MainDbContext.DB.IncludePaths.OrderBy(p => p.Path.ToLower()))
            {
                if (thisBackgroundWorker.CancellationPending)
                {
                    break;
                }

                FFolder ffolder = new FFolder(includePath.Path);
                ffolder.BackgroundWorker = thisBackgroundWorker;
                ffolder.FolderBackupStarted += new FFolder.FolderBackupStartedHandler(FolderBackupStarted);
                ffolder.FolderBackupFinished += new FFolder.FolderBackupFinishedHandler(FolderBackupFinished);
                ffolder.FileBackupStarted += new FFile.FileBackupStartedHandler(FileBackupStarted);
                ffolder.FileBackupFinished += new FFile.FileBackupFinishedHandler(FileBackupFinished);
                ffolder.Backup();
            }
        }
    }
}
