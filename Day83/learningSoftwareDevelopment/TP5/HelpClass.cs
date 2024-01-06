using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public class HelpClass
    {
        public void addButton(Guna2TextBox textBox1, Guna2TextBox textBox2, Guna2DataGridView dataGridView, DataTable dataTable, string columnName1, string columnName2)
        {
            if(isValidinputToAdd(textBox1, textBox2))
            {
                try
                {
                    DataRow newRow = dataTable.NewRow();
                    newRow[columnName1] = textBox1.Text.Trim();
                    newRow[columnName2] = textBox2.Text.Trim();
                    dataTable.Rows.Add(newRow);
                    dataGridView.DataSource = dataTable;
                    MessageBox.Show("data added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex, "Error");
                }
            }
        }
        private bool isValidinputToAdd(Guna2TextBox textBox1, Guna2TextBox textBox2)
        {
            bool isValidated = false;
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) || string.IsNullOrEmpty(textBox2.Text.Trim()))
                MessageBox.Show("Please add value to the empty field", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else isValidated = true;

            return isValidated;
        }
        public void editButton(Guna2TextBox textBox1, Guna2TextBox textBox2, Guna2DataGridView dataGridView, DataTable dataTable, string columnName1, string columnName2)
        {
            if (dataGridView.Rows.Count > 0 && !string.IsNullOrEmpty(textBox1.Text))
            {
                string txtID = textBox1.Text.Trim();
                int counter = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row[columnName1].Equals(int.Parse(txtID)))
                    {
                        dataTable.Rows[counter][columnName2] = textBox2.Text.Trim();
                        dataGridView.DataSource = dataTable;
                        break;
                    }
                    counter++;
                }
            }
        }
    }
}
