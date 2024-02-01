using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace library
{
    internal class HelperClass
    {
        public void AjouterLivre(TextBox titre, TextBox auteur, TextBox nbExamplaires, ComboBox theme)
        {
            string sql = $"INSERT INTO {Tables.Livre} VALUES (@Titre, @Auteur, @NbExamplainres, @Theme)";
            using (SqlCommand command = new SqlCommand(sql, db.Instance.getConnection()))
            {
                command.Parameters.AddWithValue("@Titre", titre.Text.Trim());
                command.Parameters.AddWithValue("@Auteur", auteur.Text.Trim());
                command.Parameters.AddWithValue("@NbExamplainres", nbExamplaires.Text.Trim());
                command.Parameters.AddWithValue("@Theme", theme.SelectedValue);

                try
                {
                    if(CheckNotEmptyControls(titre, auteur, nbExamplaires, theme))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Livre ajouter avec success");
                        ClearControls(titre, auteur, nbExamplaires);
                    }
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
        public void AjouterTheme(TextBox nomTheme)
        {
            string sql = $"INSERT INTO {Tables.Theme} VALUES (@themeName)";
            using(SqlCommand command = new SqlCommand(sql, db.Instance.getConnection()))
            {
                command.Parameters.AddWithValue("@themeName", nomTheme.Text.Trim());
                try
                {
                    command.ExecuteNonQuery();
                    AjouterLivre ajouterLivre = Application.OpenForms["AjouterLivre"] as AjouterLivre;
                    if (ajouterLivre != null)
                    {
                        ajouterLivre.UpdateThemesComboBox();
                    }
                    MessageBox.Show("Theme ajouter avec success");
                    nomTheme.Clear();
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
        public void ShowThemes(ComboBox comboBox)
        {
            string sql = $"SELECT * FROM {Tables.Theme}";
            using (SqlCommand command = new SqlCommand(sql, db.Instance.getConnection()))
            {
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    comboBox.DataSource = dataTable;
                    comboBox.DisplayMember = Tables.ThemeName;
                    comboBox.ValueMember = Tables.CodeTheme;
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
        public bool CheckNotEmptyControls(TextBox textBox1, TextBox textBox2, TextBox textBox3, ComboBox comboBox)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(comboBox.Text))
            {
                MessageBox.Show("Please Fill all controls");
                return false;
            }
            return true;
        }
        public void ClearControls(TextBox textBox1, TextBox textBox2, TextBox textBox3)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        public void ListOfBooks(DataGridView dataGridView)
        {
            string sql = $"SELECT * FROM {Tables.Livre}";
            using (SqlCommand command = new SqlCommand(sql, db.Instance.getConnection()))
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
        public void ChercherParCode(TextBox searchTextBox, DataGridView dataGridView, RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3)
        {
            string sql = "";
            if (!string.IsNullOrEmpty(searchTextBox.Text.Trim()))
            {
                if(radioButton1.Checked)
                {
                    sql = $"SELECT * FROM {Tables.Livre} WHERE {Tables.CodeLivre} LIKE {searchTextBox.Text.Trim()}";
                }
                else if (radioButton2.Checked)
                {
                    sql = $"SELECT * FROM {Tables.Livre} WHERE {Tables.TitreLivre} LIKE '{searchTextBox.Text.Trim()}%'";
                }
                else
                {
                    sql = $"SELECT * FROM {Tables.Livre} WHERE {Tables.AuteurLivre} LIKE '%{searchTextBox.Text.Trim()}%'";
                }
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
        public void showLivre(TextBox code, TextBox title, TextBox auteur, TextBox nb, TextBox theme, int rowIndex)
        {
            string sql = $"SELECT * FROM {Tables.Livre}";
            using (SqlCommand command = new SqlCommand(sql, db.Instance.getConnection()))
            {
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (rowIndex == int.Parse(row[Tables.CodeLivre].ToString()))
                        {
                            code.Text = row[Tables.CodeLivre].ToString();
                            title.Text = row[Tables.TitreLivre].ToString();
                            auteur.Text = row[Tables.AuteurLivre].ToString();
                            nb.Text = row[Tables.NbExamplaires].ToString();
                            theme.Text = row[Tables.CodeTheme].ToString();
                        }
                    }
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
        public void showStudent(DataGridView dataGridView)
        {
            string sql = $"SELECT * FROM {Tables.Adherent}";
            using (SqlCommand command = new SqlCommand(sql, db.Instance.getConnection()))
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
        public void AjouterEtudient(TextBox textBox1, TextBox textBox2)
        {
            string sql = $"INSERT INTO {Tables.Adherent} VALUES (@nom, @address, @date1)";
            using(SqlCommand command = new SqlCommand(sql, db.Instance.getConnection()))
            {
                command.Parameters.AddWithValue("@nom", textBox1.Text.Trim());
                command.Parameters.AddWithValue("@address", textBox2.Text.Trim());
                command.Parameters.AddWithValue("@date1", DateTime.Now);
                try
                {
                    command.ExecuteNonQuery();
                    EmpruntLivre empruntLivre = Application.OpenForms["EmpruntLivre"] as EmpruntLivre;
                    if(empruntLivre != null )
                    {
                        empruntLivre.ShowStudentGrid();
                    }
                    MessageBox.Show("Etudient ajouter ave success");
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
        public void AjouterEmprunt(TextBox textBox, DataGridView dataGridView, DateTimePicker dateTimePicker)
        {
            string studentCode = "";
            if (dataGridView.SelectedRows != null && dataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView.Rows[0];
                studentCode = row.Cells[Tables.CodeAdherent].Value.ToString();
            }
            if(!string.IsNullOrEmpty(studentCode))
            {
                try
                {
                    int availableBooks = 0;
                    int livreCode = int.Parse(textBox.Text.Trim());
                    SqlConnection connection = db.Instance.getConnection();

                    string availableBooksQuery = $"SELECT {Tables.NbExamplaires} FROM {Tables.Livre} WHERE {Tables.CodeLivre} = @bookCode";
                    using (SqlCommand command = new SqlCommand(availableBooksQuery, connection))
                    {
                        command.Parameters.AddWithValue("@bookCode", livreCode);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read()) availableBooks = int.Parse(reader.GetString(0));
                        reader.Close();
                    }

                    string sql = $"INSERT INTO {Tables.Emprunt} VALUES (@Data1, @Data2, @Data3, @Data4)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        if (availableBooks > 0)
                        {
                            DateTime returnDate = dateTimePicker.Value;
                            command.Parameters.AddWithValue("@Data1", studentCode);
                            command.Parameters.AddWithValue("@Data2", livreCode);
                            command.Parameters.AddWithValue("@Data3", DateTime.Now);
                            command.Parameters.AddWithValue("@Data4", returnDate);
                            command.ExecuteNonQuery();

                            string decreaseNbBook = $"UPDATE {Tables.Livre} SET {Tables.NbExamplaires} = {--availableBooks} WHERE {Tables.CodeLivre} = {livreCode}";
                            command.CommandText = decreaseNbBook;
                            command.ExecuteNonQuery();
                            MessageBox.Show("Emprunt ajouter avec success");
                        }
                        else MessageBox.Show("Tout les livre sont emprunter");
                    }
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
