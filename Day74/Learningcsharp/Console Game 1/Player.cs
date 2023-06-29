using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Game_1
{
    public class Player
    {
        public List<Item> Inventory { get; set;}
        public int Health { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int ExperienceNeeded { get; set; }
        public int BaseAttack { get; set; }

        public Player()
        {
            Health = 100;
            Level = 1;
            Inventory = new List<Item>();
            Experience = 1;
            ExperienceNeeded = 100;
            BaseAttack = 10;
        }

        public void UseItem(Item item)
        {
            item.PotionAbility(this);
            Inventory.Remove(item);
        }


        public void Attack(Monster monster)
        {
            int attackPower = BaseAttack * Level;
            monster.Health -= attackPower;
            Console.WriteLine($"You attacked the {monster.Name}!");
        }

        public void GainExperice(int amount)
        {
            Experience += amount;
            if (Experience >= ExperienceNeeded)
            {
                LevelUp();
                Experience -= ExperienceNeeded;
                ExperienceNeeded *= 2;
            }
        }
        public void LevelUp()
        {
            Level++;
            Console.WriteLine($"You leveled up to level {Level}!");
        }
        public bool SpecialAttack(Monster monster)
        {
            if(Experience % 50 == 0)
            {
                monster.Health -= 20 * Level;
                Console.WriteLine($"You used your special attack on the {monster.Name}!");
                return true;
            }
            else { Console.WriteLine("You don't have enough experience:"); return false; }
        }
    }
}
