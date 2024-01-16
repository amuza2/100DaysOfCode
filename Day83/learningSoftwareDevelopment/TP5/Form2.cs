using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public partial class Form2 : Form
    {
        HelpClass helperClass = new HelpClass();
        Modify modify = new Modify();
        DataTable serieDataTable;
        DataTable genreDataTable;
        CurrencyManager serieyManager;
        Save save = new Save();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            serieDataTable = db.sharedDataSet.Tables[Tables.serieDtName];
            genreDataTable = db.sharedDataSet.Tables[Tables.genreDtName];
            SerieDataGridView.DataSource = serieDataTable;
            helperClass.comboBoxFilter(genreDataTable, cmbGenre, Tables.genreColumnIntitle, Tables.genreColumnID);
            serieyManager = (CurrencyManager)BindingContext[serieDataTable];

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            helperClass.addButton(SerieDataGridView, serieDataTable, txbSerieCode, txbTitleSerie, dtpReleaseDate, cmbGenre);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            modify.ModifyButton(txbSerieCode, txbTitleSerie, dtpReleaseDate, cmbGenre, SerieDataGridView, serieDataTable);
        }

        private void btnNext_click(object sender, EventArgs e)
        {
            serieyManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            serieyManager.Position = serieyManager.Count - 1;
        }

        private void btnPrivious_Click(object sender, EventArgs e)
        {
            serieyManager.Position--;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            serieyManager.Position = 0;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            helperClass.deleteButton(serieDataTable, SerieDataGridView, txbSerieCode,Tables.serieColumnID);
            helperClass.clearTextBox(txbSerieCode, txbTitleSerie, dtpReleaseDate, cmbGenre);
        }

        private void cellClick_SerieForm(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < serieDataTable.Rows.Count)
            {
                DataGridViewRow selectedRow = SerieDataGridView.Rows[e.RowIndex];
                txbSerieCode.Text = selectedRow.Cells[Tables.serieColumnID].Value.ToString();
                txbTitleSerie.Text = selectedRow.Cells[Tables.serieTitle].Value.ToString();
                dtpReleaseDate.Value = (DateTime)selectedRow.Cells[Tables.serieDate].Value;
                int selectedCode = (int)selectedRow.Cells[Tables.genreColumnID].Value;
                string genreName = helperClass.GetCodeFromTitle(selectedCode, Tables.genreColumnIntitle, Tables.genreTableName, Tables.genreColumnID);
                cmbGenre.Text = genreName;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save.SaveButton(serieDataTable, Tables.serieColumnID, Tables.serieTableName);
        }
    }
}
