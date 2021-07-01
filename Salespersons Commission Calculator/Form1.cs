
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salesperson_s_Commission_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            CalculateDisplayCommission(int.Parse(RevenuetextBox.Text), double.Parse(PercentagetextBox.Text));                   
        }

        private void CalculateDisplayCommission(int revenue, double percentage)
        {
            double earned = revenue * (percentage/100);
            Outputlabel.Text = earned.ToString("c");
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
