using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.InteropServices;

namespace basics_learning
{
    public class Program
    {
        static double Rectangle(double width, double height)
        {
            return (width + height) * 2;
        }

        static double circle(double q)
        {
            return q * Math.PI * 2;
        }
        static void Main(string[] args)
        {
            bool play = true;
            while(play)
            {
                Console.WriteLine("------- Choose a task ---------------");
                Console.WriteLine("         1- Rectangle");
                Console.WriteLine("         2- Circle");
                Console.WriteLine("         3- Exit");
                int i = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    Console.Write("Enter the width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Enter the height: ");
                    double height = double.Parse(Console.ReadLine());
                    double result = Rectangle(width, height);
                    Console.WriteLine("The result is: " + result);
                    Console.ReadKey();
                }
                else if (i == 2)
                {
                    Console.Write("Enter the value: ");
                    double q = double.Parse(Console.ReadLine());
                    double result = circle(q);
                    Console.WriteLine("The result is: " + result);
                    Console.ReadKey();
                }
                else if (i == 3)
                {
                    play = false;
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please add a valid number");
                    Console.ReadKey();
                }
                Console.Clear();
            }
















        /*
        startPlaying:
            Console.WriteLine("You entered a geuss game");
            int choosedNumber = 0;
            do
            {
                choosedNumber = new Random().Next(20);
            } while (choosedNumber <= 5);            
            Console.WriteLine($"I am thinking of a number between 0 and {choosedNumber}");
            bool answer = true;
            int guessCounter = 0;
            while (answer) 
            {
                Console.WriteLine("enter a number or write q to quit: ");
                int number = 0;
                string SNumber = Console.ReadLine();
                if (SNumber.ToUpper() == "Q" ) { break; }
                bool succeed = int.TryParse(SNumber, out number);
                if (!succeed) 
                { 
                    Console.WriteLine("Please add a valid number");
                }
                else
                {
                    if (number == choosedNumber)
                    {
                        guessCounter++;
                        Console.WriteLine($"You got it right in {guessCounter} guesses.");
                        Console.Write("Do you want to play again [Y/N]? ");
                        string play = Console.ReadLine();
                        if (play.ToUpper() == "Y")
                        {
                            Console.Clear();
                            goto startPlaying;
                        }
                        else
                        {
                            answer = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nope, {0} than that.", number < choosedNumber ? "higher" : "lower");
                        guessCounter++;
                    }
                }
            }
            Console.ReadLine();
            */
        }
    }
}
