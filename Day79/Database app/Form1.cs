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

namespace Database_app
{
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        OleDbCommand titlesQuery;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Books.accdb;Persist Security Info=False;";
            conn = new OleDbConnection(connString);
            conn.Open();
            titlesQuery = new OleDbCommand("SELECT * FROM Titles", conn);
            conn.Close();
            conn.Dispose();


        }
    }
}
