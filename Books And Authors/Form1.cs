
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books_And_Authors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void book1button_Click(object sender, EventArgs e)
        {
            answerlabel.Text = "Margaret Mitchel";
        }

        private void book2button_Click(object sender, EventArgs e)
        {
            answerlabel.Text = "Alex Haley";
        }
        private void book3button_Click(object sender, EventArgs e)
        {
            answerlabel.Text = "Ayn Rand";
        }
    }
}
