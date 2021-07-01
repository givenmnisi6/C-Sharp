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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Given\Desktop\Prak\CMPG212\Act_6\TheatersDB.mdf;Integrated Security=True");

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                String SQl = "INSERT INTO TheaterTable (TheaterNumber, TotalSeats, OpenSeats, TheaterSize) VALUES (@TheaterNumber, @TotalSeats, @OpenSeats, @TheaterSize)";

                SqlCommand Command = new SqlCommand(SQl, Connection);
                Command.Parameters.AddWithValue(@"TheaterNumber",   int.Parse(NumbertextBox.Text));
                Command.Parameters.AddWithValue("@TotalSeats",  int.Parse(TotaltextBox.Text));
                Command.Parameters.AddWithValue("@OpenSeats", int.Parse(OpentextBox.Text));
                Command.Parameters.AddWithValue("@TheaterSize", (SizetextBox.Text));
    
                Command.ExecuteNonQuery();
                Connection.Close();
                MessageBox.Show("Record Successfully Inserted");
            
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            this.Close();


        }
    }
}
