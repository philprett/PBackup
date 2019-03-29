using PBackup.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBackup
{
    public partial class FormBackupBrowser : Form
    {
        private BackupFileType currentBackupFileType;

        private void RefreshFromDB()
        {
            txtPath.Text = currentFolder;
            List<BackupBrowserGridItem> gridItems = new List<BackupBrowserGridItem>();
            currentBackupFileType = BackupFileType.Unknown;
            if (string.IsNullOrWhiteSpace(currentFolder))
            {
                gridItems.Add(new BackupBrowserGridItem() { Name = "Files", LastModified = "", Size = "", Versions = "", BackupFile = null });
                gridItems.Add(new BackupBrowserGridItem() { Name = "MSSQL", LastModified = "", Size = "", Versions = "", BackupFile = null });
            }
            else
            {
                string pathFileType;
                string pathRest;
                if (!currentFolder.Contains("\\"))
                {
                    pathFileType = currentFolder;
                    pathRest = string.Empty;
                }
                else
                {
                    pathFileType = currentFolder.Substring(0, currentFolder.IndexOf("\\"));
                    pathRest = currentFolder.Substring(currentFolder.IndexOf("\\") + 1);
                }
                if (pathFileType == "Files")
                {
                    currentBackupFileType = BackupFileType.File;
                }
                else if (pathFileType == "MSSQL")
                {
                    currentBackupFileType = BackupFileType.MSSQL;
                }

                if (currentBackupFileType != BackupFileType.Unknown)
                {
                    List<string> includedPaths = new List<string>();
                    BackupFile[] files = string.IsNullOrWhiteSpace(pathRest) 
                        ? BackupDbContext.DB.BackupFiles.ToArray()
                        : BackupDbContext.DB.BackupFiles.Where(f => f.Path.StartsWith(pathRest)).ToArray();
                    foreach (BackupFile file in files.OrderBy(f => f.Path))
                    {
                        if (pathRest.Length > file.Path.Length) continue;
                        string thisPath = file.Path.Substring(pathRest.Length).TrimStart(new [] {'\\'});
                        if (thisPath.Contains("\\")) thisPath = thisPath.Substring(0, thisPath.IndexOf("\\"));
                        if (includedPaths.FirstOrDefault(p => p == thisPath) != null) continue;
                        includedPaths.Add(thisPath);

                        gridItems.Add(new BackupBrowserGridItem()
                        {
                            Name = thisPath,
                            LastModified = file.LastModified.ToShortDateString() + " " + file.LastModified.ToShortTimeString(),
                            Size = file.Size.ToString("#,####,####,###0"),
                            Versions = "",
                            BackupFile = null,
                        });
                    }
                }
            }

            Grid.Rows.Clear();
            if (gridItems.Count > 0)
            {

                foreach (BackupBrowserGridItem item in gridItems)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Tag = item.BackupFile;

                    DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                    cell1.Value = item.Name;
                    row.Cells.Add(cell1);

                    DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                    cell2.Value = item.LastModified;
                    row.Cells.Add(cell2);

                    DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                    cell3.Value = item.Size;
                    row.Cells.Add(cell3);

                    DataGridViewTextBoxCell cell4 = new DataGridViewTextBoxCell();
                    cell4.Value = item.Versions;
                    row.Cells.Add(cell4);

                    Grid.Rows.Add(row);
                }

            }

        }

        private void GridDoubleClick(int rowNo)
        {
            DataGridViewRow row = Grid.Rows[rowNo];
            BackupFile file = (BackupFile)row.Tag;
            if (!string.IsNullOrWhiteSpace(currentFolder)) currentFolder += "\\";
            currentFolder += (string)row.Cells[0].Value;
            RefreshFromDB();
        }

        private void GoUp()
        {
            if (string.IsNullOrWhiteSpace(currentFolder)) {
                currentFolder = string.Empty;
            } 
            else if (!currentFolder.Contains("\\"))
            {
                currentFolder = string.Empty;
            }
            else
            {
                currentFolder = currentFolder.Substring(0, currentFolder.LastIndexOf("\\"));
            }
            RefreshFromDB();
        }

    }
}
