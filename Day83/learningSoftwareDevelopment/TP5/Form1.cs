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
        CurrencyManager genreManager;
        HelpClass helpClass = new HelpClass();
        private string genreColumnID = "codeGenre";
        private string genreColumnIntitle = "inttitleGenre";


        public Form1()
        {
            InitializeComponent();
            connection = db.getInstance();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
        public void GetGenreDataFromDataBaseTable()
        {
            try
            {
                connection.ConnectionString =connectionString;
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
            txbID.DataBindings.Add("text", genreDataTable, genreColumnID);
            txbGenre.DataBindings.Add("text", genreDataTable, genreColumnIntitle);
            genreManager = (CurrencyManager)BindingContext[genreDataTable];
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            helpClass.addButton(txbID, txbGenre, DataGridView1, genreDataTable, genreColumnID, genreColumnIntitle);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            helpClass.editButton(txbID, txbGenre, DataGridView1, genreDataTable, genreColumnID, genreColumnIntitle);
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
