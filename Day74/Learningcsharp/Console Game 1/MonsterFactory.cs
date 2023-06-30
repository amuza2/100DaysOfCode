using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_1
{
    public static class MonsterFactory
    {
        private static List<Monster> MonsterList = new List<Monster>();
        public static Monster CreateMonster()
        {
            AddGoblin();
            AddDragon();
            return GetRandomMonster();
        }
        private static Monster GetRandomMonster()
        {
            Random random = new Random();
            int monsterType = random.Next(MonsterList.Count);
            return MonsterList[monsterType];
        }
        private static void AddGoblin()
        {
            Goblin goblin = new Goblin();
            MonsterList.Add(goblin);
        }
        private static void AddDragon()
        {
            Dragon dragon = new Dragon();
            MonsterList.Add(dragon);
        }
        
    }
}
