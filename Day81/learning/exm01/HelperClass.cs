using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Guna.UI2.Native.WinApi;

namespace exm01
{
    internal class HelperClass
    {
        public void addButton(Guna2TextBox txbID, Guna2TextBox txbName, DataTable dataTable, Guna2DataGridView dataGridView, ErrorProvider errorProvider)
        {
            // Check if the value we want to add is already in the table
            bool hasDuplicate = checkDuplicatevalues(txbID, txbName, dataTable, "id_realisator", "realisator_name");
            // add values to the table
            bool isNotEmpty = isNotEmptyControl(txbID, txbName, errorProvider);
            if (!hasDuplicate && isNotEmpty)
            {
                DataRow newRow = dataTable.NewRow();
                newRow["id_realisator"] = int.Parse(txbID.Text);
                newRow["realisator_name"] = txbName.Text;
                dataTable.Rows.Add(newRow);
                dataGridView.DataSource = dataTable;
                txbID.Text = "";
                txbName.Text = "";
            }
        }
        public virtual void clearButton(Guna2TextBox txbID, Guna2TextBox txbName, DataTable dataTable, Guna2DataGridView dataGridView)
        {
            dataTable.Clear();
            dataGridView.DataSource = dataTable;
            txbID.Text = "";
            txbName.Text = "";
        }
        public virtual void dataGridViewCellClick(object sender, DataGridViewCellEventArgs e, Guna2TextBox txbID, Guna2TextBox txbName, Guna2DataGridView dataGridView)
        {
            if (e.RowIndex >= 0) // Check if a row is selected
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                txbID.Text = selectedRow.Cells["id_realisator"].Value.ToString().Trim();
                txbName.Text = selectedRow.Cells["realisator_name"].Value.ToString().Trim();
            }
        }
        public virtual void editButton(Guna2TextBox txbID, Guna2TextBox txbName, DataTable dataTable, Guna2DataGridView dataGridView, string column1, string column2)
        {
            bool hasDuplicate = checkDuplicatevalues(txbName, dataTable, "realisator_name");
            if (!hasDuplicate)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                    selectedRow.Cells[column1].Value = txbID.Text;
                    selectedRow.Cells[column2].Value = txbName.Text;
                    dataGridView.DataSource = dataTable; // update datatable
                }
            }
        }
        public virtual void deleteButton(Guna2TextBox txbID, Guna2TextBox txbName, Guna2DataGridView dataGridView, DataTable dataTable)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
                dataGridView.DataSource = dataTable;
                txbID.Text = "";
                txbName.Text = "";
            }
        }
        // check duplicate values
        private bool checkDuplicatevalues(Guna2TextBox txbName, DataTable dataTable, string column1)
        {
            bool hasDuplicate = false;
            string name = txbName.Text;
            foreach (DataRow row in dataTable.Rows)
            {
                if (row[column1].ToString() == name)
                {
                    MessageBox.Show("Value already exits", "Dublicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    hasDuplicate = true;
                }
            }
            return hasDuplicate;
        }
        private bool checkDuplicatevalues(Guna2TextBox txbID, Guna2TextBox txbName, DataTable dataTable, string column1, string column2)
        {
            bool hasDuplicate = false;
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["id_realisator"].ToString() == txbID.Text.ToString() || row["realisator_name"].ToString() == txbName.Text)
                {
                    MessageBox.Show("Value already exits", "Dublicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    hasDuplicate = true;
                }
            }
            return hasDuplicate;
        }
        private bool isNotEmptyControl(Guna2TextBox id, Guna2TextBox name, ErrorProvider errorProvider)
        {
            bool isNotEmpty = true;
            string errorMessage = "can't be empty";
            if (string.IsNullOrEmpty(id.Text.Trim().ToString()))
            {
                isNotEmpty = false;
                errorProvider.SetError(id, errorMessage);
            }
            else errorProvider.SetError(id, "");
            if (string.IsNullOrEmpty(name.Text.Trim()))
            {
                isNotEmpty = false;
                errorProvider.SetError(name, errorMessage);
            }
            else errorProvider.SetError(name, "");
            return isNotEmpty;
            
        }


    }
}
