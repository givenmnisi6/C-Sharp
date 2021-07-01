
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heads_or_Tails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showheadbutton_Click(object sender, EventArgs e)
        {
            //Boonlean Property
            headspictureBox.Visible = true;     //Show Heads picture
            tailspictureBox.Visible = false;    //Dont Show tails on the heads picture box
        }

        private void showtailsbutton_Click(object sender, EventArgs e)
        {
            headspictureBox.Visible = false;    //Dont show heads on the tails picture box
            tailspictureBox.Visible = true;     //Show tails
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
