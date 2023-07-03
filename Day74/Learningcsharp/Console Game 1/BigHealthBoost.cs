using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_1
{
    public class BigHealthBoost : Item
    {
        public BigHealthBoost()
        {
            Name = "Big Health Boost";
            Value = 50;
        }
        public override void PotionAbility(Player player)
        {
            player.AddHealth(Value);
            Console.WriteLine($"You used {Name} Potion and added {Value} to your Health");
        }
    }
}
