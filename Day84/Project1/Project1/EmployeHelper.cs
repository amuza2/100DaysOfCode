using System;
using System.Collections.Generic;
using System.Data;
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

        public void showEmploye(ComboBox comboBox, TextBox textBox1, TextBox textBox2, TextBox textBox3)
        {
            string sql = $"SELECT {Tables.NumEmploye}, {Tables.NomEmploye}, {Tables.PrenomEmploye}, {Tables.FonctionEmploye} FROM {Tables.Employe}";
            using(SqlCommand command = new SqlCommand(sql, db.Instance.getConnection()))
            {
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    comboBox.DataSource = dataTable;
                    comboBox.DisplayMember = Tables.NumEmploye;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if(comboBox.Text == row[Tables.NumEmploye].ToString())
                        {
                            textBox1.Text = row[Tables.NomEmploye].ToString();
                            textBox2.Text = row[Tables.PrenomEmploye].ToString();
                            textBox3.Text = row[Tables.FonctionEmploye].ToString();
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void searchEmployes(DataGridView dataGridView,TextBox textBox, params Object[] controls)
        {
            if(textBox.Text.Trim().Length > 0)
            {
                string radioButtonValue = "";
                string searchBy = "";
                foreach (RadioButton control in controls)
                {
                    if(control.Checked)
                    {
                        radioButtonValue = control.Text;
                        break;
                    }
                }
                if (!string.IsNullOrEmpty(radioButtonValue))
                {
                    if (radioButtonValue == "Nom") searchBy = Tables.NomEmploye;
                    else if (radioButtonValue == "Prenom") searchBy = Tables.PrenomEmploye;
                    else searchBy = Tables.FonctionEmploye;
                }
                string sql = $"SELECT * FROM {Tables.Employe} WHERE {searchBy} LIKE '{textBox.Text.Trim()}%'";
                using(SqlCommand command = new SqlCommand(sql, db.Instance.getConnection()))
                {
                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView.DataSource = dataTable;
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
}
