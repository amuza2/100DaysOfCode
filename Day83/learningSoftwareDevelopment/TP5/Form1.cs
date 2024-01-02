using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=imdb;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command = new SqlCommand();
        SqlDataAdapter dataAdapter;
        DataSet dataSet = new DataSet();
        DataTable genreDataTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
        public void GetGenreDataFromDataBaseTable()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                command.CommandText = "SELECT * FROM Genre";
                command.Connection = connection;
                connection.Open();
                dataAdapter = new SqlDataAdapter(command);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dataSet, "dtGenre");
                genreDataTable = dataSet.Tables["dtGenre"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during tabales initialisation: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetGenreDataFromDataBaseTable();
            DataGridView1.DataSource = genreDataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                try
                {
                    DataRow newRow = genreDataTable.NewRow();
                    newRow["codeGenre"] = txbID.Text.Trim();
                    newRow["inttitleGenre"] = txbGenre.Text.Trim();
                    genreDataTable.Rows.Add(newRow);
                    DataGridView1.DataSource = genreDataTable;
                    MessageBox.Show("data added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex, "Error");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private bool isValid()
        {
            bool isValidated = false;
            if (string.IsNullOrEmpty(txbGenre.Text.Trim()))
                MessageBox.Show("Please add value to the empty field", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else isValidated = true;
                    
            return isValidated;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(genreDataTable.Rows.Count > 0 && !string.IsNullOrEmpty(txbID.Text))
            {
                string txtID = txbID.Text.Trim();
                int counter = 0;
                foreach (DataRow row in genreDataTable.Rows)
                {
                    if (row["codeGenre"].Equals(int.Parse(txtID)))
                    {
                        genreDataTable.Rows[counter]["inttitleGenre"] = txbGenre.Text.Trim();
                        DataGridView1.DataSource = genreDataTable;
                        break;
                    }
                    counter++;
                }
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < genreDataTable.Rows.Count)
            {
                DataGridViewRow selectedRow = DataGridView1.Rows[e.RowIndex];
                txbID.Text = selectedRow.Cells["codeGenre"].Value.ToString();
                txbGenre.Text = selectedRow.Cells["inttitleGenre"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbGenre.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(genreDataTable.Rows.Count > 0)
            {
                foreach (DataRow row in genreDataTable.Rows)
                {
                    if (row["codeGenre"].Equals(int.Parse(txbID.Text.Trim())))
                    {
                        int selectedIndex = DataGridView1.SelectedRows[0].Index;
                        genreDataTable.Rows.RemoveAt(selectedIndex);
                        DataGridView1.DataSource = genreDataTable;
                        btnClear_Click(sender, e);
                        break;

                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(dataAdapter != null)
            {
                dataAdapter.Update(genreDataTable);
            }
        }
    }
}
