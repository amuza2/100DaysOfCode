using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicDirectory_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dtClinic = new DataTable();
        DataTable dtDoctor = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create table columns
            dtClinic.Columns.Add("ID", typeof(int));
            dtClinic.Columns.Add("Name", typeof(string));
            dtClinic.Columns.Add("Address", typeof(string));
            dtClinic.Columns.Add("Contact Number", typeof(string));
            dtClinic.Columns.Add("Rating", typeof(string));

            // Add rows to the table
            dtClinic.Rows.Add(1, "Dentist Pro Clinic", "Palo Alto. Califirnia", "09001680111", "7.1/10");
            dtClinic.Rows.Add(2, "Healthy Care Center", "Palm Beach. Florida", "0190168011155", "9.1/10");
            dtClinic.Rows.Add(3, "IPO Clinic", "Cupertino. California", "12345", "8.0/10");
            dtClinic.Rows.Add(4, "Muhammad Ali's Center", "Blue Area Islamabad", "123456", "10/10");

            // Change UI labels


        }
    }
}
