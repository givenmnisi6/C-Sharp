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

namespace Act_5
{
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }

        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\rabbit hole\BSc in IT\CMPG212\Prak\SU2_Act_5\VehiclesDB.mdf;Integrated Security=True");
        SqlDataAdapter Adapter = new SqlDataAdapter();

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();

                SqlCommand Command = new SqlCommand(@"DELETE FROM VehiclesTable WHERE model = '" + Vehicletextbox.Text + "'", Connection);

                Adapter.DeleteCommand = Command;
                Adapter.DeleteCommand.ExecuteNonQuery();

                MessageBox.Show("Record deleted!");
                Connection.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
