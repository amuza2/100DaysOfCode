using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency
{
    public partial class frmTitles : Form
    {
        OleDbConnection connection;
        
        public frmTitles()
        {
            InitializeComponent();
        }

        private void frmTitles_Load(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Books.accdb";
            
            connection = new OleDbConnection(connectionString);
            connection.Open();
            txtConnection.Text = connection.State.ToString();
            connection.Close();

        }
    }
}
