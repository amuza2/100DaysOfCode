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
        int turnsCounter = 0;
        bool checkEmptyCell = false;
        int i; int j;
        int playerInput;
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
                
                // Check if the cell is empty
                do
                {
                    bool isParsed = false;
                    // check player entered the right value accourding to the menu
                    do
                    {
                        Console.Write("Enter a cell index number: ");
                        isParsed = int.TryParse(Console.ReadLine(), out playerInput);
                        if (isParsed)
                        {
                            if (playerInput == 0) Environment.Exit(0);
                            else isParsed = true;
                        }
                        else Console.WriteLine("Invalid input!");

                    } while (!isParsed);
                    i = GameBoard.cellMap[playerInput][0];
                    j = GameBoard.cellMap[playerInput][1];
                    if (GameBoard.Cells[i, j] != player1.Symbole && GameBoard.Cells[i, j] != player2.Symbole)
                    {
                        checkEmptyCell = true;
                    }
                    else
                    {
                        Console.WriteLine("The cell is not empty");
                        checkEmptyCell = false;
                    }
                } while (checkEmptyCell == false);
                // Assign player symbole as it's a free cell
                GameBoard.Cells[i, j] = playerTurn.Symbole;
                // check for winner
                bool winner = CheckPlayerWin();
                if (winner)
                {
                    playerTurn.Score++;
                    winnerPlayer();
                    GameBoard.resetBoard();
                    Console.Clear();
                    playerTurn = player1;
                    goto start;
                }
                turnsCounter++; // Count turns to check for draw
                // check if it's draw
                if (checkDraw())
                {
                    Console.WriteLine("it's a draw");
                    menu();
                    GameBoard.resetBoard();
                    Console.Clear();
                    goto start;
                }
                // change player's turn
                changePlayerTurn();
                Console.Clear();

            }
        }
        // Change player turn 
        private void changePlayerTurn()
        {
            if(playerTurn == player1) playerTurn = player2;
            else playerTurn = player1;
        }
        // Check if player is winner
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
        // Check if the is a draw
        private bool checkDraw()
        {
            if (turnsCounter == 9) return true;
            return false;
        }
        // draw menu
        private void menu()
        {
            int val;
            bool success;
            do
            {
                Console.WriteLine("Press 1 to play or 0 to exit");
                success = int.TryParse(Console.ReadLine(), out val);
            } while (!success);
            if (val == 0) Environment.Exit(0);
        }
        // Draw winner card
        private void winnerPlayer()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("You are playing Tic Tac Toe Game");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(player1.Name + " Score: " + player1.Score + "          " + player2.Name + " Score: " + player2.Score);
            Console.WriteLine("Congratulations " + playerTurn.Name + " you Won");
            GameBoard.updateBoard();
            menu();
        }
    }
}
