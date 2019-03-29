using PBackup.Data;
using PBackup.LongFilenames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBackup
{
    public partial class Form1 : Form
    {
        public void IncludeAddFolder()
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.Description = "Please select the folder to include in the backup";
            if (f.ShowDialog() == DialogResult.OK)
            {
                MainDbContext.DB.IncludePaths.Add(new IncludePath { Path = f.SelectedPath });
                MainDbContext.DB.SaveChanges();
                RefreshFromDB();
            }
        }

        public void IncludeAddFile()
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Please select the folder to include in the backup";
            if (f.ShowDialog() == DialogResult.OK)
            {
                MainDbContext.DB.IncludePaths.Add(new IncludePath { Path = f.FileName });
                MainDbContext.DB.SaveChanges();
                RefreshFromDB();
            }
        }

        public void IncludeDelete()
        {
            if (lstIncludes.SelectedItem != null)
            {
                if (MessageBox.Show("Do you really want to remove this path from the backups?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    IncludePath sel = (IncludePath)lstIncludes.SelectedItem;
                    MainDbContext.DB.IncludePaths.Remove(sel);
                    MainDbContext.DB.SaveChanges();
                    RefreshFromDB();
                }
            }
        }

        public void ExcludeAddFolder()
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.Description = "Please select the folder to exclude in the backup";
            if (f.ShowDialog() == DialogResult.OK)
            {
                MainDbContext.DB.ExcludePaths.Add(new ExcludePath { Path = f.SelectedPath });
                MainDbContext.DB.SaveChanges();
                RefreshFromDB();
            }
        }

        public void ExcludeAddFile()
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Please select the folder to exclude in the backup";
            if (f.ShowDialog() == DialogResult.OK)
            {
                MainDbContext.DB.ExcludePaths.Add(new ExcludePath { Path = f.FileName });
                MainDbContext.DB.SaveChanges();
                RefreshFromDB();
            }
        }

        public void ExcludeAddMask()
        {
            FormAddExcludeText f = new FormAddExcludeText();
            if (f.ShowDialog() == DialogResult.OK)
            {
                MainDbContext.DB.ExcludePaths.Add(new ExcludePath { Path = f.Mask });
                MainDbContext.DB.SaveChanges();
                RefreshFromDB();
            }
        }

        public void ExcludeDelete()
        {
            if (lstExcludes.SelectedItem != null)
            {
                if (MessageBox.Show("Do you really want to remove this path from the excludes?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ExcludePath sel = (ExcludePath)lstExcludes.SelectedItem;
                    MainDbContext.DB.ExcludePaths.Remove(sel);
                    MainDbContext.DB.SaveChanges();
                    RefreshFromDB();
                }
            }
        }

    }
}
