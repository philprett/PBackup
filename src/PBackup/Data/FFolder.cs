using PBackup.LongFilenames;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBackup.Data
{
    public class FFolder
    {
        public class FolderEventArgs
        {
            public string Path { get; set; }
            public bool Success { get; set; }
            public bool Cancelled { get; set; }
            public string ErrorMessage { get; set; }
            public FolderEventArgs() { Path = string.Empty; Success = false; Cancelled = false; ErrorMessage = string.Empty; }
        }
        public delegate void FolderBackupStartedHandler(object sender, FolderEventArgs e);
        public delegate void FolderBackupFinishedHandler(object sender, FolderEventArgs e);

        public FolderBackupStartedHandler FolderBackupStarted;
        public FolderBackupFinishedHandler FolderBackupFinished;
        public FFile.FileBackupStartedHandler FileBackupStarted;
        public FFile.FileBackupFinishedHandler FileBackupFinished;

        public string Path { get; set; }
        public BackgroundWorker BackgroundWorker { get; set; }

        public FFolder(string path)
        {
            Path = path;
            BackgroundWorker = null;
            Excludes = null;
        }

        public ExcludePath[] Excludes { get; set; }

        public bool Exists { get { return LongDirectory.Exists(Path); } }

        public bool ExcludePath(string path)
        {
            if (Excludes != null)
            {
                if (Excludes.FirstOrDefault(e =>
                    (!e.Path.Contains("*") && path.Equals(e.Path, StringComparison.CurrentCultureIgnoreCase)) ||
                    (e.Path.StartsWith("*") && e.Path.EndsWith("*") && path.IndexOf(e.Path.Replace("*", ""), StringComparison.CurrentCultureIgnoreCase) >= 0) ||
                    (e.Path.StartsWith("*") && path.EndsWith(e.Path.Replace("*", ""), StringComparison.CurrentCultureIgnoreCase)) ||
                    (e.Path.EndsWith("*") && path.StartsWith(e.Path.Replace("*", ""), StringComparison.CurrentCultureIgnoreCase))
                    ) != null)
                    return true;
            }
            return false;
        }

        public void Backup()
        {
            if (FolderBackupStarted != null) FolderBackupStarted(this, new FolderEventArgs() { Path = Path });

            try
            {
                if (Excludes == null) Excludes = MainDbContext.DB.ExcludePaths.ToArray();

                foreach (string filename in LongDirectory.GetFiles(Path).OrderBy(f => f))
                {
                    if (ExcludePath(filename)) continue;
                    FFile ffile = new FFile(filename);
                    ffile.Excludes = Excludes;
                    ffile.FileBackupStarted += FileBackupStarted;
                    ffile.FileBackupFinished += FileBackupFinished;

                    ffile.Backup();

                    if (BackgroundWorker != null && BackgroundWorker.CancellationPending) return;
                }

                foreach (string folder in LongDirectory.GetDirectories(Path).OrderBy(f => f))
                {
                    if (ExcludePath(folder)) continue;

                    FFolder ffolder = new FFolder(folder);
                    ffolder.Excludes = Excludes;
                    ffolder.BackgroundWorker = BackgroundWorker;
                    ffolder.FolderBackupStarted += new FolderBackupStartedHandler(FolderBackupStarted);
                    ffolder.FolderBackupFinished += new FFolder.FolderBackupFinishedHandler(FolderBackupFinished);
                    ffolder.FileBackupStarted += new FFile.FileBackupStartedHandler(FileBackupStarted);
                    ffolder.FileBackupFinished += new FFile.FileBackupFinishedHandler(FileBackupFinished);
                    ffolder.Backup();
                    if (BackgroundWorker != null && BackgroundWorker.CancellationPending) return;
                }
            }
            catch (Exception ex)
            {

            }

            if (FolderBackupFinished != null) FolderBackupFinished(this, new FolderEventArgs() { Path = Path, Success = true });
        }

    }
}
