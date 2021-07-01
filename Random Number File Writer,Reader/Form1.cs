
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
                GenRandNum(int.Parse(InputtextBox.Text));
        
            
        }


        private void GenRandNum(int number)
        {
            try
            { 
            //RANDOM NUMBERS
            Random rand = new Random();


            StreamWriter OutputFile;
            OutputFile = File.CreateText("Numbers.txt");
            for (int i = 0; i < number; i++)
            {
                //GENERATING RANDOM NUMBERS FROM 1 TO 100
                Randnumbers = rand.Next(100) + 1;

                //WRITING THE RANDOM NUMBERS ON THE TEXT
                OutputFile.WriteLine(Randnumbers.ToString());
                Total += Randnumbers;
            }
            //CLOSES THE FILE CREATED
            OutputFile.Close();

            MessageBox.Show("File Saved Successfully!");

            //ENABLES THE READ BUTTON AFTER SAVING 
            Readbutton.Enabled = true;
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void Readbutton_Click(object sender, EventArgs e)
        {
            try
            {

            
            //READS MY TEXT FILE
            StreamReader OutputFile;
            int counter = 0;

            //OPENING THE TEXT FILE
            OutputFile = File.OpenText("Numbers.txt");
           
            //DISABLING IT UP UNTIL THE SAVE BUTTON SAVES SUCCESSFULLY
            while (OutputFile.EndOfStream == false)
            {
                //READS THE TEXT FILE INTO THE LIST BOX
                OutputlistBox.Items.Add(OutputFile.ReadLine());
                counter++;
            }
            //CLOSING THE TEXT FILE
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

