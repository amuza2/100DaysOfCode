using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_2_TicTacToe_Console
{
    internal class Player
    {
        public string Symbole { get; private set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public Player(string simbole, string name)
        {
            Symbole = simbole;
            Name = name;
            Score = 0;

        }
    }
}
