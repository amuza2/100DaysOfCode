using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game1
{
    public partial class Form1 : Form
    {
        
        char who = 'o';
        char winnerPlayer = 'a';
        bool isWinner = false;
        bool startRound = true;
        int Drawcounter = 0;
        int player1Score = 0;
        int player2Score = 0;
        int roundCounter = 0;
        
        public Form1()
        {
            InitializeComponent();     
            RadioButton1.Checked = true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if(bt != null)
            {
                if (RadioButton1.Checked && startRound) who = 'o';
                else if (RadioButton2.Checked && startRound) who = 'x';
                if (startRound)
                {
                    RadioButton1.Enabled = false;
                    RadioButton2.Enabled = false;
                    startRound = false;
                }
                Drawcounter++;
                bt.Font = new Font(bt.Font.FontFamily, 40, FontStyle.Regular);
                if (who == 'o') bt.Text = "O"; else bt.Text = "X";
                if (who == 'o') who = 'x'; else who = 'o';
                bt.Enabled = false;
                CheckTheWinner(bt);
            }
        }

        private void ChangeBackColor(Button button1, Button button2, Button button3)
        {
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Green;
        }

        // Horizantal
        private bool HLine1()
        {
            if (btnA.Text == btnB.Text && btnB.Text == btnC.Text)
            {
                ChangeBackColor(btnA, btnB, btnC);
                return true;
            }
            return false;
        }
        private bool HLine2()
        {
            if (btnD.Text == btnE.Text && btnE.Text == btnF.Text)
            {
                ChangeBackColor(btnD, btnE, btnF);
                return true;
            }
            return false;
        }
        private bool HLine3()
        {
            if (btnG.Text == btnH.Text && btnH.Text == btnI.Text)
            {
                ChangeBackColor(btnG, btnH, btnI);
                return true;
            }
            return false;
        }
        // Vertical
        private bool VLine1()
        {
            if (btnA.Text == btnD.Text && btnD.Text == btnG.Text)
            {
                ChangeBackColor(btnA, btnD, btnG);
                return true;
            }
            return false;
        }
        private bool VLine2()
        {
            if (btnB.Text == btnE.Text && btnE.Text == btnH.Text)
            {
                ChangeBackColor(btnB, btnE, btnH);
                return true;
            }
            return false;
        }
        private bool VLine3()
        {
            if (btnC.Text == btnF.Text && btnF.Text == btnI.Text)
            {
                ChangeBackColor(btnC, btnF, btnI);
                return true;
            }
            return false;
        }
        // Diagonal
        private bool DLine1()
        {
            if (btnA.Text == btnE.Text && btnE.Text == btnI.Text)
            {
                ChangeBackColor(btnA, btnE, btnI);
                return true;
            }
            return false;
        }
        private bool DLine2()
        {
            if (btnG.Text == btnE.Text && btnE.Text == btnC.Text)
            {
                ChangeBackColor(btnG, btnE, btnC);
                return true;
            }
            return false;
        }

        private char getWinnerChar(Button button)
        {
            char value = Char.Parse(button.Text);
            return value;
        }

        private void CheckTheWinner(Button bt)
        {
            switch (bt.Name)
            {
                case "btnA":
                    if(HLine1() || VLine1() || DLine1()) winnerPlayer = getWinnerChar(bt);
                    break;
                case "btn.B":
                    if(HLine1() || VLine2()) winnerPlayer = getWinnerChar(bt);
                    break;
                case "btnC":
                    if(HLine1() || VLine3() || DLine2()) winnerPlayer = getWinnerChar(bt);
                    break;
                case "btnD":
                    if(VLine1() || HLine2()) winnerPlayer = getWinnerChar(bt);
                    break;
                case "btnE":
                    if(HLine2() || VLine2() || DLine1() || DLine2()) winnerPlayer = getWinnerChar(bt);
                    break;
                case "btnF":
                    if (HLine2() || VLine3()) winnerPlayer = getWinnerChar(bt);
                    break;
                case "btnG":
                    if(HLine3() || VLine1() || DLine2()) winnerPlayer = getWinnerChar(bt);
                    break;
                case "btnH":
                    if(HLine3() || VLine2()) winnerPlayer = getWinnerChar(bt);
                    break;
                case "btnI":
                    if(HLine3() || VLine3() || DLine1()) winnerPlayer = getWinnerChar(bt);
                    break;
            }

            if (winnerPlayer == 'O')
            {
                player1Score++;
                isWinner = true;
            }
            else if (winnerPlayer == 'X')
            {
                player2Score++;
                isWinner = true;
            }
            lblScorePlayer1.Text = player1Score.ToString();
            lblScorePlayer2.Text = player2Score.ToString();

            if (Drawcounter == 9 && winnerPlayer == 'a') MessageBox.Show("Draw game", "End Game");
            else if(isWinner)
            {
                foreach (Button item in panel1.Controls)
                {
                    if (item.Enabled) item.Enabled = false;
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Button button in panel1.Controls)
            {
                button.Enabled = true;
                button.BackColor = Color.White;
                button.Text = string.Empty;
            }
            player1Score = 0;
            player2Score = 0;
            lblScorePlayer1.Text = "0";
            lblScorePlayer2.Text = "0";
            winnerPlayer = 'a';
            Drawcounter = 0;
            isWinner = false;
            roundCounter = 0;
            lblRoundNumber.Text = "0";
            startRound = true;
            RadioButton1.Enabled = true;
            RadioButton2.Enabled = true;
        }

        private void textboxPlayer1_Click(object sender, EventArgs e)
        {
            TextPlayer1.Text = "";
        }

        private void textboxPlayer2_Click(object sender, EventArgs e)
        {
            TextPlayer2.Text = "";
        }

        private void RadioButton_CheckedChange(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            if(rd.Checked)
            {
                if (rd.Name == RadioButton1.Name) who = 'o';
                else who = 'x';
            }
            RadioButton1.ForeColor = Color.White;
            RadioButton2.ForeColor = Color.White;
        }

        private void btnNextRound(object sender, EventArgs e)
        {
            if (isWinner || Drawcounter == 9)
            {
                foreach (Button button in panel1.Controls)
                {
                    button.Enabled = true;
                    button.BackColor = Color.White;
                    button.Text = string.Empty;
                }
                winnerPlayer = 'a';
                Drawcounter = 0;
                isWinner = false;
                roundCounter++;
                lblRoundNumber.Text = roundCounter.ToString();
                startRound = true;
                RadioButton1.Enabled = true;
                RadioButton2.Enabled = true;
            }
        }

        private void textboxPlayer_Click(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = "";
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TextBox tb = (TextBox)sender;
                if (tb.Name == "TextPlayer1") lblPlayer1.Text = tb.Text;
                else if(tb.Name == "TextPlayer2") lblPlayer2.Text = tb.Text;
            }
            
        }
    }
}
