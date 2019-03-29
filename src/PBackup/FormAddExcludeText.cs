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
    public partial class FormAddExcludeText : Form
    {
        public string Mask
        {
            get
            {
                return txtMask.Text;
            }
            set
            {
                txtMask.Text = value;
            }
        }

        public FormAddExcludeText()
        {
            InitializeComponent();
        }

        private void FormAddExcludeText_Load(object sender, EventArgs e)
        {
            txtMask.Focus();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
