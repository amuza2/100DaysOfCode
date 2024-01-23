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
    internal class ProjetHelper
    {
        public void AjouterType(TextBox projetType, TextBox libele, TextBox dureeLength)
        {
            string sql = $"INSERT INTO {Tables.TypeProjet} VALUES (@Data1, @Data2, @Data3)";
            using (SqlCommand cmd = new SqlCommand(sql, db.Instance.getConnection()))
            {
                cmd.Parameters.AddWithValue("@Data1", projetType.Text.Trim());
                cmd.Parameters.AddWithValue("@Data2", libele.Text.Trim());
                cmd.Parameters.AddWithValue("@Data3", dureeLength.Text.Trim());
                try
                {
                    cmd.ExecuteNonQuery();
                    AjouterProjet ajouterProjet = Application.OpenForms["AjouterProjet"] as AjouterProjet;
                    if (ajouterProjet != null)
                    {
                        ajouterProjet.UpdateComboBox();
                    }
                    MessageBox.Show("Projet Type added successfully");
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
        public void ShowProjetTypes(ComboBox comboBox)
        {
            string Sql = $"SELECT {Tables.TypeProjet}, {Tables.LibelleProjet} FROM {Tables.TypeProjet}";
            using (SqlCommand command = new SqlCommand(Sql, db.Instance.getConnection()))
            {
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    comboBox.DataSource = dataTable;
                    comboBox.DisplayMember = Tables.LibelleProjet;
                    comboBox.ValueMember = Tables.TypeProjet;
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
        public void AjouterProjet(TextBox textBox, ComboBox comboBox, DateTimePicker startTime, DateTimePicker endTime)
        {
            string comboValue = comboBox.SelectedValue.ToString();
            string sql = $"INSERT INTO {Tables.Projet} VALUES (@Data1, @Data2, @Data3, @Data4)";
            using (SqlCommand command = new SqlCommand(sql, db.Instance.getConnection()))
            {
                command.Parameters.AddWithValue("@Data1", textBox.Text.Trim());
                command.Parameters.AddWithValue("@Data2", comboValue);
                command.Parameters.AddWithValue("@Data3", startTime.Value);
                command.Parameters.AddWithValue("@Data4", endTime.Value);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Project added successfully");
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
        public void showProjets(ComboBox comboBox, TextBox textBox1, TextBox textBox2)
        {
            string sql = $"SELECT * FROM {Tables.Projet}";
            using(SqlCommand command = new SqlCommand(sql, db.Instance.getConnection()))
            {
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    comboBox.DataSource = dataTable;
                    comboBox.DisplayMember = Tables.CodeProjet;
                    comboBox.ValueMember = Tables.TypeProjet;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if(comboBox.Text.ToString() == row[Tables.CodeProjet].ToString())
                        {
                            textBox1.Text = row[Tables.DateDebut].ToString();
                            textBox2.Text = row[Tables.DateFin].ToString();
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

    }
}
