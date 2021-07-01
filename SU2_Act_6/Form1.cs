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

namespace Act_6
{
    public partial class frmTheatres : Form
    {
        public frmTheatres()
        {
            InitializeComponent();
        }

        SqlConnection Connection = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Given\Desktop\Prak\CMPG212\Act_6\TheatersDB.mdf;Integrated Security=True");
        SqlCommand Command;
        SqlDataAdapter Adapter;
        DataSet DS;

        private void PopulateComboBox()
        {
            Connection.Open();
            SqlDataReader Reader;
            Command = new SqlCommand(@"SELECT TheaterNumber FROM TheaterTable", Connection);
            Reader = Command.ExecuteReader();
            comboBox.Items.Clear();
            while (Reader.Read())
            {
                comboBox.Items.Add(Reader.GetValue(0));
            }
            Connection.Close();
        }

        private void LoadAll()
        {
            try
            {
                Connection.Open();

                SqlCommand Command = new SqlCommand(@"SELECT * FROM TheaterTable", Connection);
                DS = new DataSet();
                Adapter = new SqlDataAdapter();

                Adapter.SelectCommand = Command;
                Adapter.Fill(DS, "TheaterTable");

                dataGridView.DataSource = DS;
                dataGridView.DataMember = "TheaterTable";

                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void frmTheatres_Load(object sender, EventArgs e)
        { 
            PopulateComboBox();
            MessageBox.Show("Database connection successful!");
           
        }
        private void ViewAllbutton_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void OpenSeatsbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                SqlCommand Command = new SqlCommand(@"SELECT * FROM TheaterTable WHERE OpenSeats < 50", Connection);
                DS = new DataSet();
                Adapter = new SqlDataAdapter();

                Adapter.SelectCommand = Command;
                Adapter.Fill(DS, "TheaterTable");

                dataGridView.DataSource = DS;
                dataGridView.DataMember = "TheaterTable";

                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Totalbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                SqlCommand Command = new SqlCommand(@"SELECT * FROM TheaterTable WHERE TotalSeats BETWEEN 120 AND 260 ", Connection);
                DS = new DataSet();
                Adapter = new SqlDataAdapter();

                Adapter.SelectCommand = Command;
                Adapter.Fill(DS, "TheaterTable");

                dataGridView.DataSource = DS;
                dataGridView.DataMember = "TheaterTable";

                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            frmAdd frmView = new frmAdd();
            frmView.ShowDialog();
            LoadAll();
            PopulateComboBox();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                String SQl = @"DELETE FROM TheaterTable WHERE TheaterNumber = '" + comboBox.SelectedItem.ToString() + "'";
                SqlCommand Command = new SqlCommand(SQl, Connection);
                SqlDataAdapter Adapter = new SqlDataAdapter();

                Adapter.DeleteCommand = Command;
                Adapter.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Record deleted!");
                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            LoadAll();
            PopulateComboBox();
        }
    }
}
