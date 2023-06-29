using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_1
{
    public static class ItemFactory
    {
        public static Item? CreateItem()
        {
            Random rand = new Random();
            int postionType = rand.Next(3);
            if (postionType == 0)
            {
                return new HealthBoost();
            }
            else if (postionType == 1)
            {
                return new AttackBoost();
            }
            else return null;
        }
    }
}
