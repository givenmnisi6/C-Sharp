
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //GLOBAL VARIABLE
        double Accommodation = 550; 


        //METHODS
        private double CalcStayCharges(double Days)
        {
            double DaysSpent = Accommodation * Days;
            return DaysSpent;
        }

        private double CalcMiscCharges(double Bill, double Spa, double Rental, double Medication)
        {
            double Amount = (Bill + Spa + Rental + Medication);
            return Amount;
        }

        private double CalcTotalCharges(double Days, double Bill, double Spa, double Rental, double Medication)
        {
            double Tot = (Accommodation * Days) + (Bill + Spa + Rental + Medication + Days);
            return Tot;
        }


        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            double Days, Staying, Bill, Spa, Rental, Medication, Extras, Total;                       
            Days = double.Parse(DaystextBox.Text);
            Bill = double.Parse(RestauranttextBox.Text);
            Spa = double.Parse(SpatextBox.Text);
            Rental = double.Parse(CartextBox.Text);
            Medication = double.Parse(MedicationtextBox.Text);

            //DECLARATION OF MY METHODS
            Extras = CalcMiscCharges(Bill, Spa, Rental, Medication);
            Total = CalcTotalCharges(Days, Bill, Spa, Rental, Medication);
            Staying = CalcStayCharges(Days);

            //OUTPUTTING THEM IN MY LIST BOX
            OutputlistBox.Items.Add("Stay Charge: " + Staying.ToString("C"));
            OutputlistBox.Items.Add("Miscellaneous Charges: " + Extras.ToString("C"));
            OutputlistBox.Items.Add("Total Bill: " + Total.ToString("C"));
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
