using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_1
{
    public class Dragon : Monster
    {
        public Dragon() 
        {
            Name = "Dragon";
            Health = 100;
        }

        public override void Attack(Player player)
        {
            player.Health -= 20;
            Console.WriteLine("The dragon attacked you!");
        }
    }
}
