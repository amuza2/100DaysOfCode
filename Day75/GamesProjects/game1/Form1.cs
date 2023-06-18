using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace game1
{
    public partial class Form1 : Form
    {
        char who = 'o';               // Track who is playing
        bool isWinner = false;        // Track the winner player
        char winnerPlayer = 'a';      // Track which player is winner
        bool startRound = true;       // Track start of the round
        int Drawcounter = 0;          // Track if the game is draw
        int player1Score = 0;         // Player 1 score counter
        int player2Score = 0;         // Player 2 score counter
        int roundCounter = 0;         // count the number of rounds played
        
        public Form1()
        {
            InitializeComponent();     
            RadioButton1.Checked = true;      // set player 1 start player
            lblPlayerTurn.Text = "Player 1";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if(bt != null)
            {
                // Select wich player want to start the game
                if (RadioButton1.Checked && startRound) who = 'o';
                else if (RadioButton2.Checked && startRound) who = 'x';
                // Hide the radio button when start playing
                if (startRound)
                {
                    RadioButton1.Visible = false;
                    RadioButton2.Visible = false;
                    startRound = false;
                }
                Drawcounter++;           // Add to counter +1 when a player fills the board
                bt.Font = new Font(bt.Font.FontFamily, 40, FontStyle.Regular); // set board font & size
                if (who == 'o') bt.Text = "O"; else bt.Text = "X";          // chage turns between the two players
                if (who == 'o') who = 'x'; else who = 'o';
                bt.Enabled = false;                                         // Disable board button after clicking on it
                CheckTheWinner(bt);                                         // Check the winner
                PlayerTurnCheck();                                          // Change player's turn in labels
            }
        }

        // When a player wins fill the 3 buttons with a color
        private void ChangeBackColor(Button button1, Button button2, Button button3)
        {
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Green;
        }

        // Check for wins
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
        // Get how is the winner
        private void CheckTheWinner(Button bt)
        {
            switch (bt.Name)
            {
                case "btnA":
                    if(HLine1() || VLine1() || DLine1()) winnerPlayer = getWinnerChar(bt);
                    break;
                case "btnB":
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
                lblScorePlayer1.Text = player1Score.ToString();
                isWinner = true;
            }
            else if (winnerPlayer == 'X')
            {
                player2Score++;
                lblScorePlayer2.Text = player2Score.ToString();
                isWinner = true;
            }
            
            if (Drawcounter == 9 && winnerPlayer == 'a') MessageBox.Show("Draw game", "End Game");
            else if(isWinner)
            {
                foreach (Button item in panel1.Controls)
                {
                    if (item.Enabled) item.Enabled = false;
                }
            }
        }
        // Exit the game when clicking in the exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Reset game and thier values when clicking on reset button
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
            RadioButton1.Visible = true;
            RadioButton2.Visible = true;
            if (RadioButton1.Checked) lblPlayerTurn.Text = "Player 1";
            else if (RadioButton2.Checked) lblPlayerTurn.Text = "Player 2";
        }
        private void RadioButton_CheckedChange(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton rd = (System.Windows.Forms.RadioButton)sender;
            if(rd.Checked)
            {
                if (rd.Name == RadioButton1.Name) who = 'o';
                else who = 'x';
            }
            PlayerTurnCheck();
        }
        // Continue playing next round button
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
                RadioButton1.Visible = true;
                RadioButton2.Visible = true;
            if(RadioButton1.Checked) lblPlayerTurn.Text = "Player 1";
            else if(RadioButton2.Checked) lblPlayerTurn.Text = "Player 2";
            }
        }
        // Empty the textboxe when the player 1 or 2 click on it
        private void textboxPlayer_Click(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = "";
        }
        // Press enter on textbox to change the label
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TextBox tb = (TextBox)sender;
                if (tb.Name == "TextPlayer1") lblPlayer1.Text = tb.Text;
                else if(tb.Name == "TextPlayer2") lblPlayer2.Text = tb.Text;
            }   
        }
        // Change label turns accourding to player
        private void PlayerTurnCheck()
        {
            if (who == 'o') lblPlayerTurn.Text = "Player 1";
            else if (who == 'x') lblPlayerTurn.Text = "Player 2";
        }
        // Reset game when you click on new game menu
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnReset_Click(this, EventArgs.Empty);
        }
        // Exit from the game when clicking on Exit on menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExit_Click(this, EventArgs.Empty);
        }
        // Show a popup when clicking on the about menu
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game was developed by Mohammed Chami\nContact => Twitter: @mohamuza", "About");
        }
    }
}
