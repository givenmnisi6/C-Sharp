
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SU2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void BMIbutton_Click(object sender, EventArgs e)
        {
            try
            {

                double Weight;      //IN KILOGRAMS
                double Height;      //IN METRES
                double BMI;

                Weight = double.Parse(WeighttextBox.Text);
                Height = double.Parse(HeighttextBox.Text);

                BMI = Weight / (Math.Pow(Height, 2));

                Outputlabel.Text = "Your BMI is " + Math.Round(BMI, 2).ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            try
            {
                WeighttextBox.Text = " ";
                HeighttextBox.Text = " ";
                Outputlabel.Text = " ";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
