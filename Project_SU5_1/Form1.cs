
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


namespace Project_SU4
{
    public partial class Form1 : Form
    {
        //MY CODE
        //VARIABLES
        int number;
        int Randnumbers;
        int Total = 0;


        public Form1()
        {
            InitializeComponent();
        }
        private void Savebutton_Click(object sender, EventArgs e)
        {
                ReadNumbers(int.Parse(InputtextBox.Text));                   
        }


        private void ReadNumbers(int number)
        {
            try
            { 
            Random rand = new Random();
            StreamWriter OutputFile;
            OutputFile = File.CreateText("Numbers.txt");
            for (int i = 0; i < number; i++)
            {

                Randnumbers = rand.Next(100) + 1;


                OutputFile.WriteLine(Randnumbers.ToString());
                Total += Randnumbers;
            }

            OutputFile.Close();

            MessageBox.Show("File Saved Successfully!");


            Readbutton.Enabled = true;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void Readbutton_Click(object sender, EventArgs e)
        {
            OutputNumbers();
        }           
            private void OutputNumbers()
            {
                try
                {
                    StreamReader OutputFile;
                    int counter = 0;

                    OutputFile = File.OpenText("Numbers.txt");

                    while (OutputFile.EndOfStream == false)
                    {
                        OutputlistBox.Items.Add(OutputFile.ReadLine());
                        counter++;
                    }
                    OutputFile.Close();
                    OutputlistBox.Items.Add("\n");
                    OutputlistBox.Items.Add("The total number of dice rolls  read from file: " + counter.ToString());
                    OutputlistBox.Items.Add("The total of the numbers is: " + Total.ToString());
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }            
        }
    }
}

