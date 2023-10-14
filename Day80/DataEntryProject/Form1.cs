using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEntryProject
{
    public partial class frmDataEntry : Form
    {
        TimeSpan elapsedTime;
        DateTime lastElapsed;
        public frmDataEntry()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZip.Clear();
            txtName.Focus();
        }

        private void timTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime += DateTime.Now - lastElapsed;
            lastElapsed = DateTime.Now;
            txtTimer.Text = new TimeSpan(elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds).ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            timTimer.Enabled = true;
            grbDataEntry.Enabled = true;
            txtName.Focus();
            lastElapsed = DateTime.Now;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            grbDataEntry.Enabled = false;
            timTimer.Enabled = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string dataEntry = "";
            bool isEmpty = false;
            if(txtName.Text.Trim().Equals("") || txtAddress.Text.Trim().Equals("")
                || txtCity.Text.Trim().Equals("") || txtState.Text.Trim().Equals("")
                || txtZip.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please fill all text boxes","Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                isEmpty = true;
                return;
            }
            dataEntry = txtName.Text + "\r\n" + txtAddress.Text + "\r\n"
                + txtCity.Text + "\r\n" + txtState.Text + "\r\n" + txtZip.Text;
            MessageBox.Show(dataEntry, "Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bool isAllDigit = txtZip.Text.All(char.IsDigit);
            if (!isAllDigit && !isEmpty)
            {
                MessageBox.Show("Zip code must be digit only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isEmpty = false;
            }

        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            string textBoxSender = ((GunaTextBox)sender).Name;
            if(e.KeyChar == 13)
            {
                switch (textBoxSender)
                {
                    case "txtName": txtAddress.Focus(); break;
                    case "txtAddress": txtCity.Focus(); break;
                    case "txtCity": txtState.Focus(); break;
                    case "txtState": txtZip.Focus(); break;
                    case "txtZip": btnAccept.Focus(); break;
                }
            }
        }
    }
}
