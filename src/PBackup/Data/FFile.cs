using PBackup.LongFilenames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBackup.Data
{
    public class FFile
    {
        public class FileEventArgs
        {
            public string Path { get; set; }
            public bool BackupRequired { get; set; }
            public bool Success { get; set; }
            public bool Cancelled { get; set; }
            public string ErrorMessage { get; set; }
            public FileEventArgs() { Path = string.Empty; BackupRequired = false; Success = false; Cancelled = false; ErrorMessage = string.Empty; }
        }

        public delegate void FileBackupStartedHandler(FFile sender, FileEventArgs e);
        public delegate void FileBackupFinishedHandler(FFile sender, FileEventArgs e);

        public FileBackupStartedHandler FileBackupStarted;
        public FileBackupFinishedHandler FileBackupFinished;

        public string Path { get; set; }
        public ExcludePath[] Excludes { get; set; }

        public FFile(string path)
        {
            Path = path;
            Excludes = null;
        }

        private bool FileRequiresBackup(BackupFile backupFile)
        {
            if (backupFile.LastModified.CompareTo(LongFile.GetLastWriteTime(Path)) != 0) return true;
            if (backupFile.Size != LongFile.GetFileSize(Path)) return true;
            if (!LongFile.Exists(GetBackupLocation())) return true;
            return false;
        }

        private string GetBackupLocation()
        {
            string folder = LongFile.GetParent(Path).Replace(":", "");
            string filename = LongFile.GetNameWithoutExtension(Path);
            string fileLastModified = LongFile.GetLastWriteTime(Path).ToLocalTime().ToString("yyyyMMddhhmmss");
            string extension = LongFile.GetExtension(Path);

            return LongFile.Combine(
                folder,
                string.Format(
                    "{0}_{1}{2}",
                    filename,
                    fileLastModified,
                    extension));
        }


        public void Backup()
        {
            bool backupRequired = false;

            try
            {
                DateTime currentFileTimestamp = LongFile.GetLastWriteTime(Path).ToLocalTime();

                BackupFile backupFile = BackupDbContext.DB.BackupFiles
                    .Where(f => f.Path == Path)
                    .OrderByDescending(f => f.BackupTimestamp)
                    .FirstOrDefault(f => true);

                if (backupFile == null)
                {
                    backupRequired = true;
                }
                else if (backupFile.LastModified.CompareTo(currentFileTimestamp) != 0)
                {
                    backupRequired = true;
                }
                else if (backupFile.Size != LongFile.GetFileSize(Path))
                {
                    backupRequired = true;
                }

                if (backupRequired)
                {
                    backupFile = new BackupFile
                    {
                        Path = Path,
                        LastModified = currentFileTimestamp,
                        Size = LongFile.GetFileSize(Path),
                        BackupTimestamp = DateTime.Now,
                        BackupLocation = GetBackupLocation(),
                        Parent = LongFile.GetParent(Path),
                        Name = LongFile.GetName(Path),
                    };
                    string destPath = LongFile.Combine(BackupDbContext.Destination, LongFile.Combine("Files", backupFile.BackupLocation));
                    string destFolder = LongFile.GetParent(destPath);
                    if (!LongDirectory.Exists(destFolder)) LongDirectory.CreateDirectory(destFolder);
                    LongFile.Copy(Path, destPath, true);
                    LongFile.SetAttributes(destPath, LongFile.GetAttributes(destPath) & ~System.IO.FileAttributes.ReadOnly & ~System.IO.FileAttributes.Hidden);
                    BackupDbContext.DB.BackupFiles.Add(backupFile);
                    BackupDbContext.DB.SaveChanges();
                    if (FileBackupFinished != null) FileBackupFinished(this, new FileEventArgs() { Path = Path, Cancelled = false, Success = true });
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
