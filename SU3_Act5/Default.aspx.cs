//GIVEN MNISI - 34292748
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SU3_Act5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar.SelectedDate = DateTime.Today.Date;

        }

        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {

            DateTime theDate = Calendar.SelectedDate;
            int theDay;
            theDay = (int)theDate.DayOfWeek;

            if (theDay > 4)
            {
                DisplayLabel.Text = theDate.AddDays(+3).ToString("ddddd, dd MMMMM yyyy");
            }
            else if (theDate.DayOfWeek.ToString() == "Sunday")
            {
                DisplayLabel.Text = theDate.AddDays(+3).ToString("ddddd, dd MMMMM yyyy");
            }
            else  
            {
                DisplayLabel.Text = theDate.AddDays(+2).ToString("ddddd, dd MMMMM yyyy");
            }
            OutputLabel.Visible = true;
            DisplayLabel.Visible = true;
        }
    }
}