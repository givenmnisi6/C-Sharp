
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DiamondpictureBox_Click(object sender, EventArgs e)
        {
            answerlabel.Text = "Eight of Diamonds";
        }

        private void ClubpictureBox_Click(object sender, EventArgs e)
        {
            answerlabel.Text = "Two of Clubs";
        }

        private void KingpictureBox_Click(object sender, EventArgs e)
        {
            answerlabel.Text = "King of Spades";
        }

        private void AcepictureBox_Click(object sender, EventArgs e)
        {
            answerlabel.Text = "Ace of Spades";
        }

        private void JokerpictureBox_Click(object sender, EventArgs e)
        {
            answerlabel.Text = "Black Joker";
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
