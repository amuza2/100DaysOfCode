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
    public partial class EmpruntLivre : Form
    {
        HelperClass helper = new HelperClass();
        int row;
        public EmpruntLivre(int itemIndex)
        {
            InitializeComponent();
            row = itemIndex;
        }

        private void EmpruntLivre_Load(object sender, EventArgs e)
        {
            helper.showLivre(tbCode, tbTitre, TbAuteur, tbNb, tbTheme, row);
            helper.showStudent(dataGridView1);
        }

        private void btnAjouterEtudient_Click(object sender, EventArgs e)
        {
            AjouterEtudient ajouterEtudient = new AjouterEtudient();
            ajouterEtudient.Show();
        }
        public void ShowStudentGrid()
        {
            helper.showStudent(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            helper.AjouterEmprunt(tbCode, dataGridView1, dateTimePicker1);
        }
    }
}
