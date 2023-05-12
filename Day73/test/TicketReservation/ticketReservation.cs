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
        string fistName = String.Empty;
        string lastName = String.Empty;
        string travelDocument = String.Empty;
        int documentNumber;
        int baggageWeight;

        private void btnOrderTicket_Click(object sender, EventArgs e)
        {
            
        }
    }
}
