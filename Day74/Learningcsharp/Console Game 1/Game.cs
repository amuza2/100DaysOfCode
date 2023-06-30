using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Game_1
{
    public class Game
    {
        bool isMonster = true;
        public Player Player { get; set; }
        public Game()
        {
            Player = new Player();
        }
        public void Start()
        {
            Console.WriteLine("Welcome to the game!");
            while (Player.Health > 0)
            {
                Monster monster = MonsterFactory.CreateMonster();
                while (monster.Health > 0 && Player.Health > 0)
                {
                    if (isMonster)
                    {
                        Console.Write(monster.DrawFace());
                        isMonster = false;
                    }
                    Console.WriteLine($"You encounter a {monster.Name}! What do you do? (fight/run/use item/special attack/exit)");
                    Console.WriteLine(Player.DrawHealth() + " | " + monster.DrawHealth());
                    string action = Console.ReadLine();
                    if (action == "fight")
                    {
                        Player.Attack(monster);
                        if (monster.Health > 0)
                        {
                            monster.Attack(Player);
                        }
                        else
                        {
                            Console.Clear();
                            isMonster = true;
                            Player.GainExperice(monster.GiveExperice());
                            Item droppedItem = monster.DropItem();
                            if (droppedItem != null)
                            {
                                Player.Inventory.Add(droppedItem);
                                Console.WriteLine($"You defeated the {monster.Name} and found a {droppedItem.Name}");
                            }
                            else
                            {
                                Console.WriteLine($"You defeated the {monster.Name} didn't drop anything!");
                            }
                        }
                    }
                    else if (action == "run")
                    {
                        isMonster = true;
                        Console.Clear();
                        Console.WriteLine("You run away!");
                        break;
                    }
                    else if (action == "use item")
                    {
                        if (Player.Inventory.Count > 0)
                        {
                            Console.WriteLine("Which item do you want to use?");
                            for (int i = 0; i < Player.Inventory.Count; i++)
                            {
                                Console.WriteLine($"{i + 1} - {Player.Inventory[i].Name}");
                            }
                            int itemIndex = int.Parse(Console.ReadLine()) - 1;
                            if (itemIndex == -1) {break;}
                            Player.UseItem(Player.Inventory[itemIndex]);
                        }
                        else { Console.WriteLine("Inventory is empty:"); }
                    }
                    else if (action == "special attack")
                    {
                        bool isAttacked = Player.SpecialAttack(monster);
                        if (monster.Health > 0 && isAttacked)
                        {
                            monster.SpecialAttack(Player);
                        }
                    }
                    else if (action == "exit") Environment.Exit(0);
                }
                if (Player.Health <= 0)
                {
                    Console.WriteLine("You died!");
                }
            }
        }
    }


}
