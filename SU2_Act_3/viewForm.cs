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

namespace SU2_Act_3
{
    public partial class viewData : Form
    {
        public viewData()
        {
            InitializeComponent();
        }

        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\rabbit hole\BSc in IT\CMPG212\Prak\SU2_Act_3\DVDs.mdf;Integrated Security=True");
        SqlDataAdapter Adapter;
        DataSet DS;


        private void viewData_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT * FROM DVDTable ", Connection);
                Adapter = new SqlDataAdapter();
                DS = new DataSet();

                Adapter.SelectCommand = Command;
                Adapter.Fill(DS, "DVDTable");

                dataGridView.DataSource = DS;
                dataGridView.DataMember = "DVDTable";

                Connection.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void Actionbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT * FROM DVDTable WHERE Type LIKE '%ACT%'", Connection);
                Adapter = new SqlDataAdapter();
                DS = new DataSet();

                Adapter.SelectCommand = Command;
                Adapter.Fill(DS, "DVDTable");

                dataGridView.DataSource = DS;
                dataGridView.DataMember = "DVDTable";

                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                Connection.Open();
                SqlCommand Command = new SqlCommand(@"SELECT * FROM DVDTable WHERE Age <= '" + hScrollBar.Value + "'", Connection);
                Adapter = new SqlDataAdapter();
                DS = new DataSet();

                Adapter.SelectCommand = Command;
                Adapter.Fill(DS, "DVDTable");

                dataGridView.DataSource = DS;
                dataGridView.DataMember = "DVDTable";

                Connection.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            Displaylbl.Visible = true;
            Displaylbl.Text = hScrollBar.Value.ToString();
        }
    }
}
