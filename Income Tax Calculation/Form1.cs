
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Income_Tax_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            decimal Gross;
            decimal Net;
            decimal Deduction;
            decimal Exemption;
            decimal Tax;

            Gross = decimal.Parse(GrosstextBox.Text);
            Deduction = decimal.Parse(DeductiontextBox.Text);
            Exemption = decimal.Parse(OthertextBox.Text);

            
            Net = Gross - Deduction - Exemption;
            Tax = Net * 0.15m;

            Grosslabel.Text = (Gross.ToString("C"));
            NetIncomelabel.Text = (Net.ToString("C"));
            Taxlabel.Text = (Tax.ToString("C"));
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            GrosstextBox.Text = " ";
            DeductiontextBox.Text = " ";
            OthertextBox.Text = " ";
            Grosslabel.Text = " ";
            NetIncomelabel.Text = " ";
            Taxlabel.Text = " ";
        }
    }
}
