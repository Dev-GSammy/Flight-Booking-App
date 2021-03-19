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
    public partial class FlightBookingApp : Form
    {
        public FlightBookingApp()
        {
            InitializeComponent();
        }
        public static Boolean Passport, IdCard, None;
        public static string From, To, StartDate, EndDate, DateRange, FirstName, LastName, DocumentNumber, IssueDate, ExpiryDate, Baggage;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;
        }

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            From = txtfrom.Text;
            To = txtTo.Text;
            StartDate = monthCalendar1.SelectionStart.ToString("dd MM yyyy");
            EndDate = monthCalendar1.SelectionEnd.ToString("dd MM yyyy");
            FirstName = txtFName.Text;
            LastName = txtLName.Text;
            DocumentNumber = txtDocNumber.Text;
            IssueDate = dateTimePicker1.Value.ToString("dd MM yyyy");
            ExpiryDate = dateTimePicker2.Value.ToString("dd MM yyyy");
            Baggage = numericUpDown1.Value.ToString();
            if (radioButtonNone.Checked == true)
            {
                MessageBox.Show("You cannot book a flight without a valid identification document");
            }
            else
            {
                this.Hide();
                Flight_Booking_Summary flightbookingsummary = new Flight_Booking_Summary();
                flightbookingsummary.Show();
            }
        }

        private void FlightBookingApp_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 100;
            monthCalendar1.ShowToday = true;
            numericUpDown1.Increment = 5;
            numericUpDown1.ReadOnly = true;
        }
        public void DocumentChange()
        {
            lblDocIssueDate.Text = "Document Issue Date";
            lblDocExpiryDate.Text = "Document Expiry Date";
            lblDocNumber.Text = "Document Number";
        }

        private void lblTravelDoc_Click(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPassport.Checked)
            {
                lblDocIssueDate.Text = "Passport Issue Date";
                lblDocExpiryDate.Text = "Passport Expiry Date";
                lblDocNumber.Text = "Passport Number";
                Passport = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIdCard.Checked)
            {
                lblDocIssueDate.Text = "ID Card Issue Date";
                lblDocExpiryDate.Text = "ID Card Expiry Date";
                lblDocNumber.Text = "ID Card Number";
                IdCard = true;
            }
        }

        private void lblLName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void radioButtonNone_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNone.Checked)
            {
                DocumentChange();
                IdCard = true;
            }
        }
    }
}
