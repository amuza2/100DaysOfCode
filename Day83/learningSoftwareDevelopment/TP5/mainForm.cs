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
        HelpClass helperClass = new HelpClass();
        DataTable serieDataTable = new DataTable(Tables.serieDtName);
        DataTable genreDataTable = new DataTable(Tables.genreDtName);
        public mainForm()
        {
            InitializeComponent();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 genreForm = new Form1();
            genreForm.Show();
        }

        private void serieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 serieForm = new Form2();
            serieForm.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            db.Adapter.SelectCommand = helperClass.createCommand(db.Instance.getConnection(), Tables.genreTableQuery);
            db.sqlCommandBuilder.DataAdapter = db.Adapter;
            db.sqlCommandBuilder.ConflictOption = ConflictOption.OverwriteChanges;
            helperClass.getTableFromDataBaseToDataTable(genreDataTable);
            db.Instance.disconnect();
            //command = helperClass.addcommand(Tables.serieTableQuery);
            //helperClass.getTableFromDataBaseToDataTable(serieDataTable);

            db.sharedDataSet.Tables.Add(genreDataTable); 
            //db.sharedDataSet.Tables.Add(serieDataTable);
        }
    }
}
