using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SU3_Act2
{
    public partial class Default : System.Web.UI.Page
    {
        
        double Price;
        double Amount;
        double Excluding;
        const double TAX = 0.15;
        double Including;
        double Total;

        protected void Page_Load(object sender, EventArgs e)
        {
            Firstttxt.Focus();
        }
        protected void Placebtn_Click(object sender, EventArgs e)
        {

            {
                if (DropDownList.SelectedItem.Value == "Rainbow")
                {
                    Price = 45.50;
                }
                else
                {
                    Price = 30;
                }

                Amount = double.Parse(Amounttxt.Text);

                Excluding = Amount * Price;
                Including = Excluding * TAX;
                Total = Excluding + Including;

                Resultlbl.Text = "Selections made for " + Firstttxt.Text + " " + Lasttxt.Text + " ---- " + "Colour:" + DropDownList.SelectedItem.Text + " - " + "(Amount) " + Amounttxt.Text;
                Amountlbl.Text = "Total cost, excluding tax = " + " " + Excluding.ToString("c");
                Taxlbl.Text = "Total amount of tax = " + Including.ToString("c");
                Totallb.Text = "Total tax, including tax = " + Total.ToString("c");
            }
        }
    }
}