using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace selfLearning
{
    internal class Program
    {
        /*static void Bissextile(int a)
        {
            if (a % 4 == 0 || a % 100 != 0 && a % 400 == 0)
            {
                Console.WriteLine(a + " l'annee et bissextile");
            }
            else
            {   
                Console.WriteLine(a + " l'annee n'est pas bissextile");
            }
        }*/
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Write("   Tasks to choose from: ");
            Console.WriteLine("\n1- Des operations arithmetiques(+-*/);");
            Console.WriteLine("2- Equation 1er Degré;");
            Console.WriteLine("3- Equation 2eme Degré.");
            
            Console.Write("\nChoose one value: ");
            int f = int.Parse(Console.ReadLine());
            // Variable declaration
            if (f == 1)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("------- You chosed arethmetic operation --------");
                Console.Write("Add the first number: ");
                float num1 = float.Parse(Console.ReadLine());
                Console.Write("Add the second number: ");
                float num2 = float.Parse(Console.ReadLine());

                Console.Write("Add the |operator| (+-*/): ");
                char op = char.Parse(Console.ReadLine());
                float result = 0;
                switch(op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("The operator that you entered is not valid!");
                        break;
                }
                Console.WriteLine($"\nThe result of sign {op} is {result}");

            }
            else if(f == 2)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("------ Solve one degree equation ------");
                Console.Write("\n Enter value a:");
                int a = int.Parse(Console.ReadLine());
                while(a == 0)
                {
                    Console.Clear();
                    Console.WriteLine("------ Solve one degree equation ------");
                    Console.WriteLine("\n Enter value a:");
                    a = int.Parse(Console.ReadLine());
                }
                Console.Write("Enter value b: ");
                int b = int.Parse(Console.ReadLine());
                float x = b / a;
                Console.WriteLine($"\nThe result of this first equation of {a}x={b} is: {x}");
            }
            else if(f == 3)
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
                if(d > 0)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"\nThe result of X1: {x1}");
                    Console.WriteLine($"The result of X2: {x2}");
                }else if(d == 0)
                {
                    double x0 = -b / (2 * a);
                    Console.WriteLine($"\nThe equation {a}x²{b}x+{c}c has only one solution which is: {x0}");
                }
                else
                {
                    Console.WriteLine("The equation doesn't have a solution");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong input!");
            }

        }
    }
}
