using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SU3_Act8
{
    public partial class WebAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Calendar1.SelectedDate = DateTime.Parse(Session["Date"].ToString());

            HttpCookie theCookie = Request.Cookies["UserInfo"];

            if (theCookie != null && Session["Universities"].ToString() != "")
            {
                NameLabel.Text = "Welcome " + theCookie["Name and Surname"].ToString() + ", " + Session["Universities"].ToString() + " starts " + Session["Date"].ToString();
                EmailLabel.Text = "We will send you a reminder to: " + theCookie["Email"].ToString();

            }
            else
            {
                NameLabel.Text = "No input selected";
                EmailLabel.Text = "No input selected";
            }
        }
    }
}