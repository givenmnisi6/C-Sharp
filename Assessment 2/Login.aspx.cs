using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assessment_2
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection Connection = new SqlConnection (@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GIVEN MNISI\Downloads\IT\CMPG212\Assessment 2\App_Data\ClientData.mdf;Integrated Security = True");
        SqlCommand Command;
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie theCookie = Request.Cookies["Credentials"];

            if (theCookie != null)
            {
                string databasePassword, databaseUsername;
                string Sql = "SELECT * FROM ClientData WHERE Username LIKE '%" + theCookie["Username"] + "%' AND Password LIKE '%" + theCookie["Password"] + "%' ";
                Command = new SqlCommand(Sql, Connection);

                Connection.Open();

                using (SqlDataReader DataReader = Command.ExecuteReader())
                {
                    if (DataReader.Read())
                    {
                        databaseUsername = DataReader[0].ToString();
                        databasePassword = DataReader[1].ToString();

                        if (databaseUsername == theCookie["Username"] && databasePassword == theCookie["Password"])
                        {
                            Response.Redirect("Workshop.aspx");
                        }
                    }
                }
                Connection.Close();
            }
            else
            {
                Usernametxt2.Focus();
            }
        }

        protected void Loginbtn_Click(object sender, EventArgs e)
        {
            string databasePassword, databaseUsername;
            string enteredPassword, enteredUsername;

            enteredPassword = Passwordtxt2.Text;
            enteredUsername = Usernametxt2.Text;

            //Selecting the Username & Password from the database
            string Sql = "SELECT * FROM ClientData WHERE Username LIKE '%" + enteredUsername + "%' AND Password LIKE '%" + enteredPassword + "%' ";
            Command = new SqlCommand(Sql, Connection);

            Connection.Open();

            using (SqlDataReader DataReader = Command.ExecuteReader())
            {
                if (DataReader.Read())
                {
                    //Getting the username and password converting them into strings for comparison
                    databaseUsername = DataReader[0].ToString();    //index 0
                    databasePassword = DataReader[1].ToString();    //index 1

                    if (CheckBox.Checked)
                    {
                        HttpCookie theCookie = new HttpCookie("Credentials");
                        theCookie["Username"] = enteredUsername;
                        theCookie["Password"] = enteredPassword;

                        Response.Cookies.Add(theCookie);
                        theCookie.Expires = DateTime.Now.AddDays(2);    //the cookie expires after 2 days
                    }

                    //comparing the credentials
                    if (enteredUsername == databaseUsername && enteredPassword == databasePassword)
                    {
                        Response.Redirect("Workshop.aspx"); //if the credentials match, redirect to the workshop page
                    }
                    else if (enteredUsername != databaseUsername && enteredPassword == databasePassword)
                    {
                        Displaylbl.Visible = true;
                        Displaylbl.Text = "Invalid username";
                    }
                    else if (enteredPassword != databasePassword && enteredUsername == databaseUsername)
                    {
                        Displaylbl.Visible = true;
                        Displaylbl.Text = "Invalid password";
                    }
                    else
                    {
                        Displaylbl.Visible = true;
                        Displaylbl.Text = "The credentials are invalid";
                    }
                }
            }
            Connection.Close();
        }

        protected void CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}