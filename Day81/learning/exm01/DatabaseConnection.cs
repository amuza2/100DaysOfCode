using Guna.UI2.HtmlRenderer.Adapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace exm01
{
    internal class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private SqlConnection _connection;
        public DataSet dataSet = new DataSet();

        private DatabaseConnection()
        {
            _connection = new SqlConnection();
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (_instance == null) _instance = new DatabaseConnection();
                return _instance;
            }
        }
        public string CheckConnection() => _connection.State.ToString();
        public SqlConnection GetConnection(string connectionString = "")
        {
            if(!string.IsNullOrEmpty(connectionString)) _connection.ConnectionString = connectionString;
            if (_connection.State == ConnectionState.Closed) _connection.Open();
            return _connection;
        }
        public void Disconnecting()
        {
            if (_instance != null && _instance._connection.State == ConnectionState.Open)
                _instance._connection.Close();
        }
        public SqlCommand CreateCommand(string sqlCommand)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sqlCommand, connection);
            return command;
        }
        public DataSet fillAdapterToDataSet(SqlCommand sqlCommand, string dsTableName)
        {
            using(SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
            {
                adapter.Fill(dataSet, dsTableName);
                return dataSet;
            }
        }
        public DataSet GetDataSet()
        {
            return dataSet;
        }
        public DataTable addDataSetTable(DataSet _dataset, string tableName)
        {
            return _dataset.Tables.Add(tableName);
        }
        public void SaveDataSet(DataSet dataSet, SqlDataAdapter adapter, string tableName)
        {
            if (adapter == null)
            {
                throw new InvalidOperationException("Data adapter is not initialized. Cannot save dataset.");
            }
            SqlCommandBuilder eng = new SqlCommandBuilder(adapter);
            adapter.Update(dataSet, tableName);
        }
        //public int ExecuteNonQuery(SqlCommand command)
        //{
        //    return command.ExecuteNonQuery();
        //}

        //public DataTable getDataTable(DataSet dataSet, string table)
        //{
        //    DataTable dataTable = dataSet.Tables[table];
        //    return dataTable;
        //}

    }
}
