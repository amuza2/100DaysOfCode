using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace learningDelegateAndEvent
{
    public partial class Form1 : Form
    {
        TimeSpan elapsedTime;
        DateTime lastTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string address = tbAddress.Text;
            string city = tbCity.Text;
            string state = tbState.Text;
            string zip = tbZip.Text;
            MessageBox.Show($"{name}\n{address}\n{city}\n{state}\n{zip}", "Information");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbAddress.Clear();
            tbCity.Clear();
            tbState.Clear();
            tbZip.Clear();
            tbName.Focus();
        }
        // Allow only digits in zip code
        private void CheckDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            timerTimer.Enabled = true;
            lastTime = DateTime.Now;
            gbDataEntry.Enabled = true;
            tbName.Focus();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            timerTimer.Enabled = false;
            gbDataEntry.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTime += DateTime.Now - lastTime;
            lastTime = DateTime.Now;
            //string timerFormat = new TimeSpan(elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds).ToString();
            tbTimer.Text = elapsedTime.ToString(@"hh\:mm\:ss");

        }

        private void ShortcutKeyPress_Click(object sender, KeyPressEventArgs e)
        {
            //if ((ModifierKeys && Keys.Alt) == Keys.Alt)
            //    btnAccept.PerformClick();

            //go to net textbox when ok (Carriage Return) is pressed
            
        }

        private void goNextToTextBoxShortcut_Enter(object sender, KeyPressEventArgs e)
        {
            string textBoxSender = ((TextBox)sender).Name;
            if (e.KeyChar == 13)
            {
                switch (textBoxSender)
                {
                    case "tbName": tbAddress.Focus(); break;
                    case "tbAddress": tbCity.Focus(); break;
                    case "tbCity": tbState.Focus(); break;
                    case "tbState": tbZip.Focus(); break;
                    case "tbZip": btnAccept.Focus(); break;
                    default:
                        break;
                }
            }
            if (textBoxSender.Equals("tbZip")){
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;

            }
        }

        private void changeColor_OnHover(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if(senderButton.Name == "btnClear")
                senderButton.BackColor = Color.Red;
            else
                senderButton.BackColor = Color.Green;
        }

        private void changeColor_OnLeave(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            senderButton.BackColor = Color.White;
        }
    }
}
