using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
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
        private DataTable dataTableFilm;
        private DataTable dataTableRealisator;
        public fmFilm()
        {
            InitializeComponent();
        }

        private void fmFilm_Load(object sender, EventArgs e)
        {
            
        }

        private void fmFilm_Load_1(object sender, EventArgs e)
        {
            dataSet = DatabaseConnection.Instance.dataSet;
            dataTableRealisator = dataSet.Tables["dsRealisator"];
            dataTableRealisator = dataSet.Tables["dsFilm"];

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
