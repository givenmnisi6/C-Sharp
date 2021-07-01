
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
            //CONSTANTS
            const double HP = 1.002;
            const double LENOVO = 1.065;
            const double MACBOOK = 1.1875;


            //VARIABLES
            double deposit;
            double total = 0;

            if (double.TryParse(DeposittextBox.Text, out deposit))
            {
               try
                {
                    OutputlistBox.Items.Add("Months\t" + "Amount");
                    for (int i = 1; i <= 24; i++)
                    {
                        //DISPLAYING THE HP
                        if (HPradioButton.Checked)
                        {
                            total = (deposit * HP * 2)*i;
                            OutputlistBox.Items.Add(i + "\t" + total.ToString("C"));

                        }
                        //DISPLAYING THE LENOVO
                        else if (LENOVOradioButton.Checked)
                        {
                            total = (deposit * LENOVO * 2)*i;
                            OutputlistBox.Items.Add(i + "\t" + total.ToString("C"));
                        }
                        //DISPLAYING THE MAC BOOK
                        else
                        {
                            total = (deposit * MACBOOK * 2)*i;
                            OutputlistBox.Items.Add(i + "\t" + total.ToString("C"));
                        }
                    }
                    
                }
                catch(Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                     OutputlistBox.Items.Add(InitialstextBox.Text + "," + "You will be paying a total of " + total.ToString("C"));
            }
            else
            {
                MessageBox.Show("Enter a valid amount");
            }          
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            InitialstextBox.Text = "";
            DeposittextBox.Text = "";
            OutputlistBox.Items.Clear();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

