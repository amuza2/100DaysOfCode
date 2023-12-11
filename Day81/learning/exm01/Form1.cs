using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exm01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void realisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmRealisator fmRealisator = new fmRealisator();
            fmRealisator.Show();
        }

        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmFilm fmFilm = new fmFilm();
            fmFilm.Show();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
