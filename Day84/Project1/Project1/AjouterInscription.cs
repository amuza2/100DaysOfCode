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
    public partial class AjouterInscription : Form
    {
        ProjetHelper projetHelper = new ProjetHelper();
        EmployeHelper employeHelper = new EmployeHelper();
        InscriptionHelper inscriptionHelper = new InscriptionHelper();
        public AjouterInscription()
        {
            InitializeComponent();
        }

        private void AjouterInscription_Load(object sender, EventArgs e)
        {
            projetHelper.showProjets(cmbCodeProjet, txbDu, txbAu);
            employeHelper.showEmploye(cmbNumEploye, txbNom, txbPrenom, txbFonction);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbNumEploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbNumEploye_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Update related values once a value in a comboBox is selected
            DataRowView selectedRow = (DataRowView)cmbNumEploye.SelectedItem;
            if (selectedRow != null)
            {
                txbNom.Text = selectedRow[Tables.NomEmploye].ToString();
                txbPrenom.Text = selectedRow[Tables.PrenomEmploye].ToString();
                txbFonction.Text = selectedRow[Tables.FonctionEmploye].ToString();
            }
        }

        private void cmbCodeProjet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cmbCodeProjet.SelectedItem;
            if (selectedRow != null)
            {
                txbDu.Text = selectedRow[Tables.DateDebut].ToString();
                txbAu.Text = selectedRow[Tables.DateFin].ToString();
            }
        }
        private void btnAjouterEmployeRecrute_Click(object sender, EventArgs e)
        {
            AjouterEmploye ajouterEmploye = new AjouterEmploye();
            ajouterEmploye.Show();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmbCodeProjet.Text.Trim()))
            {
                MessageBox.Show("Ajouter un projet svp");
            }
            else if (string.IsNullOrEmpty(cmbNumEploye.Text.Trim()))
            {
                MessageBox.Show("Ajouter un employe svp");
            }
            inscriptionHelper.AjouterInscription(cmbCodeProjet, cmbNumEploye, dateTimePickerInscription);
        }
    }
}
