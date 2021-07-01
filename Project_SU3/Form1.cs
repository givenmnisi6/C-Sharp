

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SU3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Orderbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string meal;

                if  (meallistBox.SelectedIndex != -1)
                {
                    meal = meallistBox.SelectedItem.ToString();

                    switch(meal)
                    {
                        case "Coffee With Cookies":
                            Outputlabel.Text = "You've ordered Coffee With Cookies, Your order will be processed shortly.";
                            MessageBox.Show("Thank You For Ordering At CC Restaurant");
                            break;

                        case "Coffee With Fish And Chips":
                            Outputlabel.Text = "You've ordered Coffee With Fish And Chips, Your order will be processed shortly.";
                            MessageBox.Show("Thank You For Ordering At CC Restaurant");
                            break;

                        case "Cooldrink With Cookies":
                            Outputlabel.Text = "You've ordered Cooldrink With Cookies, Your order will be processed shortly.";
                            MessageBox.Show("Thank You For Ordering At CC Restaurant");
                            break;

                        case "Cooldrink With Fish And Chips":
                            Outputlabel.Text = "You've ordered Coffee With Fish And Chips, Your order will be processed shortly.";
                            MessageBox.Show("Thank You For Ordering At CC Restaurant");
                            break;

                        default:
                            MessageBox.Show("The Menu You've Selected Does Not Exist");
                            break;
                    }
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
