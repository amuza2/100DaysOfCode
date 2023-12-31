using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void form_Load(object sender, EventArgs e)
        {
            db.openConnection();
            updateDataBinding();
        }

        private void updateDataBinding(SqlCommand command = null, Guna2Button btn = null)
        {
            try
            {
                Guna2TextBox txt;
                Guna2ComboBox comboBox;
                Guna2RadioButton radioButton;

                foreach (Control c in cmbDivision.Controls)
                {
                    if(c.GetType() == typeof(Guna2TextBox))
                    {
                        txt = (Guna2TextBox)c;
                        txt.DataBindings.Clear();
                        txt.Clear();
                    }
                    else if(c.GetType() == typeof(Guna2ComboBox))
                    {
                        comboBox = (Guna2ComboBox)c;
                        comboBox.DataBindings.Clear();
                        comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }

                foreach (var c in guna2GroupBox3.Controls)
                {
                    if (c.GetType() == typeof(Guna2RadioButton))
                    {
                        radioButton = (Guna2RadioButton)c;
                        if(btn == null) radioButton.Checked = false;
                        
                    }
                    else if (c.GetType() == typeof(Guna2ComboBox))
                    {
                        comboBox = (Guna2ComboBox)c;
                        comboBox.DataBindings.Clear();
                        comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }
                if (command == null)
                {
                    db.command.CommandText = "SELECT Employees.*, Departments.DepartmentName " +
                        "FROM Employees INNER JOIN Departments ON Departments.DepartmentID = Employees.DepartmentID " +
                        "ORDER BY Employees.AutoID ASC";

                }
                else db.command = command;

                db.dataAdapter = new SqlDataAdapter(db.command);
                db.dataSet = new DataSet();
                db.dataAdapter.Fill(db.dataSet, "EmployeeList");
                db.bindingSource = new BindingSource(db.dataSet, "EmployeeList");
                bindingNavigator1.BindingSource = db.bindingSource;

                // textbox data binding
                txbID.DataBindings.Add("Text",db.bindingSource ,"AutoID");
                txbFirstName.DataBindings.Add("Text", db.bindingSource, "FirstName");
                txbLastName.DataBindings.Add("Text", db.bindingSource, "LastName");
                txbEmail.DataBindings.Add("Text", db.bindingSource, "Email");
                txbJobTitle.DataBindings.Add("Text", db.bindingSource, "JobTitle");
                txbPhone.DataBindings.Add("Text", db.bindingSource, "Phone");

                guna2DataGridView1.Enabled = true;
                guna2DataGridView1.DataSource = db.bindingSource;
                guna2DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                guna2DataGridView1.AutoResizeColumnHeadersHeight();

                // Combobox data binding
                db.command.CommandText = "SELECT DepartmentID, DepartmentName FROM Departments ORDER BY DepartmentID ASC";
                db.dataAdapter.SelectCommand = db.command;
                db.dataAdapter.Fill(db.dataSet, "Devision");
                cmbDivision.DataSource = db.dataSet.Tables["Devision"];
                cmbDivision.DisplayMember = "DepartmentName";
                cmbDivision.ValueMember = "DepartmentID";
                cmbDivision.DataBindings.Add("SelectedValue", db.bindingSource, "DepartmentID");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data binding error: " + ex, "Error");
            }
            finally
            {
                if(txbSearch.CanSelect) txbSearch.Select();
            }
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            db.closeConnection();
        }
    }
}
