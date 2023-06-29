using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_1
{
    public class Goblin : Monster
    {
        public Goblin()
        {
            Name = "Goblin";
            Health = 30;
        }

        public override void Attack(Player player)
        {
            player.Health -= 5;
            Console.WriteLine("The goblin attacked you!");
        }
    }
}
