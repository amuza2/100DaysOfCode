﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace exm01
{
    public partial class fmFilm : Form
    {
        private DataSet dataSet;
        private DataTable dataTableFilm;
        private DataTable dataTableRealisator;
        HelperClass helperClass = new HelperClass();
        public fmFilm()
        {
            InitializeComponent();
        }

        private void fmFilm_Load_1(object sender, EventArgs e)
        {
            dataSet = DatabaseConnection.Instance.dataSet;
            dataTableRealisator = dataSet.Tables[ColumnNames.dsRealisator];
            dataTableFilm = dataSet.Tables[ColumnNames.dsFilm];
            dgvFilm.DataSource = dataTableFilm;
            dgvFilm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            helperClass.comboFiller(cbxfilm, dataTableRealisator, ColumnNames.realisatorNameCol, ColumnNames.idRealisatorCol);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            helperClass.addButton(txbId, txbTitle,txbLength,dtpDate, cbxfilm, dataTableFilm, dgvFilm, errorProvider2);
        }

        private void txbId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            helperClass.allowIntOnly(e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            helperClass.clearButton(txbId, txbTitle, txbLength, dtpDate, cbxfilm, dataTableFilm, dgvFilm);
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            helperClass.dataGridViewCellClick(sender, e, txbId, txbTitle, txbLength, dtpDate, cbxfilm, dgvFilm);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            helperClass.editButton(txbId, txbTitle, txbLength, dtpDate, cbxfilm, dataTableFilm, dgvFilm, ColumnNames.idFilmCol, ColumnNames.titleFilmCol, ColumnNames.lengthFilmCol, ColumnNames.releasedDateCol, ColumnNames.realisatorNameCol);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            helperClass.deleteButton(txbId, txbTitle, txbLength, dtpDate, cbxfilm, dgvFilm, dataTableFilm);
        }
    }
}
