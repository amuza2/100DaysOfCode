using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    internal class EmployeHelper
    {
        public void ajouterEmployer(TextBox id,TextBox nom, TextBox prenom, RadioButton sexe, DateTimePicker born, TextBox fonction)
        { 
            string sql = $"INSERT INTO {Tables.Employe} VALUES (@Data1, @Data2, @Data3, @Data4, @Data5, @Data6)";
            using (SqlCommand command = new SqlCommand(sql, db.Instance.getConnection()))
            {
                command.Parameters.AddWithValue("@Data1", id.Text.Trim());
                command.Parameters.AddWithValue("@Data2", nom.Text.Trim());
                command.Parameters.AddWithValue("@Data3", prenom.Text.Trim());
                command.Parameters.AddWithValue("@Data4", sexe.Text);
                command.Parameters.AddWithValue("@Data5", born.Value.ToString("d/M/yyyy"));
                command.Parameters.AddWithValue("@Data6", fonction.Text.Trim());

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
