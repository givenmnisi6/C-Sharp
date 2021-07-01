using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assessment_2
{
    public partial class Register : System.Web.UI.Page
    {
        public SqlConnection Connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GIVEN MNISI\Downloads\IT\CMPG212\Assessment 2\App_Data\ClientData.mdf;Integrated Security = True");
        public SqlCommand Command;
        private void InsertToDatabase()
        {
                Connection.Open();

                String SQl = "INSERT INTO ClientData (Username, Password) VALUES (@Username, @Password)";

                SqlCommand Command = new SqlCommand(SQl, Connection);
                Command.Parameters.AddWithValue(@"Username", (Usernametxt.Text));
                Command.Parameters.AddWithValue("@Password", (Passwordtxt.Text));

                Command.ExecuteNonQuery();
                Connection.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Usernametxt.Focus();    //when the program loads it should start on the username textbox
        }

        protected void Registerbtn_Click(object sender, EventArgs e)
        {
            //to mask the textbox add:  TextMode="Password" on the source code [html] in the PasswordtextBox (Refer to line 43) 
            InsertToDatabase();

            Response.Redirect("Login.aspx");
        }
    }
}