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

namespace SU2_Act1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\rabbit hole\BSc in IT\CMPG212\Prak\SU2_Act_1\TestDatabase.mdf;Integrated Security=True");
        SqlCommand Command;
        SqlDataAdapter Adapter = new SqlDataAdapter();
        DataSet DS = new DataSet();
        SqlDataReader Reader; 
       
        private void Connectbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                MessageBox.Show("Connected Successfully!");
                Connection.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Displaybtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                SqlCommand Sql = new SqlCommand(@"SELECT * FROM CLientList", Connection);

                Adapter.SelectCommand = Sql;
                Adapter.Fill(DS, "ClientList");

                dataGridView.DataSource = DS;
                dataGridView.DataMember = "ClientList";
                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);            
            }
        }

        private void Movebtn_Click(object sender, EventArgs e)
        {
            Displaylb.Items.Add("ID\t" + "Name\t\t" + "Surname\t\t" + "Email");
            Displaylb.Items.Add("----------------------------------------------------------------------------------------------------------");

            Connection.Open();

            Command = new SqlCommand(@"SELECT * FROM CLientList", Connection);
            Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                Displaylb.Items.Add(Reader.GetValue(0) + "\t" + Reader.GetValue(1) + "\t" +  Reader.GetValue(2) + "\t" +  Reader.GetValue(3));
            }
            Connection.Close();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
