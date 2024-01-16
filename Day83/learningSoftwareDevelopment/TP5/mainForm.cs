using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public partial class mainForm : Form
    {
        DataTable serieDataTable = new DataTable(Tables.serieDtName);
        DataTable genreDataTable = new DataTable(Tables.genreDtName);
        HelpClass helperClass = new HelpClass();
        public mainForm()
        {
            InitializeComponent();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helperClass.GoToGenreForm();
        }

        private void serieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helperClass.GoToSerieForm();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            using(SqlConnection connection = db.Instance.getConnection())
            {
                db.Adapter.SelectCommand = new SqlCommand(Tables.genreTableQuery, connection);
                db.Adapter.Fill(genreDataTable);

                db.Adapter.SelectCommand= new SqlCommand(Tables.serieTableQuery, connection);
                db.Adapter.Fill(serieDataTable);
            }
            db.sharedDataSet.Tables.Add(genreDataTable);
            db.sharedDataSet.Tables.Add(serieDataTable);
        }

        private void ShortCuts(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.G)
            {
                helperClass.GoToGenreForm();
            }
            else if(e.Control && e.KeyCode == Keys.S)
            {
                helperClass.GoToSerieForm();
            }
        }
    }
}
