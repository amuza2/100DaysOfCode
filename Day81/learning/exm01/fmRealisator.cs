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
using System.Xml.Linq;

namespace exm01
{
    public partial class fmRealisator : Form
    {
        public fmRealisator()
        {
            InitializeComponent();
        }
        private DatabaseConnection dbConnection;
        private SqlConnection connection;
        private SqlCommand sqlCommand;
        SqlDataAdapter adapter;
        private DataSet dataSet = new DataSet();
        private DataTable realisatorTable;
        HelperClass helperClass = new HelperClass();

        private void fmRealisator_Load(object sender, EventArgs e)
        {
            dbConnection = DatabaseConnection.Instance;
            connection = dbConnection.GetConnection();
            sqlCommand = dbConnection.CreateCommand("SELECT * FROM realisator");
            dataSet = dbConnection.fillAdapterToDataSet(sqlCommand, "dsRealisator");
            realisatorTable = dbConnection.dataSet.Tables["dsRealisator"];
            dgvRealisator.DataSource = realisatorTable;
            dgvRealisator.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txbConnectionChecker.Text = connection.State.ToString();
            
        }

        private void fmRealisator_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            helperClass.addButton(txbId, txbName, realisatorTable, dgvRealisator);
        }

        private void fmRealisator_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                dbConnection.SaveDataSet(dataSet, adapter, "dsRealisator");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while saving the data: " + ex.Message);
            }
            finally
            {
                dbConnection.Disconnecting();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            helperClass.clearButton(txbId, txbName, realisatorTable, dgvRealisator);
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            helperClass.dataGridViewCellClick(sender, e, txbId, txbName, dgvRealisator);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            helperClass.editButton(txbId, txbName, realisatorTable, dgvRealisator, "id_realisator", "realisator_name");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            helperClass.deleteButton(txbId, txbName, dgvRealisator, realisatorTable);

        }
    }
}