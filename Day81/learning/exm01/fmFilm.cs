using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
        HelperClass helperClass = new HelperClass();
        string dsRealisator = "dsRealisator";
        string dsFilm = "dsFilm";
        public fmFilm()
        {
            InitializeComponent();
        }

        private void fmFilm_Load_1(object sender, EventArgs e)
        {
            dataSet = DatabaseConnection.Instance.dataSet;
            dataTableRealisator = dataSet.Tables[dsRealisator];
            dataTableFilm = dataSet.Tables[dsFilm];
            dgvFilm.DataSource = dataTableFilm;
            dgvFilm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            helperClass.comboFiller(cbxfilm, dataTableRealisator, "realisator_Name", "id_realisator");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            helperClass.addButton(txbId, txbTitle,txbLength,dtpDate, cbxfilm, dataTableFilm, dgvFilm, errorProvider2);
        }

        private void txbId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            helperClass.allowIntOnly(e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            helperClass.clearButton(txbId, txbTitle, txbLength, dtpDate, cbxfilm, dataTableFilm, dgvFilm);
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            helperClass.dataGridViewCellClick(sender, e, txbId, txbTitle, txbLength, dtpDate, cbxfilm, dgvFilm);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            helperClass.editButton(txbId, txbTitle, txbLength, dtpDate, cbxfilm, dataTableFilm, dgvFilm, "id_film", "title_film", "length_film", "released_date", "realisator_name");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
