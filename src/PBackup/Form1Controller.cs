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
        public void InitController()
        {
        }

        public void RefreshFromDB()
        {
            if (MainDbContext.DB.IncludePaths.Count() == 0)
            {
                MainDbContext.DB.IncludePaths.Add(new IncludePath { Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) });
                MainDbContext.DB.IncludePaths.Add(new IncludePath { Path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) });
                MainDbContext.DB.SaveChanges();
            }

            lstIncludes.Items.Clear();
            foreach (IncludePath i in MainDbContext.DB.IncludePaths.OrderBy(i => i.Path.ToLower()))
            {
                lstIncludes.Items.Add(i);
            }

            lstExcludes.Items.Clear();
            foreach (ExcludePath e in MainDbContext.DB.ExcludePaths.OrderBy(e => e.Path.ToLower()))
            {
                lstExcludes.Items.Add(e);
            }


            Configuration conf = MainDbContext.DB.Configurations.FirstOrDefault(c => c.Name == "destination");
            if (conf == null)
            {
                conf = new Configuration { Name = "destination", Value = LongFile.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PBackup") };
                MainDbContext.DB.Configurations.Add(conf);
                MainDbContext.DB.SaveChanges();
            }
            txtDestination.Text = conf.Value;
        }

        public void ChangeDestination()
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.Description = "Please select the new location for the backup";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Configuration conf = MainDbContext.DB.Configurations.FirstOrDefault(c => c.Name == "destination");
                if (conf == null)
                {
                    conf = new Configuration { Name = "destination", Value = f.SelectedPath };
                    MainDbContext.DB.Configurations.Add(conf);
                    MainDbContext.DB.SaveChanges();
                }
                else
                {
                    conf.Value = f.SelectedPath;
                    MainDbContext.DB.SaveChanges();
                }
                BackupDbContext.Reset();
                txtDestination.Text = conf.Value;
            }
        }

    }
}
