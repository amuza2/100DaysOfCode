using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class ChercherEmployer : Form
    {
        EmployeHelper employeHelper = new EmployeHelper();
        public ChercherEmployer()
        {
            InitializeComponent();
        }

        private void ChercherEmployer_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            employeHelper.searchEmployes(dataGridView1, txbSearch, radioButton1, radioButton2, radioButton3);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
