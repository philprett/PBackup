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
    public partial class FormBackupBrowser : Form
    {
        private string destination;
        private string currentFolder;

        public FormBackupBrowser(string destination)
        {
            InitializeComponent();
            this.destination = destination;
            this.currentFolder = string.Empty;
        }

        private void FormBackupBrowser_Load(object sender, EventArgs e)
        {
            txtDestination.Text = destination;
            RefreshFromDB();
        }

        private void Grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            GridDoubleClick(e.RowIndex);
        }

        private void butUp_Click(object sender, EventArgs e)
        {
            GoUp();
        }
    }
}
