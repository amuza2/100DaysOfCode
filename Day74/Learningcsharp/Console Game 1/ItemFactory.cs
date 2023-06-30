using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game_1
{
    public static class ItemFactory
    {
        private static List<Item> InventoryList = new List<Item>();
        public static Item? CreateItem()
        {
            bool active = true;
            if (active)
            {
                AddHealthBoost();
                AttackBoost();
                BigHealthBoost();
                active = false;
            }
            return GetRandomPotion();
        }
        private static Item? GetRandomPotion()
        {
            Random rnd = new Random();
            int postionType = rnd.Next(InventoryList.Count);
            int gameDefficulty = rnd.Next(5);
            if (gameDefficulty > 0) return InventoryList[postionType];
            else return null;
        }
        private static void AddHealthBoost()
        {
            HealthBoost healthBoost = new HealthBoost();
            InventoryList.Add(healthBoost);
        }
        private static void AttackBoost()
        {
            AttackBoost attackBoost = new AttackBoost();
            InventoryList.Add(attackBoost);
        }
        private static void BigHealthBoost()
        {
            BigHealthBoost bigHealthBoost = new BigHealthBoost();
            InventoryList.Add(bigHealthBoost);
        }

    }
}
