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

namespace Act_5
{
    public partial class frmVehicles : Form
    {
        public frmVehicles()
        {
            InitializeComponent();
        }

        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\rabbit hole\BSc in IT\CMPG212\Prak\SU2_Act_5\VehiclesDB.mdf;Integrated Security=True");
        SqlDataAdapter Adapter = new SqlDataAdapter();
        DataSet DS = new DataSet();

        private void LoadAll()
        {
            try
            {
                Connection.Open();

                SqlCommand Command = new SqlCommand(@"SELECT * FROM VehiclesTable", Connection);

                Adapter.SelectCommand = Command;
                Adapter.Fill(DS, "VehiclesTable");

                dataGridView.DataSource = DS;
                dataGridView.DataMember = "VehiclesTable";

                Connection.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void frmVehicles_Load(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            frmDelete myDeleteForm = new frmDelete();
            myDeleteForm.ShowDialog();
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                String SQl = @"SELECT * FROM VehiclesTable WHERE vin_number LIKE '%" + SearchtextBox.Text +
                    "%' OR brand LIKE '%" + SearchtextBox.Text + "%' OR model LIKE '%" + SearchtextBox.Text
                    + "%' OR year LIKE '%" + SearchtextBox.Text + "%' OR type LIKE '%" + SearchtextBox.Text + "%'";

                SqlCommand Command = new SqlCommand(SQl, Connection);

                Adapter.SelectCommand = Command;
                Adapter.Fill(DS, "VehiclesTable");

                dataGridView.DataSource = DS;
                dataGridView.DataMember = "VehiclesTable";

                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                SqlCommand Command = new SqlCommand("INSERT INTO VehiclesTable (vin_number, brand, model, year, type) VALUES (@vin_number, @brand, @model, @year, @type)", Connection);
                Command.Parameters.AddWithValue("@vin_number", int.Parse(NumbertextBox.Text));
                Command.Parameters.AddWithValue("@brand",  BrandtextBox.Text);
                Command.Parameters.AddWithValue("@model", ModeltextBox.Text);
                Command.Parameters.AddWithValue("@year", int.Parse(YeartextBox.Text));
                Command.Parameters.AddWithValue("@type", TypetextBox.Text);
                Command.ExecuteNonQuery();

                Connection.Close();
                MessageBox.Show("Data Successfully Inserted");
                LoadAll();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
