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
        DataTable serieDataTable;
        DataTable genreDataTable;
        SqlDataAdapter SqlDataAdapter;
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

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            helperClass.addButton(SerieDataGridView, serieDataTable, txbSerieCode, txbTitleSerie, dtpReleaseDate, cmbGenre);
        }
    }
}
