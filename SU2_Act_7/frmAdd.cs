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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void Input()
        {
            try
            {
                Connection.Open();

                String SQl = "INSERT INTO MovieTable (MovieName, MovieDirector, MovieRating, MovieYear) VALUES (@MovieName, @MovieDirector, @MovieRating, @MovieYear)";

                SqlCommand Command = new SqlCommand(SQl, Connection);
                Command.Parameters.AddWithValue(@"MovieName", (NametextBox.Text));
                Command.Parameters.AddWithValue("@MovieDirector", (DirectortextBox.Text));
                Command.Parameters.AddWithValue("@MovieRating", int.Parse(RatingtextBox.Text));
                Command.Parameters.AddWithValue("@MovieYear", int.Parse(YeartextBox.Text));

                Command.ExecuteNonQuery();
                Connection.Close();
                MessageBox.Show("Record Successfully Inserted");

                this.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Given\Downloads\IT\CMPG212\Act_7\MoviesDB.mdf;Integrated Security=True");
        private void Insertmoviebutton_Click(object sender, EventArgs e)
        {
            if (RatingtextBox.Text == "")
            {
                errorProvider.SetError(RatingtextBox, "Invalid movie rating");
            }
            else if (YeartextBox.Text == "")
            {
                errorProvider.SetError(YeartextBox, "Invalid movie year");
            }
            else
            {
                Input();
            }
        }
    }
}
