using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_1
{
    public static class MonsterFactory
    {
        public static Monster CreateMonster()
        {
            Random random = new Random();
            int monsterType = random.Next(2);
            if (monsterType == 0)
            {
                return new Goblin();
            }
            else
            {
                return new Dragon();
            }
        }
    }
}
