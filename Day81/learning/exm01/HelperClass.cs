using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
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
                resetControls(txbID, txbName);
            }
        }
        public void addButton(Guna2TextBox txbID, Guna2TextBox txbTitle, Guna2TextBox txbLength,Guna2DateTimePicker dtpDate, Guna2ComboBox cmbFilm, DataTable dataTable, Guna2DataGridView dataGridView, ErrorProvider errorProvider)
        {
            // Check if the value we want to add is already in the table
            bool hasDuplicate = checkDuplicatevalues(txbID, txbTitle,cmbFilm, dataTable,"id_film", "title_film", "realisator_name");
            // add values to the table
            bool isNotEmpty = isNotEmptyControl(txbID, txbTitle, txbLength, errorProvider);
            if (!hasDuplicate && isNotEmpty)
            {
                DataRow newRow = dataTable.NewRow();
                newRow["id_film"] = int.Parse(txbID.Text);
                newRow["title_film"] = txbTitle.Text;
                newRow["length_film"] = txbLength.Text;
                newRow["released_date"] = dtpDate.Text;
                newRow["realisator_name"] = cmbFilm.Text;
                dataTable.Rows.Add(newRow);
                resetControls(txbID, txbTitle, txbLength, dtpDate, cmbFilm);
                dataGridView.DataSource = dataTable;
            }
        }
        public void clearButton(Guna2TextBox txbID, Guna2TextBox txbName, DataTable dataTable, Guna2DataGridView dataGridView)
        {
            dataTable.Clear();
            resetControls(txbID, txbName);
            dataGridView.DataSource = dataTable;
        }
        public void clearButton(Guna2TextBox txbID, Guna2TextBox txbTitle, Guna2TextBox txbLength, Guna2DateTimePicker dtpDate, Guna2ComboBox cmbFilm, DataTable dataTable, Guna2DataGridView dataGridView)
        {
            dataTable.Clear();
            resetControls(txbID, txbTitle, txbLength, dtpDate, cmbFilm);
            dataGridView.DataSource = dataTable;
        }
        // put items from the datagridview into the controls in order to modify them
        public void dataGridViewCellClick(object sender, DataGridViewCellEventArgs e, Guna2TextBox txbID, Guna2TextBox txbName, Guna2DataGridView dataGridView)
        {
            if (e.RowIndex >= 0) // Check if a row is selected
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                txbID.Text = selectedRow.Cells["id_realisator"].Value.ToString().Trim();
                txbName.Text = selectedRow.Cells["realisator_name"].Value.ToString().Trim();
            }
        }
        public void dataGridViewCellClick(object sender, DataGridViewCellEventArgs e, Guna2TextBox txbID, Guna2TextBox txbTitle, Guna2TextBox txbLength, Guna2DateTimePicker dtpDate, Guna2ComboBox cmbFilm, Guna2DataGridView dataGridView)
        {
            if (e.RowIndex >= 0) // Check if a row is selected
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                txbID.Text = selectedRow.Cells["id_film"].Value.ToString().Trim();
                txbTitle.Text = selectedRow.Cells["title_film"].Value.ToString().Trim();
                txbLength.Text = selectedRow.Cells["length_film"].Value.ToString().Trim();
                dtpDate.Text = selectedRow.Cells["released_date"].Value.ToString().Trim();
                cmbFilm.Text = selectedRow.Cells["realisator_name"].Value.ToString().Trim();
            }
        }
        public void editButton(Guna2TextBox txbID, Guna2TextBox txbName, DataTable dataTable, Guna2DataGridView dataGridView, string column1, string column2)
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
        public void editButton(Guna2TextBox txbID, Guna2TextBox txbTitle, Guna2TextBox txbLength, Guna2DateTimePicker dtpDate, Guna2ComboBox cmbFilm, DataTable dataTable, Guna2DataGridView dataGridView, string column1, string column2, string column3, string column4, string column5)
        {
            bool hasDuplicate = checkDuplicatevalues(txbID,txbTitle, cmbFilm, dataTable, "id_film", "title_film" ,"realisator_name");
            if (!hasDuplicate)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                    selectedRow.Cells[column1].Value = txbID.Text;
                    selectedRow.Cells[column2].Value = txbTitle.Text;
                    selectedRow.Cells[column3].Value = txbLength.Text;
                    selectedRow.Cells[column4].Value = dtpDate.Text;
                    selectedRow.Cells[column5].Value = cmbFilm.Text;
                    dataGridView.DataSource = dataTable; // update datatable
                }
            }
        }
        public void deleteButton(Guna2TextBox txbID, Guna2TextBox txbName, Guna2DataGridView dataGridView, DataTable dataTable)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;
                dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
                dataTable.Rows.RemoveAt(selectedIndex);
                dataGridView.DataSource = dataTable;
                txbID.Text = "";
                txbName.Text = "";
            }
        }
        public void deleteButton(Guna2TextBox txbID, Guna2TextBox txbName, Guna2TextBox txbLength, Guna2DateTimePicker datePicker,Guna2ComboBox combo, Guna2DataGridView dataGridView, DataTable dataTable)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;
                dataGridView.Rows.Remove(dataGridView.SelectedRows[0]);
                dataTable.Rows.RemoveAt(selectedIndex);
                resetControls(txbID, txbName, txbLength, datePicker, combo);
                dataGridView.DataSource = dataTable;
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
        
        private bool checkDuplicatevalues(Guna2TextBox txbID, Guna2TextBox txbName,Guna2ComboBox comboBox, DataTable dataTable, string column1, string column2, string column3)
        {
            bool hasDuplicate = false;
            foreach (DataRow row in dataTable.Rows)
            {
                if (row[column1].ToString().Trim() == txbID.Text.ToString() && row[column2].ToString() == txbName.Text && row[column3].ToString().Trim() == comboBox.Text)
                {
                    MessageBox.Show("Value already exits", "Dublicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    hasDuplicate = true;
                }
            }
            return hasDuplicate;
        }
        private bool checkDuplicatevalues(Guna2TextBox val1, Guna2TextBox val2, DataTable dataTable, string column1, string colimn2)
        {
            bool hasDuplicate = false;
            string title = val1.Text.Trim();
            string realisator = val2.Text.Trim();
            foreach (DataRow row in dataTable.Rows)
            {
                if (row[column1].ToString().Trim() == title && row[colimn2].ToString().Trim() == realisator)
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
        private bool isNotEmptyControl(Guna2TextBox val1, Guna2TextBox val2, Guna2TextBox val3,  ErrorProvider errorProvider)
        {
            bool isNotEmpty = true;
            string errorMessage = "can't be empty";
            if (string.IsNullOrEmpty(val1.Text.Trim().ToString()))
            {
                isNotEmpty = false;
                errorProvider.SetError(val1, errorMessage);
            }
            else errorProvider.SetError(val1, "");
            if (string.IsNullOrEmpty(val2.Text.Trim()))
            {
                isNotEmpty = false;
                errorProvider.SetError(val2, errorMessage);
            }
            else errorProvider.SetError(val2, "");
            if (string.IsNullOrEmpty(val3.Text.Trim()))
            {
                isNotEmpty = false;
                errorProvider.SetError(val3, errorMessage);
            }
            else errorProvider.SetError(val3, "");
            return isNotEmpty;
        }
        public void allowIntOnly(KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void comboFiller(Guna2ComboBox comboBox,DataTable dataTable, string columnToShow, string columnToHide)
        {            
            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = columnToShow;
            comboBox.ValueMember = columnToHide;
        }
        private void resetControls(Guna2TextBox txbID, Guna2TextBox txbTitle, Guna2TextBox txbLength, Guna2DateTimePicker dtpDate, Guna2ComboBox cmbFilm)
        {
            txbID.Text = "";
            txbTitle.Text = "";
            txbLength.Text = "";
            dtpDate.ResetText();
            cmbFilm.ResetText();
        }
        private void resetControls(Guna2TextBox txbID, Guna2TextBox txbName)
        {
            txbID.Text = "";
            txbName.Text = "";
        }


    }
}
