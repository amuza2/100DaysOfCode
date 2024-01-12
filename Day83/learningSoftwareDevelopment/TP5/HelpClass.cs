using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TP5
{
    
    public class HelpClass
    {
        public void addButton(Guna2DataGridView dataGridView, DataTable dataTable, params object[] values)
        {
            if(isValidinputToAdd(values))
            {
                try
                {
                    DataRow newRow = dataTable.NewRow();
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (values[i].GetType() == typeof(Guna2TextBox))
                        {
                            Guna2TextBox txt = (Guna2TextBox)values[i];
                            newRow[i] = txt.Text.Trim();
                        }
                        else if(values[i].GetType() == typeof(Guna2DateTimePicker))
                        {
                            Guna2DateTimePicker dateTimePicker = (Guna2DateTimePicker)values[i];
                            newRow[i] = dateTimePicker.Text;
                        }
                        else if(values[i].GetType() == typeof(Guna2ComboBox))
                        {
                            Guna2ComboBox comboBox = (Guna2ComboBox)values[i];
                            newRow[i] = comboBox.Text;
                        }
                    }
                    dataTable.Rows.Add(newRow);
                    updateDataGridView(dataGridView, dataTable);
                    MessageBox.Show("data added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex, "Error");
                }
            }
        }
        private void updateDataGridView(Guna2DataGridView dataGridView, DataTable dataTable)
        {
            dataGridView.DataSource = dataTable;
        }
        private bool isValidinputToAdd(params object[] values)
        {
            bool isNotValid = false;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].GetType() == typeof(Guna2TextBox))
                {
                    Guna2TextBox txt = (Guna2TextBox)values[i];
                    if(String.IsNullOrEmpty(txt.Text.Trim()))
                    {
                        isNotValid = true; break;
                    }
                }
                else if (values[i].GetType() == typeof(Guna2ComboBox))
                {
                    Guna2ComboBox comboBox = (Guna2ComboBox)values[i];
                    if (String.IsNullOrEmpty(comboBox.Text))
                    {
                        isNotValid = true; break;
                    }
                }
            }
            if(isNotValid) MessageBox.Show("Please add/select value to the empty field", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return !isNotValid;
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
        public SqlCommand createCommand(SqlConnection connection, string commandSQLString)
        {
            return new SqlCommand(commandSQLString, connection);
        }
        public void getTableFromDataBaseToDataTable(DataTable dataTable)
        {
            db.Adapter.Fill(dataTable);
        }

        public DataTable getTableFromDataSet(DataSet dataSet,string table)
        {
            return dataSet.Tables[table];
        }

        public void cellClick(DataGridViewCellEventArgs e, DataTable dataTable, Guna2DataGridView dataGridView, Guna2TextBox textBox1, Guna2TextBox textBox2)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataTable.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                textBox1.Text = selectedRow.Cells[Tables.genreColumnID].Value.ToString();
                textBox2.Text = selectedRow.Cells[Tables.genreColumnIntitle].Value.ToString();
            }
        }
        public void deleteButton(DataTable dataTable, Guna2DataGridView dataGridView, Guna2TextBox textBox, Guna2TextBox textBox1, List<string> ids)
        {
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row[Tables.genreColumnID].Equals(int.Parse(textBox.Text.Trim())))
                    {
                        row.Delete();
                        dataTable.AcceptChanges();
                        dataGridView.DataSource = dataTable;
                        ids.Add(textBox.Text.Trim());
                        clearTextBox(textBox, textBox1);
                        break;
                    }
                }
            }
        }
        public void clearTextBox(params object[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].GetType() == typeof(Guna2TextBox))
                {
                    Guna2TextBox txb = (Guna2TextBox)values[i];
                    txb.Clear();
                }
            }
        }
        public void comboBoxFilter(DataTable dataTable, Guna2ComboBox comboBox, string column1, string column2)
        {
            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = column1;
            comboBox.ValueMember = column2;
        }

        public void addcommand(SqlConnection connection,string sqlQuery)
        {
            try
            {
                db.Adapter.SelectCommand = createCommand(connection, sqlQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}
