using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_1
{
    public abstract class Monster
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public abstract void Attack(Player player);
        public abstract Item DropItem();
        public abstract int GiveExperice();
        public abstract void SpecialAttack(Player player);
    }
}

