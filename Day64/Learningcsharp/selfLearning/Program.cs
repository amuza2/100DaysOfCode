using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TextToAsciiArt;
using J3QQ4;

namespace selfLearning
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            while (active)
            {
                string Hastresk = "*********************";
                string space = " ";
                string title = @"
*   ______      __           __      __            *
*  / ____/___ _/ /______  __/ /___ _/ /_____  _____*
* / /   / __ `/ / ___/ / / / / __ `/ __/ __ \/ ___/*
*/ /___/ /_/ / / /__/ /_/ / / /_/ / /_/ /_/ / /    *
*\____/\__,_/_/\___/\__,_/_/\__,_/\__/\____/_/     *
*                                                  *
*    ____               _           __             *
*   / __ \_________    (_)__  _____/ /_            *
*  / /_/ / ___/ __ \  / / _ \/ ___/ __/            *
* / ____/ /  / /_/ / / /  __/ /__/ /_              *
*/_/   /_/   \____/_/ /\___/\___/\__/              *
*                /___/                             *
";
                
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("****************************************************");
                Console.WriteLine(title);
                Console.Write($"***************** Tasks to choose from *************");
                Console.WriteLine($"\n*          1- Arithmitic Operations (+-*/) {space}       *");
                Console.WriteLine($"*          2- 1st degree equation                 {space}*");
                Console.WriteLine($"*          3- 2nd degree equation               {space}  *");
                Console.WriteLine($"*          4- Write Q to exit                    {space} *");
                Console.WriteLine("****************************************************");
                Console.WriteLine("\n***************** Choose from 1 to 4: ****************");
                string f = Console.ReadLine();
                // Variable declaration
                if (f == "1")
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("******** You choosed arethmetic operation *********");

                    bool result = false;
                    string x1, x2, op = "a";
                    double num1 = 0;
                    double num2 = 0;
                    do
                    {
                        Console.Write("Add the first number: ");
                        x1 = Console.ReadLine();
                        result = double.TryParse(x1, out num1);
                        if (result) break;
                        Console.WriteLine("Please Enter a valid number");
                    } while (!result);
                    do
                    {
                        Console.Write("Add the second number: ");
                        x2 = Console.ReadLine();
                        result = double.TryParse(x2, out num2);
                        if (result) break;
                        Console.WriteLine("Please Enter a valid number");
                    } while(!result);
                    do
                    {
                        Console.Write("Add an |Operator| ( + - * / ): ");
                        op = Console.ReadLine();
                        if (op.Contains("+") || op.Contains("-") || op.Contains("*") || op.Contains("/"))
                        {
                            result = false;
                        }
                        else
                        {
                        Console.WriteLine("Please Enter a valid Operator");
                        }
                    } while (result);


                    double result1 = 0;
                    while (true)
                    {
                        switch (op)
                        {
                            case "+":
                                result1 = num1 + num2;
                                break;
                            case "-":
                                result1= num1 - num2;
                                break;
                            case "*":
                                result1 = num1 * num2;
                                break;
                            case "/":
                                result1 = num1 / num2;
                                break;
                            default:
                                Console.WriteLine("The operator that you entered is not valid!");
                                break;
                        }
                        break;
                    }
                    Console.WriteLine($"\nThe result is: {result1}");
                    Console.ReadLine();

                }
                else if (f == "2")
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine("------ Solve one degree equation ------");
                    Console.Write("\n Enter value a:");
                    double a = double.Parse(Console.ReadLine());
                    while (a == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("------ Solve one degree equation ------");
                        Console.WriteLine("\n Enter value a:");
                        a = double.Parse(Console.ReadLine());
                    }
                    Console.Write("Enter value b: ");
                    double b = double.Parse(Console.ReadLine());
                    double x = -b / a;
                    Console.WriteLine($"\nThe result of this first equation of {a}x+b{b} is: {x}");
                    Console.ReadLine();
                }
                else if (f == "3")
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine("----- Second Degree Equation ------");
                    Console.Write("\nEnter the value of a: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter the value of b: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("Enter the value of c: ");
                    int c = int.Parse(Console.ReadLine());
                    int d = (b * b) - (4 * a * c);
                    if (d > 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                        double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                        Console.WriteLine($"\nThe result of X1: {x1}");
                        Console.WriteLine($"The result of X2: {x2}");
                    }
                    else if (d == 0)
                    {
                        double x0 = -b / (2 * a);
                        Console.WriteLine($"\nThe equation {a}x²{b}x+{c}c has only one solution which is: {x0}");
                    }
                    else
                    {
                        Console.WriteLine("The equation doesn't have a solution");
                    }
                    Console.ReadLine();
                }
                else if (f.ToUpper() == "Q")
                {
                    active = false;
                    Console.WriteLine("**** Thank you for visiting us :) ****");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong input!");
                }
            }

        }
    }
}
