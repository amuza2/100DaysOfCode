using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exm01
{
    internal class HelperClass
    {
        public virtual void addButton(Guna2TextBox txbID, Guna2TextBox txbName, DataTable dataTable, Guna2DataGridView dataGridView)
        {
            string id = txbID.Text;
            string name = txbName.Text;
            // Check if the value we want to add is already in the table
            bool valueExits = false;
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["id_realisator"].ToString() == id || row["realisator_name"].ToString() == name)
                {
                    valueExits = true;
                    break;
                }
            }
            // add values to the table
            if (!valueExits)
            {
                DataRow newRow = dataTable.NewRow();
                newRow["id_realisator"] = id;
                newRow["realisator_name"] = name;
                dataTable.Rows.Add(newRow);
                dataGridView.DataSource = dataTable;
            }
            // show a message box that there is a duplicate value
            else MessageBox.Show("Value already exits", "Dublicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
        public virtual void editButton(Guna2TextBox txbID, Guna2TextBox txbName, DataTable dataTable, Guna2DataGridView dataGridView)
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
                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                    selectedRow.Cells["id_realisator"].Value = txbID.Text;
                    selectedRow.Cells["realisator_name"].Value = txbName.Text;
                }
            }
            else MessageBox.Show("Value already exits", "Dublicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


    }
}
