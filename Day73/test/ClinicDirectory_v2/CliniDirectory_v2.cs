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
    public partial class CliniDirectory_v2 : Form
    {
        public CliniDirectory_v2()
        {
            InitializeComponent();
        }
        DataTable dtClinic = new DataTable();
        DataTable dtDoctor = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create Clinic table columns
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

            // Add combobox Names
            comboBox1.DataSource = dtClinic;
            comboBox1.DisplayMember = "Name";

            // Create Doctos table columns
            dtDoctor.Columns.Add("ID", typeof(int));
            dtDoctor.Columns.Add("Name", typeof(string));
            dtDoctor.Columns.Add("Speciality", typeof(string));
            dtDoctor.Columns.Add("Contact", typeof(string));

            // Add rows to the table
            dtDoctor.Rows.Add(1, "Dr Jia Ford", "Heart Surgeon", "016890111");
            dtDoctor.Rows.Add(1, "Dr Sasha Glenn", "ABC Specialist", "016863123120111");
            dtDoctor.Rows.Add(1, "Dr Peter Ford", "Heart Specialist", "01686012451");
            dtDoctor.Rows.Add(1, "Dr Mile Pompeo", "Lung Specialist", "01526498");
            dtDoctor.Rows.Add(2, "Dr Alx back", "Generalist", "01240025");
            dtDoctor.Rows.Add(2, "Dr Bard Twin", "Food Specialist", "08652001114");
            dtDoctor.Rows.Add(2, "Dr Ceren Mer", "Brain Surgeon", "01268001152");
            dtDoctor.Rows.Add(2, "Dr Draft case", "Nurse", "0125402225");
            dtDoctor.Rows.Add(3, "Dr Brono Fire", "Allergy Specialist", "01244588");
            dtDoctor.Rows.Add(3, "Dr Zoo Foam", "Dermatologist", "1302548001");
            dtDoctor.Rows.Add(3, "Dr Rebica twelve", "Family Medicine", "0221148220");
            dtDoctor.Rows.Add(4, "Dr Alegye tamb", "Internal medicine", "012458890");
            dtDoctor.Rows.Add(4, "Dr Marry Array", "Medical genetics", "0589520001");
            dtDoctor.Rows.Add(4, "Dr Freedm Palstn", "Neurologist", "0988932022");
            dtDoctor.Rows.Add(4, "Dr Camal Noah", "Nuclear medicine", "055788035");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblClinicName.Text = dtClinic.Rows[comboBox1.SelectedIndex]["Name"].ToString();
            lblClinicAddress.Text = dtClinic.Rows[comboBox1.SelectedIndex]["Address"].ToString();
            lblClinicAddress.Text = dtClinic.Rows[comboBox1.SelectedIndex]["Address"].ToString();
            lblContactNumber.Text = dtClinic.Rows[comboBox1.SelectedIndex]["Contact Number"].ToString();
            lblClinicRating.Text = dtClinic.Rows[comboBox1.SelectedIndex]["Rating"].ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
