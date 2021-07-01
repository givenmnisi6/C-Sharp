
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Project_SU4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
 
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            StreamWriter TextFile;
            try
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {

                    string path = saveFile.FileName;
                    TextFile = File.CreateText(path);

                    //PROMPT THE USER TO ENTER PLAYER NAMES IN THE TEXTBOX
                    TextFile.WriteLine(InputtextBox.Text);
                    TextFile.Close();
                    MessageBox.Show("You the saved the text");
                    
                }
                else
                {
                    MessageBox.Show("You clicked the Cancel button");
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }


        private void Readbutton_Click(object sender, EventArgs e)
        {
            StreamReader TextFile;
            
            if(openFile.ShowDialog() == DialogResult.OK)
            {

                string path = openFile.FileName;
                TextFile = File.OpenText(path);

                while (!TextFile.EndOfStream)
                {
                    OutputlistBox.Items.Add(TextFile.ReadLine());                
                }
                
                MessageBox.Show("You have clicked the open button");
            }
            else
            {
                MessageBox.Show("You have terminated the program");
            }
        }
    }
}
