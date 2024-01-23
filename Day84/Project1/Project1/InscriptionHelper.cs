using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    internal class InscriptionHelper
    {
        public void AjouterInscription(ComboBox comboBox1, ComboBox comboBox2, DateTimePicker dateTimePicker)
        {
            string sql = $"INSERT INTO {Tables.Inscription} VALUES (@Data1, @Data2, @Data3)";
            using(SqlCommand command = new SqlCommand(sql, db.Instance.getConnection()))
            {
                command.Parameters.AddWithValue("@Data1", comboBox1.Text.Trim());
                command.Parameters.AddWithValue("@Data2", comboBox2.Text.Trim());
                command.Parameters.AddWithValue("@Data3", dateTimePicker.Value);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Value added successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    db.Instance.disconnect();
                }
            }
        }
    }
}
