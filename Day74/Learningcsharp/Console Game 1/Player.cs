using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Game_1
{
    public class Player
    {
        public int Health { get; set; }
        public int Level { get; set; }

        public Player()
        {
            Health = 100;
            Level = 1;
        }

        public void Attack(Monster monster)
        {
            monster.Health -= 10 * Level;
            Console.WriteLine($"You attacked the {monster.Name}!");
        }

        public void LevelUp()
        {
            Level++;
        }
    }
}
