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
        Modify modigy = new Modify();
        Save save = new Save();
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
            modigy.ModifyButton(txbID, txbGenre, DataGridView1, genreDataTable);
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
            helpClass.deleteButton(genreDataTable, DataGridView1, txbID, Tables.genreColumnID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save.SaveButton(genreDataTable, Tables.genreColumnID, Tables.genreTableName);
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
