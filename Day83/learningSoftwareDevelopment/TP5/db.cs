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
        private static db _instance = null;
        public static DataSet sharedDataSet = new DataSet();
        private static readonly object _instanceLock = new object();
        private SqlConnection _connection;
        public static SqlDataAdapter Adapter = new SqlDataAdapter();
        public static SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();
        private db()
        {
            _connection = new SqlConnection();
        }
        public static db Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if(_instance == null)
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
            if (!string.IsNullOrEmpty(connectionString)) _connection.ConnectionString = connectionString;
            if(_connection.State == ConnectionState.Closed) _connection.Open();
            return _connection;
        }
        public void disconnect()
        {
            if(_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
        public static ConnectionState CheckConnection()
        {
            return Instance._connection.State;
        }

    }
}
