using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exm01
{
    public partial class fmFilm : Form
    {
        private DatabaseConnection dbConnection;
        private SqlConnection connection = new SqlConnection();
        private DataSet dataSet;
        private SqlDataAdapter filmAdapter = new SqlDataAdapter();
        private SqlDataAdapter realisatorAdapter = new SqlDataAdapter();

        private DataTable dataTableFilm = new DataTable();
        private DataTable dataTableRealisator = new DataTable();
        public fmFilm()
        {
            InitializeComponent();
        }

        private void fmFilm_Load(object sender, EventArgs e)
        {
            
        }

        private void fmFilm_Load_1(object sender, EventArgs e)
        {
            dbConnection = DatabaseConnection.Instance;
            connection = dbConnection.GetConnection();
            SqlCommand sqlCommandFilm = dbConnection.CreateCommand("SELECT * FROM film");
            SqlCommand sqlCommandRealisator = dbConnection.CreateCommand("SELECT * FROM realisator");

            dbConnection.addTableDataSet(dataSet, sqlCommandFilm, "dsFilm");
            dbConnection.addTableDataSet(dataSet, sqlCommandRealisator, "dsRealisator");

            dataTableRealisator = dataSet.Tables["dsRealisator"];

            dgvFilm.DataSource = dataSet.Tables["dsFilm"];
            dgvFilm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //cbxfilm.DataSource = dataTableRealisator;
            //cbxfilm.DisplayMember = "realisator_Name";
            //cbxfilm.ValueMember = "id_realisator";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txbId.Text;
            string title = txbTitle.Text;
            string length = txbLength.Text;
            string releasedDate = dtpDate.Text;
            string comboFilm = cbxfilm.Text;
        }
    }
}
