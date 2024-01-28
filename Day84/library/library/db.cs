using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class db
    {
        private static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\moham\\Documents\\github\\100DaysOfCode\\Day84\\library\\library\\Database1.mdf;Integrated Security=True";
        private static db _instance = null;
        private static readonly object _instanceLock = new object();
        private SqlConnection _connection;
        private db()
        {
            _connection = new SqlConnection();
        }
        public static db Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new db();
                        }
                    }
                }
                return _instance;
            }
        }
        public SqlConnection getConnection()
        {
            if (!string.IsNullOrEmpty(connectionString) && _connection.State == ConnectionState.Closed) _connection.ConnectionString = connectionString;
            if (_connection.State == ConnectionState.Closed) _connection.Open();
            return _connection;
        }
        public void disconnect()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
