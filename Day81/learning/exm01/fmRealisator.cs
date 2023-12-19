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
        private DataSet dataSet;
        private DataTable realisatorTable;
        HelperClass helperClass = new HelperClass();

        private void fmRealisator_Load(object sender, EventArgs e)
        {
            dataSet = DatabaseConnection.Instance.dataSet;
            realisatorTable = dataSet.Tables[ColumnNames.dsRealisator];
            dgvRealisator.DataSource = realisatorTable;
            dgvRealisator.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void fmRealisator_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            helperClass.addButton(txbId, txbName, realisatorTable, dgvRealisator, errorProvider);
        }

        private void fmRealisator_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            helperClass.editButton(txbId, txbName, realisatorTable, dgvRealisator, ColumnNames.idRealisatorCol, ColumnNames.realisatorNameCol);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            helperClass.deleteButton(txbId, txbName, dgvRealisator, realisatorTable);

        }

        private void txbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            helperClass.allowIntOnly(e);
        }
    }
}