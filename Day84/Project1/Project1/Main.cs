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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnEmployeAjouter_Click(object sender, EventArgs e)
        {
            AjouterEmploye ajouterEmploye = new AjouterEmploye();
            ajouterEmploye.Show();
        }

        private void btnProjetAjouter_Click(object sender, EventArgs e)
        {
            AjouterProjet ajouterProjet = new AjouterProjet();
            ajouterProjet.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d/MM/yyyy");
        }

        private void btnInscriptionCreation_Click(object sender, EventArgs e)
        {
            AjouterInscription ajouterInscription = new AjouterInscription();
            ajouterInscription.Show();
        }

        private void btnEmployeRechercher_Click(object sender, EventArgs e)
        {
            ChercherEmployer chercherEmployer = new ChercherEmployer();
            chercherEmployer.Show();
        }

        private void btnProjetConsulter_Click(object sender, EventArgs e)
        {
            ConsulterProjets consulterProjet = new ConsulterProjets();
            consulterProjet.Show();
        }

        private void btnEmployeConsulter_Click(object sender, EventArgs e)
        {
            ConsulterEmploye consulterEmploye = new ConsulterEmploye();
            consulterEmploye.Show();
        }
    }
}
