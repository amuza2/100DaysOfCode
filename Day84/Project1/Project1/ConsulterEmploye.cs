using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project1
{
    public partial class ConsulterEmploye : Form
    {
        EmployeHelper employeHelper = new EmployeHelper();
        public ConsulterEmploye()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnule_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsulterEmploye_Load(object sender, EventArgs e)
        {
            employeHelper.showEmployesToEdit(cmbNumEmploye, txbNomEmploye, txbPrenomEmploye, radioButton1, radioButton2, dateTimePicker1, txbFonctionEmploye);
        }

        private void cmbNumEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cmbNumEmploye.SelectedItem;
            if(selectedRow != null)
            {
                txbNomEmploye.Text = selectedRow[Tables.NomEmploye].ToString();
                txbPrenomEmploye.Text = selectedRow[Tables.PrenomEmploye].ToString();
                if (selectedRow[Tables.SexeEmploye].ToString().Trim() == "Masculin")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
                dateTimePicker1.Value = (DateTime)selectedRow[Tables.DNaissEmploye];
                txbFonctionEmploye.Text = selectedRow[Tables.FonctionEmploye].ToString();
            }
        }

        private void btnModifyEmploye_Click(object sender, EventArgs e)
        {
            employeHelper.modifyEmploye(cmbNumEmploye, txbNomEmploye, txbPrenomEmploye, radioButton1, radioButton2, dateTimePicker1, txbFonctionEmploye);
        }
    }
}
