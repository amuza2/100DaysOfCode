using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    internal class Game
    {
        public Player CurrentPlayer { get; private set; }
        public Cell[,] Board { get; private set; }

        private Player player1;
        private Player player2;

        public Game()
        {
            player1 = new Player("Player 1", "X");
            player2 = new Player("Player 2", "O");
            CurrentPlayer = player1;
            Board = new Cell[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Board[i, j] = new Cell();
                }
            }
        }

        public void MakeMove(int row, int col)
        {
            if (string.IsNullOrEmpty(Board[row, col].Value))
            {
                Board[row, col].Value = CurrentPlayer.Symbol;
                SwitchPlayer();
            }
        }

        private void SwitchPlayer()
        {
            CurrentPlayer = CurrentPlayer == player1 ? player2 : player1;
        }

        // Add your own method to check for game over condition
    }
}
