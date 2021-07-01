using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SU3_Act3
{

    public partial class Default : System.Web.UI.Page
    {
        string time;
        string ticket;

        protected void Page_Load(object sender, EventArgs e)
        {
            InputTextBox.Focus();
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            /*if buttton 1 is clicked, it becomes disabled hence it is false
             so in line 63 when the disabled button is clicked it its gonna be unclicable showing,
             it is clicked and the label will display the number on the clicked button  
              

            So button 14 and 17 will be enabled but as in line 63 they will not show as an output,
            because they are set as true and line 63  will show the false option only

             this applies for all of the other buttons
            */
            Button11.Enabled = false;
            Button14.Enabled = true;
            Button17.Enabled = true;
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Button14.Enabled = false;
            Button11.Enabled = true;
            Button17.Enabled = true;
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            Button17.Enabled = false;
            Button11.Enabled = true;
            Button14.Enabled = true;
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void BookButton_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                ticket = "1";
            }
            else if (RadioButton2.Checked)
            {
                ticket = "2";
            }
            else
            {
                ticket = "3";
            }

            if (Button11.Enabled == false)
            {
                time = "11:00";
            }
            else if (Button14.Enabled == false)
            {
                time = "14:00";
            }
            else if (Button17.Enabled == false)
            {
                time = "17:00";
            }

            DisplayLabel.Text = InputTextBox.Text + " you have successfully booked the show for " + ticket + " people at " + time;
        }
    }
}