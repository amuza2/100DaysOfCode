using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Game_2_TicTacToe_Console
{
    internal class Game
    {
        Player playerTurn;
        Board GameBoard;
        Player player1;
        Player player2;
        bool play = true;
        public Game() 
        { 
            GameBoard = new Board();
            player1 = new Player("O", "moh");
            player2 = new Player("X", "amuza");
            playerTurn = player1;
            run();
        }

        private void run()
        {
            start:
            while (play)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("You are playing Tic Tac Toe Game");
                Console.WriteLine("----------------------------------");
                Console.WriteLine(player1.Name + " Score: " + player1.Score + "          " + player2.Name + " Score: " + player2.Score);
                Console.WriteLine("Player Turn: " + playerTurn.Name);
                GameBoard.updateBoard();
                Console.Write("Enter a cell index number: ");

                int playerInput = int.Parse(Console.ReadLine());
                if (playerInput == 0) { Environment.Exit(0); }
                int i = GameBoard.cellMap[playerInput][0];
                int j = GameBoard.cellMap[playerInput][1];
                GameBoard.Cells[i, j] = playerTurn.Symbole;
                bool winner = CheckPlayerWin();
                if (winner)
                {
                    Console.WriteLine("Congratulations " + playerTurn.Name + " you Won");
                    playerTurn.Score++;
                    playerTurn = player1;
                    GameBoard.resetBoard();
                    Console.Write("Press 1 to play again or 0 to exit");
                    playerInput = int.Parse(Console.ReadLine());
                    if (playerInput == 0) Environment.Exit(0);
                    Console.Clear();
                    goto start;
                }
                changePlayerTurn();
                Console.Clear();

            }
        }

        private void changePlayerTurn()
        {
            if(playerTurn == player1) playerTurn = player2;
            else playerTurn = player1;
        }

        private bool CheckPlayerWin()
        {
            int hCounter = 0;
            int vCounter = 0;
            // horizantal  and vertical check
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (playerTurn.Symbole == GameBoard.Cells[i, j]) hCounter++;

                    if (playerTurn.Symbole == GameBoard.Cells[j, i]) vCounter++;
                }
                if(hCounter == 3 || vCounter == 3) return true;
                hCounter = 0;
                vCounter = 0;
            }

            // diagonal check
            if (playerTurn.Symbole == GameBoard.Cells[0, 0] &&
                playerTurn.Symbole == GameBoard.Cells[1, 1] &&
                playerTurn.Symbole == GameBoard.Cells[2, 2]) return true;
            
            if (playerTurn.Symbole == GameBoard.Cells[0, 2] &&
                playerTurn.Symbole == GameBoard.Cells[1, 1] &&
                playerTurn.Symbole == GameBoard.Cells[2, 0]) return true;

            return false;
        }

    }
}
