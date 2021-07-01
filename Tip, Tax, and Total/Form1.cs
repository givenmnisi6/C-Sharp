
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip__Tax__and_Total
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            //Using decimal since its money, fractional parts
            //storing the variables
            decimal food;
            decimal tip;
            decimal tax;
            decimal total;

            food = decimal.Parse(FoodChargetextBox.Text);  //changing the food charge into a string 

            tip = food * 0.15M;
            tax = food * 0.07M;
            total = tip + tax + food;   //Total of the three amounts

            Totallabel.Text = (total.ToString("C"));    //the "C" introduces Currency
            Tiplabel.Text = (tip.ToString("C"));
            Taxlabel.Text = (tax.ToString("C"));
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {   
            //closing the form
            this.Close();
        }
    }
}
