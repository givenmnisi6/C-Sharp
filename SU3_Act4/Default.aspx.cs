using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SU3_Act4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar.SelectedDate = DateTime.Today.Date;
        }
        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            if (Calendar.SelectedDate < DateTime.Today.Date)
            {
                DisplayLabel.Visible = true;
                DisplayLabel.Text = "Please select an upcoming date - in the future";
            }
            else
            {
                DateTime theDate = Calendar.SelectedDate;
                OutputListBox.Items.Add(InputTextBox.Text + " - " + theDate.ToString("ddddd, yyyy/MM/dd"));
            }
        }
    }
}