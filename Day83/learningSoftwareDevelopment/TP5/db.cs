using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public sealed class db
    {
        private static readonly string connectionString = "Data Source=localhost;Initial Catalog=imdb;Integrated Security=True";
        private static SqlConnection _instance = null;
        public static DataSet sharedDataSet = new DataSet();
        private static readonly object _instanceLock = new object();
        SqlConnection connection;
        SqlCommand command = new SqlCommand();
        DataTable dataTable = new DataTable();


        public static SqlConnection getInstance()
        {
            if(_instance == null)
            {
                lock (_instanceLock)
                {
                    if(_instance == null)
                    {
                        _instance = new SqlConnection(connectionString);
                    }
                }
            }
            return _instance;
        }

        
        
    }
}
