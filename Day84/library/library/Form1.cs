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
    public partial class Form1 : Form
    {
        HelperClass helper = new HelperClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAjouterLivre_Click(object sender, EventArgs e)
        {
            AjouterLivre ajouterLivre = new AjouterLivre();
            ajouterLivre.Show();
        }

        private void btnListLivre_Click(object sender, EventArgs e)
        {
            ChercherLivre chercherLivre = new ChercherLivre();
            chercherLivre.Show();
        }
    }
}
