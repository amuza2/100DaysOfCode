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
        private DataSet dataSet;
        private DataTable dataTable;

        private void fmRealisator_Load(object sender, EventArgs e)
        {
            dbConnection = DatabaseConnection.Instance;
            connection = dbConnection.GetConnection();
            sqlCommand = dbConnection.CreateCommand("SELECT * FROM realisator");
            dataSet = new DataSet();
            dbConnection.addTableDataSet(dataSet, sqlCommand, "dsRealisator");
            dataTable = dataSet.Tables["dsRealisator"];
            dgvRealisator.DataSource = dataTable;
            dgvRealisator.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txbConnectionChecker.Text = connection.State.ToString();
        }

        private void fmRealisator_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txbId.Text;
            string name = txbName.Text;
            bool valueExits = false;
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["id_realisator"].ToString() == id || row["realisator_name"].ToString() == name)
                {
                    valueExits = true;
                    break;
                }
            }
            if (!valueExits)
            {
                DataRow newRow = dataTable.NewRow();
                newRow["id_realisator"] = id;
                newRow["realisator_name"] = name;
                dataTable.Rows.Add(newRow);
                dgvRealisator.DataSource = dataTable;
            }
            else MessageBox.Show("Value already exits", "Dublicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dataTable.Clear();
            dgvRealisator.DataSource = dataTable;
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) // Check if a row is selected
            {
                DataGridViewRow selectedRow = dgvRealisator.Rows[e.RowIndex];
                txbId.Text = selectedRow.Cells["id_realisator"].Value.ToString().Trim();
                txbName.Text = selectedRow.Cells["realisator_name"].Value.ToString().Trim();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            bool valueExits = false;
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["realisator_name"].ToString() == name)
                {
                    valueExits = true;
                    break;
                }
            }
            if (!valueExits)
            {
                if (dgvRealisator.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvRealisator.SelectedRows[0];
                    selectedRow.Cells["id_realisator"].Value = txbId.Text;
                    selectedRow.Cells["realisator_name"].Value = txbName.Text;
                }
            }
            else MessageBox.Show("Value already exits", "Dublicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txbName.Text;
            if(dgvRealisator.SelectedRows.Count > 0)
            {
                dgvRealisator.Rows.Remove(dgvRealisator.SelectedRows[0]);
                //DataGridViewRow selectedRow = dgvRealisator.SelectedRows[0];
            }

        }
    }
}