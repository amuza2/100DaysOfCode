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
    public partial class ConsulterProjet : Form
    {
        private int rowIndex;
        ProjetHelper projetHelper = new ProjetHelper();
        InscriptionHelper inscriptionHelper = new InscriptionHelper();
        public ConsulterProjet(int val)
        {
            InitializeComponent();
            rowIndex = val;
        }

        private void btnNouvelleInscription_Click(object sender, EventArgs e)
        {
            AjouterInscription ajouterInscription = new AjouterInscription();
            ajouterInscription.Show();
        }

        private void btnReturnToProjetsList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsulterProjet_Load(object sender, EventArgs e)
        {
            projetHelper.showProjets(txbProjetName, txbProjetDu, txbProjetAu, rowIndex);
            inscriptionHelper.showInscribedEmployesToAProjet(rowIndex, dataGridView1);
        }
    }
}
