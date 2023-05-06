namespace loginForm_v2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static bool smschb;
        public static bool reportschb;
        public static bool transactionchb;
        public static string firstname;
        public static string lastname;
        public static string email;

        Home homeForm = new Home();
        
        void getLoginData()
        {
            LoginForm.firstname = txbFirstName.Text.Trim();
            LoginForm.lastname = txbLastName.Text.Trim();
            LoginForm.email = txbEmail.Text.Trim();
            bool checkEmpty = false;
            if (String.IsNullOrEmpty(firstname))
            {
                checkEmpty = true;
                MessageBox.Show("First name is empty!", "Empty textbox");
            }
            else if (String.IsNullOrEmpty(lastname))
            {
                checkEmpty = true;
                MessageBox.Show("Last name is empty!", "Empty textbox");
            }
            else if (String.IsNullOrEmpty(email))
            {
                checkEmpty = true;
                MessageBox.Show("Email name is empty!", "Empty textbox");
            }
            if (checkEmpty == false)
            {
                this.Hide();
                homeForm.Show();
            }

        }

        private void signup(object sender, EventArgs e)
        {
            getLoginData();
        }

        private void chbSMSNotification_CheckedChanged(object sender, EventArgs e)
        {
            lblSMSCharges.Text = (chbSMSNotification.Checked) ? "There fee to be applied" : "....";
            if (chbSMSNotification.Checked) { smschb = true; } else { smschb = false; }
        }

        private void chbReports_CheckedChanged(object sender, EventArgs e)
        {
            lblReportCharges.Text = (chbReports.Checked) ? "Reports charges will apply" : "....";
            if (chbReports.Checked) { reportschb = true; } else { reportschb = false; }
        }

        private void chbTransactionReports_CheckedChanged(object sender, EventArgs e)
        {
            lblTransactionReports.Text = (chbTransactionReports.Checked) ? "Transaction reports fee applied" : "....";
            if (chbTransactionReports.Checked) { transactionchb = true; } else { transactionchb = false; }
        }
    }
}