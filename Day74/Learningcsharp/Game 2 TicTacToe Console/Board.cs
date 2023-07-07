using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_2_TicTacToe_Console
{
    internal class Board
    {
        public string[,] Cells = new string[3, 3];
        public Dictionary<int, int[]> cellMap;
        public Board() 
        {
            cellMap = new Dictionary<int, int[]>();
            resetBoard();
        }
        
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
