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
        SqlConnection connection;
        SqlCommand command;
        HelpClass helperClass = new HelpClass();
        DataTable serieDataTable;
        SqlDataAdapter SqlDataAdapter;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            getSerieTableFromDataBase();
            SerieDataGridView.DataSource = serieDataTable; ;
        }
        public void getSerieTableFromDataBase()
        {
            try
            {
                using(connection = db.getInstance())
                {
                    command = helperClass.createCommand(connection, Tables.serieTableQuery);
                    connection.Open();
                    //SqlDataReader myReader = command.ExecuteReader();
                    //serieDataTable.Load(myReader);
                    helperClass.getTableFromDataBaseToDataSet(command, db.sharedDataSet, Tables.serieDtName);
                    //SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(SqlDataAdapter);
                    serieDataTable = helperClass.getTableFromDataSet(db.sharedDataSet, Tables.serieDtName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
