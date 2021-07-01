//GIVEN MNISI - 34292748



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prak11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutputForm result = new OutputForm();
            double Rocco = 150;
            double Mugg = 120;
            double Mac = 60;

            //MEALS
            double Fish = 250, Burger = 200, Breakfast = 120;
            try
            {
                //ROCCO MAMAS
                if (RoccoradioButton.Checked  && FishradioButton.Checked)
                {
                    result.OutputLabel.Text = "Restaurant: " + Rocco.ToString("c") + "\n" + "Meal : " + Fish.ToString("c") + "\n\r" + "Total: " + (Rocco + Fish).ToString("C") +
                        "\n" + "Thank You For Ordering At Rocco Mamas" + " Your total for the night is " + (Rocco + Fish).ToString("C");

                }
                else if (RoccoradioButton.Checked && BurgerradioButton.Checked)
                {
                    result.OutputLabel.Text = "Restaurant: " + Rocco.ToString("c") + "\n" + "Meal : "  + Burger.ToString("c") + "\n\r" + "Total: " + (Rocco + Burger).ToString("C") +
                        "\n" + "Thank You For Ordering At Rocco Mamas" + " Your total for the night is " + (Rocco + Burger).ToString("C");
                }
                else if (RoccoradioButton.Checked  && BreakfastradioButton.Checked)
                {
                    result.OutputLabel.Text = "Restaurant: " + Rocco.ToString("c") + "\n" + "Meal : " + Breakfast.ToString("c") + "\n\r" + "Total: " + (Rocco + Breakfast).ToString("C") +
                        "\n" + "Thank You For Ordering At Rocco Mamas" + " Your total for the night is " + (Rocco + Breakfast).ToString("C");
                }

                //MUGG & BEAN
                else if (MuggradioButton.Checked && FishradioButton.Checked)
                {
                    result.OutputLabel.Text = "Restaurant: " + Mugg.ToString("c") + "\n" + "Meal : " + Fish.ToString("c") + "\n\r" + "Total: " + (Mugg + Fish).ToString("C") +
                    "\n" + "Thank You For Ordering At Mugg && Bean" + " Your total for the is " + (Mugg + Fish).ToString("C");
                }
                else if (MuggradioButton.Checked && BurgerradioButton.Checked)
                {
                    result.OutputLabel.Text = "Restaurant: " + Mugg.ToString("c") + "\n" + "Meal : " + Burger.ToString("c") + "\n" + "Total: " + (Mugg + Burger).ToString("C") +
                         "\n" + "Thank You For Ordering At Mugg && Bean" + " Your total for the night is " + (Mugg + Burger).ToString("C");

                }
                else if (MuggradioButton.Checked && BreakfastradioButton.Checked)
                {
                    result.OutputLabel.Text = "Restaurant: " + Mugg.ToString("c") + "\n" + "Meal : " + Breakfast.ToString("c") + "\n\r" + "Total: " + (Mugg + Breakfast).ToString("C")
                        + "\n" + "Thank You For Ordering At Mugg && Bean" + " Your total for the night is " + (Mugg + Breakfast).ToString("C");
                }


                //MACDONALDS
                else if (MacDradioButton.Checked && FishradioButton.Checked)
                {
                    result.OutputLabel.Text = "Restaurant: " + Mac.ToString("c") + "\n" + "Meal : " + Fish.ToString("c") + "\n\r" + "Total: " + (Mac + Fish).ToString("C") +
                         "\n" + "Thank You For Ordering At MacDonalds" + " Your total for the night is " + (Mac + Fish).ToString("C");
                }
                else if (MacDradioButton.Checked && BurgerradioButton.Checked)
                {
                    result.OutputLabel.Text = "Restaurant: " + Mac.ToString("c") + "\n" + "Meal : " + Burger.ToString("c") + "\n\r" + "Total: " + (Mac + Burger).ToString("C") +
                        "\n" + "Thank You For Ordering At MacDonalds" + " Your total for the night is " + (Mac + Burger).ToString("C");
                }
                else if (MacDradioButton.Checked && BreakfastradioButton.Checked)
                {
                    result.OutputLabel.Text = "Restaurant: " + Mac.ToString("c") + "\n" + "Meal : " + Breakfast.ToString("c") +  "\n\r" + "Total: " + (Mac + Breakfast).ToString("C") +
                        "\n" + "Thank You For Ordering At MacDonalds" + " Your total for the night is " + (Mac + Breakfast).ToString("C");
                }                
                result.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Please Select Another Meal");
            }
        }
    }
}
