using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    public class db
    {
        string connectionString = "Data Source=localhost;Initial Catalog=imdb;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command = new SqlCommand();
        DataTable dataTable = new DataTable();

        
        
    }
}
