
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_Increase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            //CONSTANT
            const decimal INCREASE = 1.05m;

            //VARIABLES
            decimal compensation;
            int count = 1;
            int compensane;

            //MY CODE
            //INCASE THE USER ENTERS INVALID AMOUNTS
            if (decimal.TryParse(InputtextBox.Text, out compensation))
            {
                {
                    compensane = int.Parse(InputtextBox.Text);
                    OutputlistBox.Items.Add("Year\t\n" + "Pay\n");
                    OutputlistBox.Items.Add("1\t" + compensane.ToString ("c"));
                    while (count < 5)
                    {
                        compensation = (compensation * INCREASE);
                        count++;

                        OutputlistBox.Items.Add(count + "\t"+ compensation.ToString(("C")));                  
                    }
                }
            }
            else
            {
                //IF THE USER PROMPT AN INVALID AMOUNT
                MessageBox.Show("You've entered an invalid amount!");
            }

        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
