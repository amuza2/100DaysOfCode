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

        public void showInscribedEmployesToAProjet(int itemIndex, DataGridView dataGridView)
        {
            // P.{Tables.NumEmploye}, P.{Tables.NomEmploye}, P.{Tables.PrenomEmploye}, P.{Tables.SexeEmploye}, P.{Tables.DNaissEmploye}, P.{Tables.FonctionEmploye}
            string sql = $"SELECT {Tables.NomEmploye}, {Tables.PrenomEmploye}, {Tables.SexeEmploye}, {Tables.DNaissEmploye}, {Tables.FonctionEmploye} FROM {Tables.Projet} P, {Tables.Inscription} I, {Tables.Employe} E " +
                $"WHERE P.{Tables.CodeProjet} = I.{Tables.CodeProjet} and I.{Tables.NumEmploye} = E.{Tables.NumEmploye} and P.{Tables.CodeProjet} = {itemIndex}";
            using(SqlCommand command = new SqlCommand (sql, db.Instance.getConnection()))
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
