using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketReservation
{
    public partial class ticketReservation : Form
    {
        public ticketReservation()
        {
            InitializeComponent();
        }
        string destination = String.Empty;
        string departure = String.Empty;
        string firstName = String.Empty;
        string lastName = String.Empty;
        string travelDocument = String.Empty;
        string documentNumber;
        string baggageWeight;
        string issueDate;
        string expireDate;
        string startTrip = String.Empty;
        string endTrip = String.Empty;

        private void btnOrderTicket_Click(object sender, EventArgs e)
        {
            destination = txtbxDestination.Text;
            departure = txtboxDeparture.Text;

            startTrip = monthCalander.SelectionStart.ToShortDateString();
            endTrip = monthCalander.SelectionEnd.ToShortDateString();


            firstName = txtbxFirstName.Text;
            lastName = txtbxLastName.Text;

            if (radioPassport.Checked) { travelDocument = radioPassport.Text; }
            else if (radioIDcard.Checked) { travelDocument = radioIDcard.Text; }

            issueDate = datetimeIssue.Value.ToShortDateString();
            expireDate = datetimeExpire.Value.ToShortDateString();
            documentNumber = txtbxDocumentNumber.Text;
            baggageWeight = updownBaggage.Value.ToString();

            Dictionary<string, string> mydict = new Dictionary<string, string>();
            mydict.Add("destination", destination);
            mydict.Add("departure", departure);
            mydict.Add("firstName", firstName);
            mydict.Add("lastName", lastName);
            mydict.Add("travelDocument", travelDocument);
            mydict.Add("documentNumber", documentNumber);
            mydict.Add("baggageWeight", baggageWeight);
            mydict.Add("issueDate", issueDate);
            mydict.Add("expireDate", expireDate);
            mydict.Add("startTrip", startTrip);
            mydict.Add("endTrip", endTrip);

            ConfirmReservationForm confirmReservationForm = new ConfirmReservationForm(mydict);
            confirmReservationForm.Show();


        }

        private void radioPassport_CheckedChanged(object sender, EventArgs e)
        {
            if(radioPassport.Checked == true)
            {
                lblChDocNumber.Text = "Passport Number:";
                lblChDocIssueDate.Text = "Passwport issue date:";
                lblChDocExpireDate.Text = "Passwport expiry date:";
            }
        }

        private void radioIDcard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioIDcard.Checked == true)
            {
                lblChDocNumber.Text = "ID Card Number:";
                lblChDocIssueDate.Text = "ID Card issue date:";
                lblChDocExpireDate.Text = "ID Card expiry date:";
            }
        }
    }
}
