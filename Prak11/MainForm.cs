
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void Displaybutton_Click(object sender, EventArgs e)
        {
            //INSTANCE OF MY SECOND FORM
            OutputForm Output = new OutputForm();

            //VARIABLES
            //DORMITORIES
            double Allan = 1500;
            double Pike = 1600;
            double Farthing = 1800;
            double University = 2500;

            //MEALS
            double Seven = 600;
            double Fourteen = 1200;
            double Unlimited = 1700;

            try
            {    
                //ALLAN HALL
                if (DormitorylistBox.SelectedIndex == 0 && MealPlanlistBox.SelectedIndex == 0)
                {
                    Output.OutputLabel.Text = "Dormitory: " + Allan.ToString("c") + " per semester" + 
                    "\n" + "Meal Plan: " + Seven.ToString("c") + " per Semester" + 
                    "\n" + "Total: " + (Allan + Seven).ToString("c");
                }
                else if (DormitorylistBox.SelectedIndex == 0 && MealPlanlistBox.SelectedIndex == 1)
                {
                    Output.OutputLabel.Text = "Dormitory: " + Allan.ToString("c") + " per semester" + 
                    "\n" + "Meal Plan: " + Fourteen.ToString("c") + " per Semester" + 
                    "\n" + "Total: " + (Allan + Fourteen).ToString("c");
                }
                else if (DormitorylistBox.SelectedIndex == 0 && MealPlanlistBox.SelectedIndex == 2)
                {
                    Output.OutputLabel.Text = "Dormitory: " + Allan.ToString("c") + " per semester" + 
                    "\n" + "Meal Plan: " + Unlimited.ToString("c") + " per Semester" + 
                    "\n" + "Total: " + (Allan + Unlimited).ToString("c");
                }

                //PIKE HALL
                else if (DormitorylistBox.SelectedIndex == 1 && MealPlanlistBox.SelectedIndex == 0)
                {
                    Output.OutputLabel.Text = "Dormitory: " + Pike.ToString("c") + " per semester" + 
                    "\n" + "Meal Plan: " + Seven.ToString("c") + " per Semester" +
                    "\n" + "Total: " + (Pike + Seven).ToString("c");
                }
                else if (DormitorylistBox.SelectedIndex == 1 && MealPlanlistBox.SelectedIndex == 1)
                {
                    Output.OutputLabel.Text = "Dormitory: " + Pike.ToString("c") + " per semester" + 
                    "\n" + "Meal Plan: " + Fourteen.ToString("c") + " per Semester" + 
                    "\n" + "Total: " + (Pike + Fourteen).ToString("c");
                }
                else if (DormitorylistBox.SelectedIndex == 1 && MealPlanlistBox.SelectedIndex == 2)
                {
                    Output.OutputLabel.Text = "Dormitory: " + Pike.ToString("c") + " per semester" + 
                    "\n" + "Meal Plan: " + Unlimited.ToString("c") + " per Semester" + 
                    "\n" + "Total: " + (Pike + Unlimited).ToString("c");
                }

                //FARTHING HALL
                else if (DormitorylistBox.SelectedIndex == 2 && MealPlanlistBox.SelectedIndex == 0)
                {
                    Output.OutputLabel.Text = "Dormitory: " + Farthing.ToString("c") + " per semester" + 
                        "\n" + "Meal Plan: " + Seven.ToString("c") + " per Semester" + 
                        "\n" + "Total: " + (Farthing + Seven).ToString("c");
                }
                else if (DormitorylistBox.SelectedIndex == 2 && MealPlanlistBox.SelectedIndex == 1)
                {
                    Output.OutputLabel.Text = "Dormitory: " + Farthing.ToString("c") + " per semester" + 
                        "\n" + "Meal Plan: " + Fourteen.ToString("c") + " per Semester" + 
                        "\n" + "Total: " + (Farthing + Fourteen).ToString("c");
                }
                else if (DormitorylistBox.SelectedIndex == 2 && MealPlanlistBox.SelectedIndex == 2)
                {
                    Output.OutputLabel.Text = "Dormitory: " + Farthing.ToString("c") + " per semester" + 
                    "\n" + "Meal Plan: " + Unlimited.ToString("c") + " per Semester" + 
                    "\n" + "Total: " + (Farthing + Unlimited).ToString("c");
                }

                //UNIVERSITY SUITES
                else if (DormitorylistBox.SelectedIndex == 3 && MealPlanlistBox.SelectedIndex == 0)
                {
                    Output.OutputLabel.Text = "Dormitory: " + University.ToString("c") + " per semester" + 
                   "\n" + "Meal Plan: " + Seven.ToString("c") + " per Semester" + 
                   "\n" + "Total: " + ((University + Seven).ToString("c"));
                }
                else if (DormitorylistBox.SelectedIndex == 3 && MealPlanlistBox.SelectedIndex == 1)
                {
                    Output.OutputLabel.Text = "Dormitory: " + University.ToString("c") + " per semester" + 
                    "\n" + "Meal Plan: " + Fourteen.ToString("c") + " per Semester" + 
                    "\n" + "Total: " + (University + Fourteen).ToString("c");
                }
                else if (DormitorylistBox.SelectedIndex == 3 && MealPlanlistBox.SelectedIndex == 2)
                {
                    Output.OutputLabel.Text = "Dormitory: " + University.ToString("c") + " per semester" + 
                    "\n" + "Meal Plan: " + Unlimited.ToString("c") + " per Semester" + 
                    "\n" + "Total: " + (University + Unlimited).ToString("c");
                }
                Output.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
