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
    public partial class RetourEmprunt : Form
    {
        HelperClass helper = new HelperClass();
        public RetourEmprunt()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            helper.ChercherParCode(textBox1, dataGridView1);
        }

        private void RetourEmprunt_Load(object sender, EventArgs e)
        {
            helper.showLivre(dataGridView1, Tables.sql2);
        }
    }
}
