//GIVEN MNISI - 34292748

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace SU3_Act6
{
    public partial class Default : System.Web.UI.Page
    {

        public SqlConnection Connection;
        public SqlCommand Command;
        public DataSet DS;
        public SqlDataAdapter DataAdapter;
        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Given\Downloads\IT\CMPG212\SU3_Act6\App_Data\PetsDB.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AllPetsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                string sql = "SELECT HouseId, PetName, PetType FROM PetTable";

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
            catch(SqlException error)
            {
                OutputLabel.Text = error.Message;
            }
        }

        protected void LargePetsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
                string sql = "SELECT HouseId, PetName FROM PetTable WHERE PetSize LIKE 'Large'";

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
            catch (SqlException error)
            {
                OutputLabel.Text = error.Message;
            }
        }
    }
}