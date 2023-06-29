using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_1
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public abstract void PotionAbility(Player player);

    }
}
