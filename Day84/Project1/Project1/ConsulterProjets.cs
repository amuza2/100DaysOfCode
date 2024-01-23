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
    public partial class ConsulterProjets : Form
    {
        ProjetHelper projetHelper = new ProjetHelper();
        public ConsulterProjets()
        {
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouterProjet_Click(object sender, EventArgs e)
        {
            AjouterProjet ajouterProjet = new AjouterProjet();
            ajouterProjet.Show();
        }

        private void ConsulterProjet_Load(object sender, EventArgs e)
        {
            projetHelper.showProjetsInDataGridView(dataGridView1);
        }

        private void btnListerParDate_Click(object sender, EventArgs e)
        {
            projetHelper.sortByDate(dataGridView1);
        }

        private void btnListerParType_Click(object sender, EventArgs e)
        {
            projetHelper.sortByType(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int itemIndex = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                ConsulterProjet consulterProjet = new ConsulterProjet(itemIndex);
                consulterProjet.Show();
            }
        }
    }
}
