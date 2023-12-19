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
        private DataSet mainDataSet;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbConnection = DatabaseConnection.Instance;
            connection = dbConnection.GetConnection();
            SqlCommand sqlCommandRealisator = dbConnection.CreateCommand(ColumnNames.SQLrealisator);
            SqlCommand sqlCommandFilm = dbConnection.CreateCommand(ColumnNames.SQLfilm);
            mainDataSet = dbConnection.fillAdapterToDataSet(sqlCommandRealisator, ColumnNames.dsRealisator);
            mainDataSet = dbConnection.fillAdapterToDataSet(sqlCommandFilm, ColumnNames.dsFilm);
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
