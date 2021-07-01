
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colour_Mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mixbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FRedradioButton.Checked && SBlueradioButton.Checked)
                {
                    this.BackColor = Color.Purple;
                }

                if (FRedradioButton.Checked && SYellowradioButton.Checked)
                {
                    this.BackColor = Color.Orange;
                }

                if (FBlueradioButton.Checked && SYellowradioButton.Checked)
                {
                    this.BackColor = Color.Green;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
