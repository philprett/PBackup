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
        public FormBackupBrowser(string destination)
        {
            InitializeComponent();
            this.destination = destination;
        }

        private void FormBackupBrowser_Load(object sender, EventArgs e)
        {
            txtDestination.Text = destination;
        }
    }
}
