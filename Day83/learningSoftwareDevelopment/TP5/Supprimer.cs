using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public class Supprimer
    {
        public void SupprimerButton(Guna2DataGridView dataGridView, DataTable dataTable, Guna2TextBox textboxID)
        {
            if(dataTable.Rows.Count > 0 && !string.IsNullOrEmpty(textboxID.Text.Trim()))
            {
                bool NotFound = true;
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row[Tables.serieColumnID].Equals(textboxID.Text.Trim()))
                    {
                        NotFound = false;
                        row.Delete();
                        dataGridView.DataSource = dataTable;
                        break;
                    }
                }
                if (NotFound) MessageBox.Show($"Value {textboxID.Text.Trim()} doesn't exitst");
            }
        }
    }
}
