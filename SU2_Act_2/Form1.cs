using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SU2_Act_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\rabbit hole\BSc in IT\CMPG212\Prak\SU2_Act_2\Database1.mdf;Integrated Security=True");
        SqlCommand Command;
        SqlDataAdapter Adapter;
        DataSet DS;
        SqlDataReader Reader;
        
        private void Connectbutton_Click(object sender, EventArgs e)
        {
            Connection.Open();
            MessageBox.Show("Connected Successfully! ");
            Connection.Close();

        }
        private void Displaybutton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                Adapter = new SqlDataAdapter();
                DS = new DataSet();

                string sql = "SELECT * FROM MovieTable";
                Command = new SqlCommand(sql, Connection);

                Adapter.SelectCommand = Command;
                Adapter.Fill(DS, "MovieTable");

                dataGridView.DataSource = DS;
                dataGridView.DataMember = "MovieTable";

                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }
        private void Goodbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                Adapter = new SqlDataAdapter();
                DS = new DataSet();

                string sql = "SELECT * FROM MovieTable WHERE Rating > 3";

                Command = new SqlCommand(sql, Connection);

                Adapter.SelectCommand = Command;
                Adapter.Fill(DS, "MovieTable");

                dataGridView.DataSource = DS;
                dataGridView.DataMember = "MovieTable";

                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);            
            }
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.Items.Add("ID/t" + "Movie Name/t" + "Rating/t" + "Price");
            listBox.Items.Add("--------------------------------------");

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                Adapter = new SqlDataAdapter();
                DS = new DataSet();

                string sql = "SELECT MovieID, MovieName, Rating, Price FROM MovieTable WHERE Genre = "+ comboBox.SelectedItem + "";
                Command = new SqlCommand(sql, Connection);

                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    listBox.Items.Add((Reader.GetValue(0) + "\t" + Reader.GetValue(1)));
                }

                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);            
            }
        }
    }
}
