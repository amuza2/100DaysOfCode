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
        public void ajouterEmployer(TextBox nom, TextBox prenom, RadioButton sexe, DateTimePicker born, TextBox fonction)
        {
            string sql = $"INSERT INTO {Tables.Employe} ({Tables.NomEmploye},{Tables.PrenomEmploye},{Tables.SexeEmploye},{Tables.DNaissEmploye},{Tables.FonctionEmploye}) VALUES ('{nom.Text.Trim()}','{prenom.Text.Trim()}','{sexe.Text}','{born.Value.ToShortDateString()}','{fonction.Text.Trim()}')";
            SqlCommand command = new SqlCommand(sql, db.Instance.getConnection());
            command.ExecuteNonQuery();
            db.Instance.disconnect();
            MessageBox.Show("Value added successfully");
        }
    }
}
