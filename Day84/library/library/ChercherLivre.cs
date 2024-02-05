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
    public partial class ChercherLivre : Form
    {
        HelperClass helper = new HelperClass();
        public ChercherLivre()
        {
            InitializeComponent();
        }

        private void ChercherLivre_Load(object sender, EventArgs e)
        {
            helper.showLivre(dataGridView1, Tables.sql);
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            helper.ChercherParCode(tbSearch, dataGridView1, radioButton1, radioButton2, radioButton3);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int itemIndex = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                EmpruntLivre empruntLivre = new EmpruntLivre(itemIndex);
                empruntLivre.Show();
            }
        }
    }
}
