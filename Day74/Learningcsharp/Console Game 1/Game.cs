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
                    Console.WriteLine($"You encounter a {monster.Name}! What do you do? (fight/run)");
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
                            Player.LevelUp();
                            Console.WriteLine($"You defeated the {monster.Name} and leveled up to level {Player.Level}!");
                        }
                    }
                    else if (action == "run")
                    {
                        Console.WriteLine("You run away!");
                        break;
                    }
                }
                if (Player.Health <= 0)
                {
                    Console.WriteLine("You died!");
                }
            }
        }
    }


}
