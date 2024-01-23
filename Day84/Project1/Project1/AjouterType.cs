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
    public partial class AjouterType : Form
    {
        ProjetHelper projetHelper = new ProjetHelper();
        public AjouterType()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnule_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouterType_Click(object sender, EventArgs e)
        {
            projetHelper.AjouterType(txbProjetType, txbProjetLibele, txbProjetDuree);
        }
    }
}
