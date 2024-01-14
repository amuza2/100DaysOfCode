using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public partial class Form1 : Form
    {
        DataTable genreDataTable = db.sharedDataSet.Tables[Tables.genreDtName];
        CurrencyManager genreManager;
        HelpClass helpClass = new HelpClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = genreDataTable;
            genreManager = (CurrencyManager)BindingContext[genreDataTable];
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            helpClass.addButton(DataGridView1, genreDataTable, txbID, txbGenre);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            helpClass.editButton(txbID, txbGenre, DataGridView1, genreDataTable);
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            helpClass.cellClick(e, genreDataTable, DataGridView1, txbID, txbGenre);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            helpClass.clearTextBox(txbID, txbGenre);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                helpClass.deleteButton(genreDataTable, DataGridView1, txbID, txbGenre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Deleting: " + ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = db.Instance.getConnection())
                {
                    //SqlCommand command = null;
                    //foreach (DataRow row in helpClass.rowsState)
                    //{
                    //    if (row.RowState == DataRowState.Deleted)
                    //    {
                    //        string sql = $"DELETE FROM {Tables.genreTableName} WHERE {Tables.genreColumnID} = {row[Tables.genreColumnID]}";
                    //        command = new SqlCommand(sql, connection);
                    //    }
                    //    if (command != null) command.ExecuteNonQuery();
                    //}
                    //using (SqlCommand cmd = new SqlCommand("ALTER TABLE Genre NOCHECK CONSTRAINT ALL", connection))
                    //{
                    //    cmd.ExecuteNonQuery();
                    //}
                    //using (SqlCommand cmd = new SqlCommand("DELETE FROM Genre", connection))
                    //{
                    //    cmd.ExecuteNonQuery();
                    //}
                    //using (SqlCommand cmd = new SqlCommand("ALTER TABLE Genre WITH CHECK CHECK CONSTRAINT ALL", connection))
                    //{
                    //    cmd.ExecuteNonQuery();
                    //}
                    string sql = $"DELETE FROM Genre WHERE {Tables.genreColumnID} IS NOT NULL";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                    {
                        foreach (DataColumn c in genreDataTable.Columns)
                            bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);

                        bulkCopy.DestinationTableName = Tables.genreTableName;
                        try
                        {
                            bulkCopy.WriteToServer(genreDataTable);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    MessageBox.Show("data saved successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex);
            }
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            genreManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            genreManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            genreManager.Position = genreManager.Count - 1;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            genreManager.Position = 0;
        }
    }
}
