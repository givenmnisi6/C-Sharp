
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
            int i = 0;

            try
            {
                if (decimal.TryParse(LoantextBox.Text, out loan))
                {
                    if (int.TryParse(MonthstextBox.Text, out months))
                    {
                        while (i < months)
                        {
                            loan = Math.Round(loan * (1 + INTEREST * months), 2);
                            i++;
                        }

                        MessageBox.Show("AT THE END OF " + months + " MONTHS" + "," + "YOU WILL PAY " + "R " + loan
                                         + "\n" + "WE HOPE WE'LL SEE A NOTIFICATION COMING FROM YOU IN " + months +
                                         " MONTHS " + "TIME\n" + "THANK YOU");
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
