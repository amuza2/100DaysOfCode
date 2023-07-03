using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_1
{
    public class HealthBoost : Item
    {
        public HealthBoost() 
        {
            Name = "Health Boost";
            Value = 20;
        }
        public override void PotionAbility(Player player)
        {
            player.AddHealth(Value);
            Console.WriteLine($"You used {Name} Potion and added {Value} to your Health");
        }
    }
}
