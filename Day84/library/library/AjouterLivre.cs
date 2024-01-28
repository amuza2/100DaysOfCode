using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class AjouterLivre : Form
    {
        HelperClass helper = new HelperClass();
        public AjouterLivre()
        {
            InitializeComponent();
        }

        private void btnannulé_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            helper.AjouterLivre(tbTitre, tbAuteur, tbExamplaires, cbTheme);
        }

        private void btnAjouterTheme_Click(object sender, EventArgs e)
        {
            AjouterTheme ajouterTheme = new AjouterTheme();
            ajouterTheme.Show();
        }
        public void UpdateThemesComboBox()
        {
            helper.ShowThemes(cbTheme);
        }

        private void AjouterLivre_Load(object sender, EventArgs e)
        {
            helper.ShowThemes(cbTheme);
        }
    }
}
