using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_calculator_project
{
    internal class Program
    {
        public static void menu()
        {
            Console.WriteLine("Modern calculator");
            Console.WriteLine("1- Arithmitic Operator");
            Console.WriteLine("2- 1st Degree equation");
            Console.WriteLine("3- 2nd Degree equation");
            Console.WriteLine("4- Exit the program");
            Console.WriteLine("choose from 1 to 4");
        }
        public static double addition(double value1, double value2)
        {
            double result = value1 + value2;
            return result;
        }
        public static double subtraction(double value1, double value2)
        {
            double result = value1 - value2;
            return result;
        }
        public static double multiplication(double value1, double value2)
        {
            double result = value1 * value2;
            return result;
        }
        public static double division(double value1, double value2)
        {
            double result = value1 / value2;
            return result;
        }
        
        public static void DisplayOperation(string operators)
        {
            if (operators == "+") { Console.WriteLine("You are doing Addition"); }
            else if (operators == "-") { Console.WriteLine("You are doing Subtraction"); }
            else if (operators == "*") { Console.WriteLine("You are doing multiplication"); }
            else { Console.WriteLine("You are doing Division"); }
        }
        static void Main(string[] args)
        {
            bool work = true;
            
            while(work)
            {
                // display the menu

                // let the user choose a valid task 
                int choosen;
                bool parseChecker;
                do
                {
                    menu();
                    Console.WriteLine();
                    Console.Write("Choose a task: ");
                    parseChecker = int.TryParse(Console.ReadLine(), out choosen);
                    Console.Clear();
                    
                } while (!parseChecker);

                /*  Start getting into each task
                 *  number 1 is Arithmetic Operation
                 *  number 2 is 1st degree equation
                 *  number 3 is 2nd degree equation
                 */
                if (choosen == 1) 
                {
                    // add an operator and make use it's valid
                    bool operatorChecker = true;
                    string op;
                    repeat1:
                    do
                    {
                        Console.Write("Which arithmetic Operation you want to do? (+ - * /): ");
                        op = Console.ReadLine();
                        
                        // make sure the user added only one operator
                        if (op.Length != 1)
                            goto repeat1;

                        // make sure the user added a valid operator
                        string operators = "+-*/";
                        if (!operators.Contains(op))
                        {
                            Console.Clear();
                            Console.WriteLine("Please add a valid operator");
                        }
                        else
                        {
                            operatorChecker = false;
                        }

                    } while (operatorChecker);

                    // make sure the user writes a valid  first number
                    double num1;
                    do
                    {
                        DisplayOperation(op);
                        Console.Write("Enter the frist number: ");
                        parseChecker = double.TryParse(Console.ReadLine(), out num1);
                        if (!parseChecker) { Console.Clear(); }
                    }while (!parseChecker);

                    // make sure the user writes a valid second number
                    double num2;
                    do
                    {
                        Console.Write("Enter the second number: ");
                        parseChecker = double.TryParse(Console.ReadLine(), out num2);
                        Console.Clear();
                    } while (!parseChecker);

                    // start making calculations based on the choosen operator
                    double showResult = 0;
                    switch (op)
                    {
                        case "+": showResult = addition(num1, num2); break;
                        case "-": showResult = subtraction(num1, num2); break;
                        case "*": showResult = multiplication(num1, num2); break;
                        case "/": showResult = division(num1, num2); break;
                        default: Console.WriteLine("unexpected crash"); break;
                    }

                    // display the result
                    Console.WriteLine("The result is: " + showResult);

                    // Ask the user if he/she wants to use the calculator again
                    Console.WriteLine("Do you want to do another operation? [Y/N]");
                    string useAgain = Console.ReadLine();
                    if (useAgain.ToUpper() == "Y")
                    {
                        Console.Clear();
                        goto repeat1;
                    }
                    Console.Clear();
                }
                else if (choosen == 2)
                {
                    /* 
                     *   the equation is ax + b = 0
                     *   ask the user to enter a and b 
                    */

                    // ask the user to enter (a) and make use it's valid
                    repeat2:
                    double a;
                    do
                    {
                        Console.Write("Enter the a: ");
                        parseChecker = double.TryParse(Console.ReadLine(), out a);
                        // make sure the value a is not zero 0
                        if (parseChecker)
                        {
                            if (a == 0) parseChecker = false;
                        }
                        Console.Clear();
                    }while(!parseChecker);

                    // ask the user to enter (b) and make use it's valid
                    double b;
                    do
                    {
                        Console.Write("Enter the b: ");
                        parseChecker = double.TryParse(Console.ReadLine(), out b);
                        Console.Clear();
                    } while (!parseChecker);

                    // do the calculation
                    double x = -b / a;
                    // show the result
                    Console.WriteLine("The result is: " + x);

                    // Ask the user if he/she wants to use the calculator again
                    Console.WriteLine("Do you want to do another 1st Degree Equation? [Y/N]");
                    string useAgain = Console.ReadLine();
                    if (useAgain.ToUpper() == "Y")
                    {
                        goto repeat2;
                    }
                    Console.Clear();
                }
                else if (choosen == 3)
                {
                    /*
                     * The 2nd degree equation is ax² + bx + c = 0
                     * Ask the user to input a, b and c
                    */

                    // Ask the user to enter the (a) and make use it's valid
                    repeat3:
                    double a;
                    do
                    {
                        Console.Write("Enter the value a: ");
                        bool parserChecker = double.TryParse(Console.ReadLine(), out a);
                        Console.Clear();
                    } while (!parseChecker);

                    // Ask the user to enter the (a) and make use it's valid
                    double b;
                    do
                    {
                        Console.Write("Enter the value b: ");
                        bool parserChecker = double.TryParse(Console.ReadLine(), out b);
                        Console.Clear();
                    } while (!parseChecker);

                    // Ask the user to enter the (a) and make use it's valid
                    double c;
                    do
                    {
                        Console.Write("Enter the value c: ");
                        bool parserChecker = double.TryParse(Console.ReadLine(), out c);
                        Console.Clear();
                    } while (!parseChecker);

                    // call the method to do the calculations
                    double d;

                    // claculate the delta
                    d = (b * b) - (4 * a * c);
                    if (d > 0)
                    {
                        double x1 = ((-b + Math.Sqrt(d)) / 2 * a);
                        double x2 = ((-b - Math.Sqrt(d)) / 2 * a);
                        Console.WriteLine("The result of x1: " + x1);
                        Console.WriteLine("The result of x2: " + x2);
                    }else if (d == 0)
                    {
                        double x0 = -b / (2 * a);
                        Console.WriteLine("The result of x20: " + x0);
                    }
                    else
                    {
                        Console.WriteLine("There is no solutions to this equation");
                    }

                    // Ask the user if he/she wants to use the calculator again
                    Console.WriteLine("Do you want to do another 1st Degree Equation? [Y/N]");
                    string useAgain = Console.ReadLine();
                    if (useAgain.ToUpper() == "Y")
                    {
                        goto repeat3;
                    }
                    //Console.Clear();
                }
                else if (choosen == 4)
                {
                    // exit the program
                    work = false;
                }
                

            }


        }
    }
}
