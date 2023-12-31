using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseManager
{
    internal class db
    {
		static string connectionString = "Data Source=MED;Initial Catalog=EmployeeDatabase;Integrated Security=True";

        public static SqlConnection connection = new SqlConnection(connectionString);
		public static SqlCommand command = new SqlCommand("", connection);
		public static DataSet dataSet;
		public static SqlDataAdapter dataAdapter;
		public static BindingSource bindingSource;
		public static string sql;

        public static void openConnection()
        {
			try
			{
				if(connection.State == ConnectionState.Closed)
				{
					connection.Open();
                }
			}
			catch (Exception ex)
			{
				MessageBox.Show("Open connection failed: " + ex, "Error connection");
			}
        }
		public static void closeConnection()
		{
			try
			{
				if(connection.State == ConnectionState.Open)
				{
					connection.Close();
                }
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error closing connection: " + ex, "Error connection");
			}
		}
    }
}
