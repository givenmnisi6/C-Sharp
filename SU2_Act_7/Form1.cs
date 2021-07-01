//GIVEN MNISI - 34292748

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

namespace Act_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Given\Downloads\IT\CMPG212\Act_7\MoviesDB.mdf;Integrated Security=True");
        SqlCommand Command;
        SqlDataAdapter Adapter;
        DataSet DS;

        //METHODS
        private void PopulateComboBox()
        {
            try
            {
                Connection.Open();
                SqlDataReader Reader;
                Command = new SqlCommand(@"SELECT MovieName FROM MovieTable", Connection);
                Reader = Command.ExecuteReader();

                comboBox.Items.Clear();
                while (Reader.Read())
                {
                    comboBox.Items.Add(Reader.GetValue(0));
                }
                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void LoadAll()
        {
            try
            {
                Connection.Open();

                SqlCommand Command = new SqlCommand(@"SELECT * FROM MovieTable", Connection);
                DS = new DataSet();
                Adapter = new SqlDataAdapter();

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
        private void PopulateListBox()
        {
            try
            {
                Connection.Open();
                SqlDataReader Reader;
                Command = new SqlCommand(@"SELECT * FROM MovieTable", Connection);
                Reader = Command.ExecuteReader();
                listBox1.Items.Clear();
                while (Reader.Read())
                {
                    listBox1.Items.Add(Reader.GetValue(0) + "\t" + Reader.GetValue(1) + "\t" + Reader.GetValue(2) + "\t" + Reader.GetValue(3));
                    listBox1.Items.Add("");
                }
                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //POPULATE THE DATAGRID VIEW & THE COMBO BOX
            LoadAll();
            PopulateComboBox();
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                SqlDataReader Reader;
                Command = new SqlCommand(@"SELECT * FROM MovieTable WHERE MovieName LIKE '%" + NametextBox.Text + "%'", Connection);
                Reader = Command.ExecuteReader();
                listBox1.Items.Clear();
                while (Reader.Read())
                {
                    listBox1.Items.Add(Reader.GetValue(0) + "\t" + Reader.GetValue(1) + "\t" + Reader.GetValue(2) + "\t" + Reader.GetValue(3));
                    listBox1.Items.Add("");
                }
                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            PopulateListBox();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                String SQl = @"DELETE FROM MovieTable WHERE MovieName = '" + comboBox.SelectedItem.ToString() + "'";
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

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            frmAdd frmView = new frmAdd();
            frmView.ShowDialog();
            LoadAll();
            PopulateComboBox();
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                //SHOW THE YEAR THAT IS BEING SCROLLED ON THE SCROLL BAR
                label4.Text = hScrollBar.Value.ToString();

                Connection.Open();
                SqlDataReader Reader;
                Command = new SqlCommand(@"SELECT * FROM MovieTable WHERE MovieYear LIKE '%" + hScrollBar.Value + "%'", Connection);
                Reader = Command.ExecuteReader();
                listBox1.Items.Clear();
                while (Reader.Read())
                {
                    listBox1.Items.Add(Reader.GetValue(0) + "\t" + Reader.GetValue(1) + "\t" + Reader.GetValue(2) + "\t" + Reader.GetValue(3));
                }
                Connection.Close();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void RatingcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                SqlDataReader Reader;
                Command = new SqlCommand(@"SELECT * FROM MovieTable WHERE MovieRating LIKE '%" + RatingcomboBox.Text + "%'", Connection);
                Reader = Command.ExecuteReader();
                listBox1.Items.Clear();
                while (Reader.Read())
                {
                    listBox1.Items.Add(Reader.GetValue(0) + "\t" + Reader.GetValue(1) + "\t" + Reader.GetValue(2) + "\t" + Reader.GetValue(3));
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
