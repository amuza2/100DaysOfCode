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
                            string textboxValue = txt.Text.Trim();
                            if (txt.Name.Equals("txbSerieCode")) int.Parse(textboxValue);
                            newRow[i] = textboxValue;
                        }
                        else if (values[i].GetType() == typeof(Guna2DateTimePicker))
                        {
                            Guna2DateTimePicker dateTimePicker = (Guna2DateTimePicker)values[i];
                            newRow[Tables.serieDate] = dateTimePicker.Value.ToShortDateString();
                        }
                        else if (values[i].GetType() == typeof(Guna2ComboBox))
                        {
                            Guna2ComboBox comboBox = (Guna2ComboBox)values[i];
                            string selectedTitle = comboBox.Text;
                            string selectedCode = GetCodeFromTitle(selectedTitle, Tables.genreColumnID, Tables.genreTableName, Tables.genreColumnIntitle);
                            newRow[i] = selectedCode;
                        }
                    }
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

        public string GetCodeFromTitle(string selectedTitle, string tab1, string tab2, string tab3)
        {
            string codeGenre = "";
            using (SqlConnection connection = db.Instance.getConnection())
            {
                string sql = $"SELECT {tab1} FROM {tab2} WHERE {tab3} = '{selectedTitle}'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    codeGenre = reader[tab1].ToString();
                }
            }
            return codeGenre;
        }
        public string GetCodeFromTitle(int selectedTitle, string tab1, string tab2, string tab3)
        {
            string codeGenre = "";
            using (SqlConnection connection = db.Instance.getConnection())
            {
                string sql = $"SELECT {tab1} FROM {tab2} WHERE {tab3} = {selectedTitle}";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    codeGenre = reader[tab1].ToString();
                }
            }
            return codeGenre;
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
        public void editButton(Guna2TextBox textBoxID, Guna2TextBox textBox2, Guna2DataGridView dataGridView, DataTable dataTable)
        {
            if (dataGridView.Rows.Count > 0 && !string.IsNullOrEmpty(textBoxID.Text))
            {
                string txtID = textBoxID.Text.Trim();
                int counter = 0;
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row[Tables.genreColumnID].Equals(int.Parse(txtID)))
                    {
                        dataTable.Rows[counter][Tables.genreColumnIntitle] = textBox2.Text.Trim();
                        dataGridView.DataSource = dataTable;
                        break;
                    }
                    counter++;
                }
            }
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
        public void deleteButton(DataTable dataTable, Guna2DataGridView dataGridView, Guna2TextBox textBox, string idColumn)
        {
            if (dataTable.Rows.Count > 0 && !string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row[idColumn].Equals(int.Parse(textBox.Text.Trim())))
                    {
                        row.Delete();
                        break;
                    }
                }
                dataTable.AcceptChanges();
                dataGridView.DataSource = dataTable;
            }
        }
        public void clearTextBox(Guna2TextBox textBox1, Guna2TextBox textBox2)
        {
            textBox1.Clear();
            textBox2.Clear(); 
        }
        public void clearTextBox(Guna2TextBox textBox1, Guna2TextBox textBox2, Guna2DateTimePicker dateTimePicker, Guna2ComboBox comboBox)
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker.Value = DateTime.Now;
            comboBox.SelectedIndex = 0;
        }
        public void comboBoxFilter(DataTable dataTable, Guna2ComboBox comboBox, string column1, string column2)
        {
            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = column1;
            comboBox.ValueMember = column2;
        }

    }
}
