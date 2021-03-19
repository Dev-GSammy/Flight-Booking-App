using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Booking_App
{
    public partial class Flight_Booking_Summary : Form
    {
        public Flight_Booking_Summary()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Flight_Booking_Summary_Load(object sender, EventArgs e)
        {
            if (FlightBookingApp.Passport)
            {
                lblDocNumber.Text = "Passport Number:";
                lblDocIssueDate.Text = "Passport Issue Date:";
                lblDocExpiryDate.Text = "Passport Expiry Date:";
            }
            if (FlightBookingApp.IdCard)
            {
                lblDocNumber.Text = "ID Card Number:";
                lblDocIssueDate.Text = "ID Card Issue Date:";
                lblDocExpiryDate.Text = "ID Card Expiry Date:";
            }
            Rfullname.Text = FlightBookingApp.FirstName + "  " + FlightBookingApp.LastName;
            rDepartureCity.Text = FlightBookingApp.From;
            rDestination.Text = FlightBookingApp.To;
            rTripStartDate.Text = FlightBookingApp.StartDate;
            rTripEndDate.Text = FlightBookingApp.EndDate;
            rDocumentNumber.Text = FlightBookingApp.DocumentNumber;
            rDocumentIssueDate.Text = FlightBookingApp.IssueDate;
            rDocumentExpiryDate.Text = FlightBookingApp.ExpiryDate;
            rBaggage.Text = FlightBookingApp.Baggage;
        }

        private void lblCorrect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for booking a flight with us \n Your details have been saved \n Do have a nice trip");
            Application.Exit();
           
        }

        private void lblIncorrect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Looks like you made a typo \n Please re-enter your details and submit");
            this.Hide();
            FlightBookingApp flightBookingApp = new FlightBookingApp();
            flightBookingApp.Show();
        }
    }
}
