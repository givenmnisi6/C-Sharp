using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SU3_Act8
{
    public partial class Default : System.Web.UI.Page
    {
        string date;
        protected void Page_Load(object sender, EventArgs e)
        {
            NameTextBox.Focus();
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            HttpCookie theCookie = new HttpCookie("UserInfo");
            theCookie["Name and Surname"] = NameTextBox.Text;
            theCookie["Email"] = EmailTextBox.Text;

            Response.Cookies.Add(theCookie);
            theCookie.Expires = DateTime.Now.AddDays(7);    //the cookie expires after 7 days

            Session["Universities"] = RadioButtonList.SelectedValue;

            if (RadioButtonList.SelectedIndex == 0)
            {
                date = "3 February 2021";
            }

            else if (RadioButtonList.SelectedIndex == 1)
            {
                date = "10 February 2021";
            }

            else if (RadioButtonList.SelectedIndex == 2)
            {
                date = "5 February 2021";
            }

            else if (RadioButtonList.SelectedIndex == 3)
            {
                date = "17 February 2021";
            }

            else if (RadioButtonList.SelectedIndex == 4)
            {
                date = "3 February 2021";
            }

            Session["Date"] = date;

            Response.Redirect("WebAdd.aspx");
        }


    }
}