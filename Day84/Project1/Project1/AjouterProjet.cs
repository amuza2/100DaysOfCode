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
    public partial class AjouterProjet : Form
    {
        ProjetHelper ProjetHelper = new ProjetHelper();
        public AjouterProjet()
        {
            InitializeComponent();
        }

        private void btnAnnule_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouterType_Click(object sender, EventArgs e)
        {
            AjouterType ajouterType = new AjouterType();
            ajouterType.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AjouterProjet_Load(object sender, EventArgs e)
        {
            ProjetHelper.ShowProjetTypes(cmbTypeProjet);
        }

        private void btnProjetValider_Click(object sender, EventArgs e)
        {
            ProjetHelper.AjouterProjet(txtProjetCode, cmbTypeProjet, dateTimePickerProjetDebutDate, dateTimePickerProjetFinDate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        public void UpdateComboBox()
        {
            ProjetHelper.ShowProjetTypes(cmbTypeProjet);
        }
    }
}
