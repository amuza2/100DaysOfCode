using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public class Save
    {
        public void SaveButton(DataTable dataTable, string columnID, string tableName)
        {
            try
            {
                using (SqlConnection connection = db.Instance.getConnection())
                {
                    string sql = $"DELETE FROM {tableName} WHERE {columnID} IS NOT NULL";
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                    {
                        foreach (DataColumn c in dataTable.Columns)
                            bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);

                        bulkCopy.DestinationTableName = tableName;
                        try
                        {
                            bulkCopy.WriteToServer(dataTable);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    MessageBox.Show("data saved successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex);
            }
        }
    }
}
