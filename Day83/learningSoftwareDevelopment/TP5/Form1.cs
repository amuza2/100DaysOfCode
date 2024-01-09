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
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        DataTable genreDataTable;
        CurrencyManager genreManager;
        HelpClass helpClass = new HelpClass();
        


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
                //connection.ConnectionString = db.connectionString;
                command = helpClass.createCommand(connection, Tables.genreTableQuery);
                connection.Open();
                helpClass.getTableFromDataBaseToDataSet(command,db.sharedDataSet, Tables.genreDtName);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
                genreDataTable = helpClass.getTableFromDataSet(db.sharedDataSet, Tables.genreDtName);
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
            genreManager = (CurrencyManager)BindingContext[genreDataTable];
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            helpClass.addButton(DataGridView1, genreDataTable, txbID, txbGenre);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            helpClass.editButton(txbID, txbGenre, DataGridView1, genreDataTable, Tables.genreColumnID, Tables.genreColumnIntitle);
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
            helpClass.deleteButton(genreDataTable, DataGridView1, txbID, txbGenre);
            btnClear_Click(sender, e);
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
