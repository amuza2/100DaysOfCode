using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_2_TicTacToe_Console
{
    internal class Board
    {
        // store player input (symbole)
        public string[,] Cells = new string[3, 3];
        // key => val from 1 - 9, value => coordinate of the cell
        public Dictionary<int, int[]> cellMap;
        public Board() 
        {
            cellMap = new Dictionary<int, int[]>();
            resetBoard();
        }
        
        // update and draw cell when player's enter an input
        public void updateBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"|  {Cells[i, j]}  ");    
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }
        // reset the cell to start a new round
        public void resetBoard()
        {
            int counter = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (!cellMap.ContainsKey(counter))
                    {
                        cellMap.Add(counter, new int[] { i, j });
                    }
                    Cells[i, j] = counter.ToString();
                    counter++;   
                }
            }
        }
    }
}
