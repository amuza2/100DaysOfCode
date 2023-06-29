using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        private Game game;
        private Button[,] buttons;
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            game = new Game();
            buttons = new Button[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Location = new Point(j * 100, i * 100);
                    buttons[i, j].Size = new Size(100, 100);
                    buttons[i, j].Click += Button_Click;
                    Controls.Add(buttons[i, j]);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int row = button.Location.Y / 100;
            int col = button.Location.X / 100;
            game.MakeMove(row, col);
            button.Text = game.Board[row, col].Value;
            button.Enabled = false;
            CheckGameOver();
        }

        private void CheckGameOver()
        {
            if (IsWin())
            {
                MessageBox.Show($"{game.CurrentPlayer.Name} wins!");
            }
            else if (IsDraw())
            {
                MessageBox.Show("It's a draw!");
            }
            ResetGame();
        }

        private bool IsWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (CheckRow(i) || CheckColumn(i))
                {
                    return true;
                }
            }
            return CheckDiagonals();
        }

        private bool CheckRow(int row)
        {
            string symbol = game.Board[row, 0].Value;
            return !string.IsNullOrEmpty(symbol) && game.Board[row, 1].Value == symbol && game.Board[row, 2].Value == symbol;
        }

        private bool CheckColumn(int col)
        {
            string symbol = game.Board[0, col].Value;
            return !string.IsNullOrEmpty(symbol) && game.Board[1, col].Value == symbol && game.Board[2, col].Value == symbol;
        }

        private bool CheckDiagonals()
        {
            string symbol1 = game.Board[0, 0].Value;
            bool diagonal1 = !string.IsNullOrEmpty(symbol1) && game.Board[1, 1].Value == symbol1 && game.Board[2, 2].Value == symbol1;
            string symbol2 = game.Board[0, 2].Value;
            bool diagonal2 = !string.IsNullOrEmpty(symbol2) && game.Board[1, 1].Value == symbol2 && game.Board[2, 0].Value == symbol2;
            return diagonal1 || diagonal2;
        }

        private bool IsDraw()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (string.IsNullOrEmpty(game.Board[i, j].Value))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void ResetGame()
        {
            game = new Game();
            foreach (Button button in buttons)
            {
                button.Text = string.Empty;
                button.Enabled = true;
            }
        }
    }
}
