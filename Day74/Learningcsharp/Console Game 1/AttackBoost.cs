using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_1
{
    public class AttackBoost : Item
    {
        public AttackBoost() 
        {
            Name = "Attack Boost";
            Value = 2;
        }
        public override void PotionAbility(Player player)
        {
            player.BaseAttack += Value;
            Console.WriteLine($"You used {Name} Potion and added {Value} to your base attack");
        }
    }
}
