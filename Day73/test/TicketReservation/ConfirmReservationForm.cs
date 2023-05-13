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
    public partial class ConfirmReservationForm : Form
    {
        Dictionary<string, string> mydict = new Dictionary<string, string>();
        public ConfirmReservationForm(Dictionary<string, string> d)
        {
            InitializeComponent();
            mydict = d;
        }

        private void ConfirmReservationForm_Load(object sender, EventArgs e)
        {
            string text = "";
            if (mydict["travelDocument"].ToLower() != "passport")
            {
                text = "Please bring original ID Card, ";
            }    
            lblHeader.Text = $"{text}\n\nFurther details has been sent to you on your email";

            lblFullName.Text = mydict["firstName"] + " " + mydict["lastName"];
            lblDeparture.Text = mydict["departure"];
            lblDestination.Text = mydict["destination"];
            lblTrip.Text = mydict["startTrip"] + " to " + mydict["endTrip"];
            lblChDocNum.Text = mydict["travelDocument"] + " Number:";
            lblPassportNumber.Text = mydict["documentNumber"];
            lblChExpDate.Text = mydict["travelDocument"] + " Expire Date:";
            lblPassportExpireDate.Text = mydict["expireDate"];
            lblBaggageWeight.Text = mydict["baggageWeight"];


        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConfirmReservationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
