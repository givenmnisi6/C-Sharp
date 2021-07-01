
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SU4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            //MY CONSTANT
            const decimal INTEREST = 0.02m;

            //MY VARIABLES
            decimal loan;
            int months;
            int i = 1;

            try
            {
                if (decimal.TryParse(LoantextBox.Text, out loan))
                {
                    if (int.TryParse(MonthstextBox.Text, out months))
                    {
                        while (i <= months)
                        {                        
                            loan = Math.Round(loan * (1 + INTEREST * months), 2);
                            if (loan < 5000)
                            {
                                OutputlistBox.Items.Add("AT THE END OF " + i + " MONTHS" + "," + "YOU WILL PAY " + "R " + loan);
                            }
                            else
                                OutputlistBox.Items.Add("SORRY WE CANNOT GIVE YOU THAT KIND OF MONEY");
                            i++;
                        }                           
                    }
                    else
                    {
                        MessageBox.Show("ERROR, Enter valid months.");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, Enter a valid amount.");
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
