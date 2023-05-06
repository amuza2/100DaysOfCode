using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForm_v2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            loginForm.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblFirstNameHvalue.Text = LoginForm.firstname;
            lblLastNameHvalue.Text = LoginForm.lastname;
            lblEmailHvalue.Text = LoginForm.email;
            lblsmsHvalue.Text = (LoginForm.smschb) ? "✅" : "❌";
            lblreportsH.Text = (LoginForm.reportschb) ? "✅" : "❌";
            lbltransHvalue.Text = (LoginForm.transactionchb) ? "✅" : "❌";
        }
    }
}
