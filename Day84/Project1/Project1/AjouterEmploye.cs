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
    public partial class AjouterEmploye : Form
    {
        RadioButton radioButtonToPass;
        EmployeHelper employeHelper = new EmployeHelper();
        public AjouterEmploye()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(ShortcutKey);
            radioButton1.CheckedChanged += radioButton_checkChange;
            radioButton2.CheckedChanged += radioButton_checkChange;
        }
        private void radioButton_checkChange(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if(radioButton.Checked) radioButtonToPass = radioButton;
        }

        private void btnEmployeAjouter_Click(object sender, EventArgs e)
        {
            employeHelper.ajouterEmployer(txbEmployeNom, txbEmployePrenom, radioButtonToPass, dateTimePickerEmploye, txbEmployeFunction);
        }

        private void ShortcutKey(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.G)
            {
                txbEmployeId.Text = "1";
                txbEmployeNom.Text = "Moh";
                txbEmployePrenom.Text = "Chami";
                radioButton1.Checked = true;
                dateTimePickerEmploye.Value = DateTime.Now;
                txbEmployeFunction.Text = "programmer";
            }
        }

        private void btnEmployeeAnnule_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
