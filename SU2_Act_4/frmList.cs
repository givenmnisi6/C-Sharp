using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act_4
{
    public partial class frmList : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\rabbit hole\BSc in IT\CMPG212\Prak\SU2_Act_4\CompaniesDB.mdf;Integrated Security=True");
        SqlDataAdapter Adapter;
        DataSet DS;


        public frmList()
        {
            InitializeComponent();
        }

        private void Displaybutton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                SqlCommand Sql = new SqlCommand(@"SELECT * FROM CompaniesTable", Connection);
                Adapter = new SqlDataAdapter();
                DS = new DataSet();

                Adapter.SelectCommand = Sql;
                Adapter.Fill(DS, "CompaniesTable");

                dataGridView.DataSource = DS;
                dataGridView.DataMember = "CompaniesTable";

                Connection.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                string SqlQuery = $"SELECT * FROM CompaniesTable WHERE Slogan LIKE '%" + SearchtextBox.Text + "%'";
                SqlCommand Sql = new SqlCommand(SqlQuery, Connection);
                Adapter = new SqlDataAdapter();
                DS = new DataSet();

                Adapter.SelectCommand = Sql;
                Adapter.Fill(DS, "CompaniesTable");

                dataGridView.DataSource = DS;
                dataGridView.DataMember = "CompaniesTable";

                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Findbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                string SqlQuery = @"SELECT* FROM CompaniesTable WHERE Rating LIKE '%" + FindtextBox.Text + "%'";
                SqlCommand Sql = new SqlCommand(SqlQuery, Connection);
                Adapter = new SqlDataAdapter();
                DS = new DataSet();

                Adapter.SelectCommand = Sql;
                Adapter.Fill(DS, "CompaniesTable");

                dataGridView.DataSource = DS;
                dataGridView.DataMember = "CompaniesTable";

                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
