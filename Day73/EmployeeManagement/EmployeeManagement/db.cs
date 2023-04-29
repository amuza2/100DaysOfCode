using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace EmployeeManagement
{
    internal class db
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-PPTJTSB;Initial Catalog=EmployeesDatabase;Integrated Security=True");

        public static SqlCommand cmd = new SqlCommand("", con);
        public static DataSet ds;
        public static SqlDataAdapter da;
        public static BindingSource bc;
        public static string sql;

        public static void openConnection()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    //MessageBox.Show("The connection is: " + con.State.ToString());
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open Connection failed " + ex.Message, "Error!");
            }
        }

        public static void closeConnection()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    //MessageBox.Show("The connection is: " + con.State.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Close Connection failed " + ex.Message, "Error!");
            }
        }

    }
}
