
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Paint_Job_Estimator
{
    public partial class Form1 : Form
    {
        //CONSTANT FIELDS
        const double CHARGES = 20.00;
        const double SQUAREFEET = 115;
        const double HOURS = 8;

        public Form1()
        {
            InitializeComponent();
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                double gallon;
                double squarefeet;
                double gallon_needed;
                double labour_needed;
                double paint_cost;
                double labour_charge;
                double total_cost;


                squarefeet = double.Parse(SquarefeettextBox.Text);
                gallon = double.Parse(GallontextBox.Text);

                //CALCULATIONS 
                gallon_needed =  (squarefeet / SQUAREFEET);
                labour_needed = (squarefeet * HOURS) / SQUAREFEET;
                paint_cost = (squarefeet * gallon) / SQUAREFEET;
                labour_charge = (labour_needed * CHARGES);
                total_cost = (labour_charge + paint_cost);

                //MATH.ROUND IS ROUNDING IT TO THE NEAREST 2

                Outputlabel.Text = " The number of gallons of paint required is : " + Math.Round(gallon_needed,2).ToString() +
                                  "\n The hour of labour required: " + Math.Round(labour_needed, 2).ToString() +
                                  "\n The cost of paint: " + "R" + Math.Round(paint_cost,2).ToString() +
                                  "\n The labor charges: " + "R" + Math.Round(labour_charge, 2).ToString() +
                                  "\n The total cost of the paint job: " + "R" + Math.Round(total_cost, 2).ToString();
                           

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}  
    
