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
        HelperClass helperClass = new HelperClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=med;Initial Catalog=cenimaDatabase;Integrated Security=True";
            dbConnection = DatabaseConnection.Instance;
            connection = dbConnection.GetConnection(connectionString);
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
            helperClass.GotoRealisatorForm();
        }

        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helperClass.GotoFilmForm();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void ShortCuts(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.R)
            {
                helperClass.GotoRealisatorForm();
            } 
            else if(e.Control && e.KeyCode == Keys.F)
            {
                helperClass.GotoFilmForm();
            }
            else if(e.Control && e.KeyCode == Keys.Q)
            {
                Environment.Exit(0);
            }
        }
    }
}
