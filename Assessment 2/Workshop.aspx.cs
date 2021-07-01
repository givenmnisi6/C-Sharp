using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assessment_2
{
    public partial class Workshop : System.Web.UI.Page
    {
        public SqlConnection Connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GIVEN MNISI\Downloads\IT\CMPG212\Assessment 2\App_Data\ClientData.mdf;Integrated Security = True");
        public SqlCommand Command;
        public DataSet DS;
        public SqlDataAdapter DataAdapter;

        protected void Page_Load(object sender, EventArgs e)
        {
            InsertToGridView();
        }

        private void InsertToGridView()
        {
            HttpCookie theCookie = Request.Cookies["Credentials"];

            if (theCookie != null)
            {
                Usernamelbl.Text = theCookie["Username"];
            }

            //FORMAT - changing the date format
            string sql = ("SELECT Username AS 'Name', FORMAT (WorkshopDate, 'dd MMMM yyyy') AS 'Date', CASE Java WHEN 1 THEN 'True' WHEN 0 THEN 'False' END AS Java, CASE CSharp WHEN 1 THEN 'True' WHEN 0 THEN 'False' END AS 'C#', CASE CPP WHEN 1 THEN 'True' WHEN 0 THEN 'False' END AS 'C++' FROM ClientData WHERE Username LIKE '%" + theCookie["Username"] + "%' AND Password LIKE '%" + theCookie["Password"] + "%' ");

            Connection.Open();

            DS = new DataSet();
            DataAdapter = new SqlDataAdapter();
            Command = new SqlCommand(sql, Connection);

            DataAdapter.SelectCommand = Command;
            DataAdapter.Fill(DS);

            GridView.DataSource = DS;
            GridView.DataBind();

            Connection.Close();
        }

        private void Radiobuttons()
        {
            HttpCookie theCookie = Request.Cookies["Credentials"];

            Connection.Open();

            if (RadioButtonList.SelectedIndex == 0)
            {
                String sql = ("UPDATE ClientData SET WorkshopDate = '" + Calendar1.SelectedDate + "', Java = 1 , CSharp = 0, CPP = 0 WHERE Username LIKE '%" + theCookie["Username"] + "%' AND Password LIKE '%" + theCookie["Password"] + "%' ");
                Command = new SqlCommand(sql, Connection);
                Command.ExecuteNonQuery();
            }

            else if (RadioButtonList.SelectedIndex == 1)
            {
                String sql = ("UPDATE ClientData SET WorkshopDate = '" + Calendar1.SelectedDate + "', Java = 0 , CSharp = 1, CPP = 0 WHERE Username LIKE '%" + theCookie["Username"] + "%' AND Password LIKE '%" + theCookie["Password"] + "%' ");
                Command = new SqlCommand(sql, Connection);
                Command.ExecuteNonQuery();
            }

            else if (RadioButtonList.SelectedIndex == 2)
            {
                String sql = ("UPDATE ClientData SET WorkshopDate = '" + Calendar1.SelectedDate + "', Java = 0 , CSharp = 0, CPP = 1 WHERE Username LIKE '%" + theCookie["Username"] + "%' AND Password LIKE '%" + theCookie["Password"] + "%' ");
                Command = new SqlCommand(sql, Connection);
                Command.ExecuteNonQuery();
            }
            Connection.Close();
        }

        protected void Confirmbtn_Click(object sender, EventArgs e)
        {
            Radiobuttons();
            InsertToGridView();
        }
    }
}