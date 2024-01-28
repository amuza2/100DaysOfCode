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
    public partial class AjouterEtudient : Form
    {
        HelperClass helper = new HelperClass();
        public AjouterEtudient()
        {
            InitializeComponent();
        }

        private void btnAnnule_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            helper.AjouterEtudient(tbNom, tbAddress);
        }
    }
}
