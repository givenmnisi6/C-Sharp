using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SU3_Act1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Nametxt.Focus();
        }
        protected void AddButton_Click(object sender, EventArgs e)
        {
            ListBox.Items.Add(Itemstxt.Text);
            Nametxt.Text = " ";
            Itemstxt.Text = " ";
        }

        protected void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Item = ListBox.SelectedItem.Text;
            ListBox.Items.Remove(ListBox.SelectedValue);
            MessageLabel.Text = Nametxt.Text + ", " + Item + " removed from the list!";
            
        }
    }
}