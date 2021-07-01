//GIVEN MNISI - 34292748
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SU3_Act7
{

    public partial class Default : System.Web.UI.Page
    {
        string time;
        string ticket;

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        protected void Button11_Click(object sender, EventArgs e)
        {
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

            Session["username"] = InputTextBox.Text;


            if (Session["username"].ToString() != "")
            {
                DisplayLabel.Text = Session["username"].ToString() + " you have successfully booked the show for " + ticket + " people at " + time;
            }
            else
            {
                DisplayLabel.Text = "No input to display";
            }
            
        }

 
    }
}