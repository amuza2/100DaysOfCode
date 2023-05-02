using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            db.openConnection();
            updateDataBiding();
            
        }

        private void updateDataBiding(SqlCommand command = null, Button btn = null)
        {
            try
            {
                TextBox txt; ComboBox cmb; RadioButton rdn;

                foreach (Control control in groupBox1.Controls)
                {
                    if (control.GetType() == typeof(TextBox))
                    {
                        txt = (TextBox)control;
                        txt.DataBindings.Clear();
                        txt.Text = "";
                    }else if (control.GetType() == typeof(ComboBox))
                    {
                        cmb = (ComboBox)control;
                        cmb.DataBindings.Clear();
                        cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }

                foreach (Control control in groupBox3.Controls)
                {
                    if (control.GetType() == typeof(RadioButton))
                    {
                        rdn = (RadioButton)control;
                        if (btn == null)
                        {
                            rdn.Checked = false;
                        }
                    }
                    else if (control.GetType() == typeof(ComboBox))
                    {
                        cmb = (ComboBox)control;
                        cmb.DataBindings.Clear();
                        cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }

                if (command == null)
                {
                    db.cmd.CommandText = "SELECT Employees.*, Departments.DepartmentName FROM Employees INNER JOIN Departments ON Employees.DepartmentID = " +
                        "Departments.DepartmentID ORDER BY Employees.AutoID";
                }
                else
                {
                    db.cmd = command;
                }
                db.da = new SqlDataAdapter(db.cmd);
                db.ds = new DataSet();
                db.da.Fill(db.ds, "EmployeeList");
                db.bs = new BindingSource(db.ds, "EmployeeList");
                bindingNavigator1.BindingSource = db.bs;
                // Sample Data Bindings
                IDtextBox.DataBindings.Add("Text", db.bs, "AutoID");
                FirstNametextBox.DataBindings.Add("Text", db.bs, "FirstName");
                LastNametextBox.DataBindings.Add("Text", db.bs, "LastName");
                EmailtextBox.DataBindings.Add("Text", db.bs, "Email");
                JobTitletextBox.DataBindings.Add("Text", db.bs, "JobTitle");
                PhonetextBox.DataBindings.Add("Text", db.bs, "Phone");

                dataGridView1.Enabled = true;
                dataGridView1.DataSource = db.bs;
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Data Binding Error: " + ex.Message);
            }
            finally
            {
                if (SearchtextBox.CanSelect)
                {
                    SearchtextBox.Select();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.closeConnection();
        }
    }
}
