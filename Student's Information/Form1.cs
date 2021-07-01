
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_s_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Studentbutton_Click(object sender, EventArgs e)
        {
            string output;

            output = SNtextBox.Text + ", " + AgetextBox.Text + " years" + ", standard " + StandardtextBox.Text
                + ", " + "from " + SchooltextBox.Text;

            Outputlabel.Text = output;
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            SNtextBox.Text = " ";
            StandardtextBox.Text = " ";
            AgetextBox.Text = " ";
            StandardtextBox.Text = " ";
            SchooltextBox.Text = " ";
            Outputlabel.Text = " ";
        }

        private void SNbutton_Click(object sender, EventArgs e)
        {
            string SN;

            SN = SNtextBox.Text;
            Outputlabel.Text = SN;
        }

        private void Agebutton_Click(object sender, EventArgs e)
        {
            string Age;
            Age = SNtextBox.Text + " is " + AgetextBox.Text + " years old";
            Outputlabel.Text = Age;
        }

        private void Standardbutton_Click(object sender, EventArgs e)
        {
            string Standard;
            Standard = SNtextBox.Text + " is in standard " + StandardtextBox.Text;
            Outputlabel.Text = Standard;
        }

        private void Schoolbutton_Click(object sender, EventArgs e)
        {
            string School;
            School = SNtextBox.Text + " goes to " + SchooltextBox.Text;
            Outputlabel.Text = School;
        }

        private void SASbutton_Click(object sender, EventArgs e)
        {
            // SAS represents Student's name, Age and Standard
            String SAS;
            SAS = SNtextBox.Text + ", " + AgetextBox.Text + " years, " + "standard " +
                StandardtextBox.Text;
            Outputlabel.Text = SAS;
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
