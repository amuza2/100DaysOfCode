using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Directory
{
    struct Clinic
    {
        public string Name { get; set; }
        public string Address { get; set;}
        public string ContactNumber { get; set; }
        public string ContactRating { get; set; }
        public List<Doctor> doctors = new List<Doctor>();

        public Clinic(string n, string adrs, string contactNum, string contactRat)
        {
            Name = n;
            Address = adrs;
            ContactNumber = contactNum;
            ContactRating = contactRat;
        }
    }
    struct Doctor
    {
        public string Name { get; set;}
        public string Speciality { get; set; }
        public string Contact { get; set;}

        public Doctor(string n, string s, string c)
        {
            Name = n;
            Speciality = s;
            Contact = c;
        }
    }
    public partial class ClinicDirectoryForm : Form
    {
        public ClinicDirectoryForm()
        {
            InitializeComponent();
        }
        Clinic foundObject = new Clinic();
        List<Clinic> clinicList = new List<Clinic>();
        DataTable dt = new DataTable();

        void FillClinicTable()
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Contact Number", typeof(string));
            dt.Columns.Add("Contact Rating", typeof(string));
            int idCounter = 1;
            foreach (Clinic Citem in clinicList)
            {
                dt.Rows.Add(idCounter++, Citem.Name, Citem.Address, Citem.ContactNumber, Citem.ContactRating);
                
            }
        }



        private void ClinicDirectoryForm_Load(object sender, EventArgs e)
        {
            Clinic clinic01 = new Clinic("Dentist Pro Clinic", "Palo Alto. Califirnia", "09001680111", "7.1/10");
            Clinic clinic02 = new Clinic("Healthy Care Center", "Palm Beach. Florida", "0190168011155", "9.1/10");
            Clinic clinic03 = new Clinic("IPO Clinic", "Cupertino. California", "12345", "8.0/10");
            Clinic clinic04 = new Clinic("Muhammad Ali's Center", "Blue Area Islamabad", "123456", "10/10");

            clinicList.AddRange(new Clinic[] { clinic01, clinic02, clinic03, clinic04});

            clinic01.doctors.Add(new Doctor("Dr Jia Ford", "Heart Surgeon", "016890111"));
            clinic01.doctors.Add(new Doctor("Dr Sasha Glenn", "ABC Specialist", "016863123120111"));
            clinic01.doctors.Add(new Doctor("Dr Peter Ford", "Heart Specialist", "01686012451"));
            clinic01.doctors.Add(new Doctor("Dr Mile Pompeo", "Lung Specialist", "01526498"));

            clinic02.doctors.Add(new Doctor("Dr Alx back", "Generalist", "01240025"));
            clinic02.doctors.Add(new Doctor("Dr Bard Twin", "Food Specialist", "08652001114"));
            clinic02.doctors.Add(new Doctor("Dr Ceren Mer", "Brain Surgeon", "01268001152"));
            clinic02.doctors.Add(new Doctor("Dr Draft case", "Nurse", "0125402225"));

            clinic03.doctors.Add(new Doctor("Dr Brono Fire", "Allergy Specialist", "01244588"));
            clinic03.doctors.Add(new Doctor("Dr Zoo Foam", "Dermatologist", "1302548001"));
            clinic03.doctors.Add(new Doctor("Dr Rebica twelve", "Family Medicine", "0221148220"));

            clinic04.doctors.Add(new Doctor("Dr Alegye tamb", "Internal medicine", "012458890"));
            clinic04.doctors.Add(new Doctor("Dr Marry Array", "Medical genetics", "0589520001"));
            clinic04.doctors.Add(new Doctor("Dr Freedm Palstn", "Neurologist", "0988932022"));
            clinic04.doctors.Add(new Doctor("Dr Camal Noah", "Nuclear medicine", "055788035"));

            comboboxClinics.Items.AddRange(new object[] { clinic01.Name, clinic02.Name, clinic03.Name, clinic04.Name });
        }

        private void comboboxClinics_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool foundSelected = false;
            if(comboboxClinics.SelectedItem  != null)
            {
                string selectedItem = comboboxClinics.SelectedItem.ToString();
                foreach(Clinic c in clinicList)
                {
                    if(c.Name == selectedItem)
                    {
                        lblClinicName.Text = c.Name;
                        lblClinicAddress.Text = c.Address;
                        lblClinicNumber.Text = c.ContactNumber;
                        lblClinicRating.Text = c.ContactRating;
                        foundSelected = true;
                        foundObject = c;
                        break;
                    }
                }
            }
            if (foundSelected)
            {
                comboboxDoctors.Items.Clear();
                foreach (Doctor d in foundObject.doctors)
                {
                    comboboxDoctors.Items.Add(d.Name);
                }

                foundSelected = false;
            }
        }

        private void comboboxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboboxDoctors.SelectedItem != null)
            {
                string selectedItem = comboboxDoctors.SelectedItem.ToString();
                foreach(Doctor v in foundObject.doctors)
                {
                    if(v.Name == selectedItem)
                    {
                        lblDoctorName.Text = v.Name;
                        lblDoctorSpeciality.Text = v.Speciality;
                        lblDoctorContact.Text = v.Contact;
                    }
                }
            }
        }
    }
}
