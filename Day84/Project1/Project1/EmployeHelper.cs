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

        public void showEmployesToEdit(ComboBox comboBox, TextBox textBox1, TextBox textBox2, RadioButton radioButton1, RadioButton radioButton2, DateTimePicker dateTimePicker, TextBox textBox3)
        {
            string sql = $"SELECT * FROM {Tables.Employe}";
            using( SqlCommand command = new SqlCommand(sql,db.Instance.getConnection()))
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
                            if (row[Tables.SexeEmploye].ToString().Trim() == "Masculin")
                            {
                                radioButton1.Checked = true;
                                radioButton2.Checked = false;
                            }
                            else
                            {
                                radioButton1.Checked = false;
                                radioButton2.Checked = true;
                            }
                            dateTimePicker.Value = (DateTime)row[Tables.DNaissEmploye];
                            textBox3.Text = row[Tables.FonctionEmploye].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void modifyEmploye(ComboBox comboBox, TextBox textBox1, TextBox textBox2, RadioButton radioButton1, RadioButton radioButton2, DateTimePicker dateTimePicker, TextBox textBox3)
        {
            string sql = $"UPDATE {Tables.Employe} SET " +
                $"{Tables.NomEmploye} = @Data1, " +
                $"{Tables.PrenomEmploye} = @Data2, " +
                $"{Tables.SexeEmploye} = @Data3, " +
                $"{Tables.DNaissEmploye} = @Data4, " +
                $"{Tables.FonctionEmploye} = @Data5 " +
                $"WHERE {Tables.NumEmploye} = @Data6";
            using(SqlCommand command = new SqlCommand(sql, db.Instance.getConnection()))
            {
                command.Parameters.AddWithValue("@Data1", textBox1.Text.Trim());
                command.Parameters.AddWithValue("@Data2", textBox2.Text.Trim());
                RadioButton selectedRadio;
                if (radioButton1.Checked) selectedRadio = radioButton1;
                else selectedRadio = radioButton2;
                command.Parameters.AddWithValue("@Data3", selectedRadio.Text.Trim());
                command.Parameters.AddWithValue("@Data4", dateTimePicker.Value);
                command.Parameters.AddWithValue("@Data5", textBox3.Text.Trim());
                command.Parameters.AddWithValue("@Data6", comboBox.Text.Trim());
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Values modified Successfully");
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
