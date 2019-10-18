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

			txtDestination.Text = Configuration.Set("destination", LongFile.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PBackup")).Value;
			txtDestination2.Text = Configuration.Set("destination2", string.Empty).Value;

			chkRunEvery.Checked = Configuration.Set("runeveryenabled", "1").Value == "1";
			txtRunEvery.Text = Configuration.Set("runeveryinterval", string.Empty).Value;

			Configuration runEveryUnit = MainDbContext.DB.Configurations.FirstOrDefault(c => c.Name == "runeveryunit");
			if (runEveryUnit == null)
			{
				runEveryUnit = new Configuration { Name = "runeveryunit", Value = "H" };
				MainDbContext.DB.Configurations.Add(runEveryUnit);
				MainDbContext.DB.SaveChanges();
			}
			if (runEveryUnit.Value == "M") radRunEveryMinutes.Checked = true;
			if (runEveryUnit.Value == "H") radRunEveryHours.Checked = true;
			if (runEveryUnit.Value == "D") radRunEveryDays.Checked = true;
		}

		public void ChangeDestination(TextBox destinationTextBox)
		{
			FolderBrowserDialog f = new FolderBrowserDialog();
			f.SelectedPath = destinationTextBox.Text;
			f.Description = "Please select the new location for the backup";
			if (f.ShowDialog() == DialogResult.OK)
			{
				string confName = destinationTextBox.Name == "butDestinationBrowse" ? "destination" : "destination2";
				Configuration conf = MainDbContext.DB.Configurations.FirstOrDefault(c => c.Name == confName);
				if (conf == null)
				{
					conf = new Configuration { Name = confName, Value = f.SelectedPath };
					MainDbContext.DB.Configurations.Add(conf);
					MainDbContext.DB.SaveChanges();
				}
				else
				{
					conf.Value = f.SelectedPath;
					MainDbContext.DB.SaveChanges();
				}
				BackupDbContext.Reset();
				destinationTextBox.Text = conf.Value;
			}
		}

	}
}
