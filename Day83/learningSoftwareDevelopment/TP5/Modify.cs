using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public class Modify
    {
        public void ModifyButton(Guna2TextBox textBoxID, Guna2TextBox textBox2, Guna2DataGridView dataGridView, DataTable dataTable)
        {
            string txtID = textBoxID.Text.Trim();
            if (dataGridView.Rows.Count > 0 && !string.IsNullOrEmpty(txtID))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row[Tables.genreColumnID].Equals(int.Parse(txtID)))
                    {
                        row[Tables.genreColumnIntitle] = textBox2.Text.Trim();
                        dataGridView.DataSource = dataTable;
                        break;
                    }
                }
            }
        }
        public void ModifyButton(Guna2TextBox textBoxID, Guna2TextBox titre, Guna2DateTimePicker date,Guna2ComboBox comboBox, Guna2DataGridView dataGridView, DataTable dataTable)
        {
            string txtID = textBoxID.Text.Trim();
            if (dataGridView.Rows.Count > 0 && !string.IsNullOrEmpty(txtID))
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row[Tables.serieColumnID].Equals(int.Parse(txtID)))
                    {
                        row[Tables.serieTitle] = titre.Text.Trim();
                        row[Tables.serieDate] = date.Value.ToShortDateString();
                        HelpClass helpClass = new HelpClass();
                        string selectedTitle = comboBox.Text;
                        string selectedCode = helpClass.GetCodeGenreFromTitle(selectedTitle, Tables.genreColumnID, Tables.genreTableName, Tables.genreColumnIntitle);
                        row[Tables.genreColumnID] = selectedCode;

                        dataGridView.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
