using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SU2_Act_3
{
    public partial class frmDVDNew : Form
    {
        public frmDVDNew()
        {
            InitializeComponent();
        }
        private void listDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewData FormData = new viewData();
            FormData.MdiParent = this; 
            FormData.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
