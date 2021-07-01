
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories_Burned_through_exercise
{
    public partial class Calories : Form
    {
        public Calories()
        {
            InitializeComponent();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            //CONSTANTS
            const double CYCLING = 1.0;
            const double RUNNING = 1.2;
            const double ROWING = 1.5;


            //VARIABLES
            double weight;
            double calories;


            if(double.TryParse(InputtextBox.Text, out weight))
            {
               
                OutputlistBox.Items.Add("Minutes" + "\t" + "Calories Burnt");

                for (int i = 10; i <= 50; i += 10)
            {
                if(CyclingradioButton.Checked)
                {
                        calories = (weight * CYCLING *( i / 10));
                   
                        OutputlistBox.Items.Add(i.ToString() + "\t" + calories);                                           
                }

                    if (RunningradioButton.Checked)
                    {
                        calories = (weight * RUNNING * (i / 10));

                        OutputlistBox.Items.Add(i.ToString() + "\t" + calories.ToString());

                    }

                    if (RowingradioButton.Checked)
                    {
                        calories = (weight * ROWING * (i / 10));

                        OutputlistBox.Items.Add(i.ToString() + "\t" + calories.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Weight!");
            }
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
