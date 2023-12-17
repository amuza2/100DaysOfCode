using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exm01
{
    public partial class Form1 : Form
    {
        private DatabaseConnection dbConnection;
        private SqlConnection connection;
        SqlDataAdapter adapter;
        private DataSet mainDataSet = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbConnection = DatabaseConnection.Instance;
            connection = dbConnection.GetConnection();
            SqlCommand sqlCommandRealisator = dbConnection.CreateCommand("SELECT * FROM realisator");
            SqlCommand sqlCommandFilm = dbConnection.CreateCommand("SELECT id_film, title_film, length_film, released_date, realisator.realisator_name FROM film \r\nINNER JOIN realisator ON film.id_realisator = realisator.id_realisator");
            mainDataSet = dbConnection.fillAdapterToDataSet(sqlCommandRealisator, "dsRealisator");
            mainDataSet = dbConnection.fillAdapterToDataSet(sqlCommandFilm, "dsFilm");
            dbConnection.Disconnecting();
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
