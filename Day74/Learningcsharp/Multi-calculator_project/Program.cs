using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_calculator_project
{
    internal class Program
    {
        public static void menu()
        {
            string spaceLeft = "              ";
            string spaceRight = "              ";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("****************************************************");
            Console.Write(@"
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
");
            Console.WriteLine("****************************************************");
            Console.ResetColor();
            Console.WriteLine("****************************************************");
            Console.WriteLine($"*{spaceLeft}1- Simple Calculator  {spaceRight}*" );
            Console.WriteLine($"*{spaceLeft}2- 1st Degree equation{spaceRight}*");
            Console.WriteLine($"*{spaceLeft}3- 2nd Degree equation{spaceRight}*");
            Console.WriteLine($"*{spaceLeft}4- Play a guess game  {spaceRight}*");
            Console.WriteLine($"*{spaceLeft}5- Exit the program   {spaceRight}*");
            Console.WriteLine("**************** Choose from 1 to 5 ****************");
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
            if (operators == "+") { Console.WriteLine("*               You are doing Addition              *"); }
            else if (operators == "-") { Console.WriteLine("*             You are doing Subtraction             *"); }
            else if (operators == "*") { Console.WriteLine("*             You are doing multiplication          *"); }
            else { Console.WriteLine("*               You are doing Division              *"); }
        }
        public static double CalculateDelta(double a, double b, double c)
        {
            return (b * b) - (4 * a * c);
        }
        public static void DeltaGreaterThanZero(double d, double a, double b)
        {
            double x1 = ((-b + Math.Sqrt(d)) / 2 * a);
            double x2 = ((-b - Math.Sqrt(d)) / 2 * a);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"*           The result of x1: {string.Format("{0:F2}",x1)}                  *");
            Console.WriteLine($"*           The result of x2: {string.Format("{0:F2}",x2)}                  *");
            Console.ResetColor();
        }
        public static void DeltaEqualToZero(double a, double b)
        {
            double x0 = -b / (2 * a);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"         The result of x0: {string.Format("{0:F2}", x0)}         *");
            Console.ResetColor();
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
                    parseChecker = int.TryParse(Console.ReadLine(), out choosen);
                    Console.Clear();
                    
                } while (!parseChecker);

                /*  Start getting into each task
                 *  number 1 is Arithmetic Operation
                 *  number 2 is 1st degree equation
                 *  number 3 is 2nd degree equation
                 *  number 4 is a guessing game
                 *  number 5 is exit the program
                 */
                if (choosen == 1) 
                {
                    // add an operator and make use it's valid
                    bool operatorChecker = true;
                    string op;
                    repeat1:
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("******************* Simple Calculator ***************");
                        Console.ResetColor();
                        Console.WriteLine("*Which arithmetic Operation you want to do(+ - * /):*");
                        //Console.WriteLine("*****************************************************");
                        op = Console.ReadLine();

                        // make sure the user added only one operator
                        if (op.Length != 1)
                            goto repeat1;

                        // make sure the user added a valid operator
                        string operators = "+-*/";
                        if (!operators.Contains(op))
                        {
                            Console.Clear();
                            Console.WriteLine("*              Please add a valid operator              *");
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
                        Console.WriteLine("*               Enter the frist number:             *");
                        parseChecker = double.TryParse(Console.ReadLine(), out num1);
                        if (!parseChecker) { Console.Clear(); }
                    }while (!parseChecker);

                    // make sure the user writes a valid second number
                    double num2;
                    do
                    {
                        Console.WriteLine("*               Enter the second number:            *");
                        parseChecker = double.TryParse(Console.ReadLine(), out num2);
                        if (!parseChecker) 
                        { 
                            Console.Clear();
                            DisplayOperation(op);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("******************* Simple Calculator ***************");
                            Console.ResetColor();
                            Console.WriteLine($"*              Enter the frist number: {num1}        *");
                        }else if (parseChecker && num2 == 0)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("******************* Simple Calculator ***************");
                            Console.ResetColor();
                            Console.WriteLine($"*              Enter the frist number: {num1}        *");
                            Console.WriteLine("*            You can't add the value zero           *");
                            parseChecker = false;
                        }
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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"*                   The result is: {showResult}               *");
                    Console.ResetColor();

                    // Ask the user if he/she wants to use the calculator again
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("*     Do you want to do another operation? [Y/N]    *");
                    Console.ResetColor();
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
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("********************** ax + b = 0 *******************");
                        Console.ResetColor();
                        Console.WriteLine("*                   Enter the value a:              *");
                        parseChecker = double.TryParse(Console.ReadLine(), out a);
                        // make sure the value a is not zero 0
                        if (parseChecker)
                        {
                            if (a == 0) parseChecker = false;
                        }else { Console.Clear(); }
                    }while(!parseChecker);

                    // ask the user to enter (b) and make use it's valid
                    double b;
                    do
                    {
                        Console.WriteLine("*                   Enter the value b:              *");
                        parseChecker = double.TryParse(Console.ReadLine(), out b);
                        if (!parseChecker) 
                        { 
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("********************** ax + b = 0 *******************");
                            Console.ResetColor();
                            Console.WriteLine($"*                   Enter the a: {a}            ");
                        }
                    } while (!parseChecker);

                    // do the calculation
                    double x = -b / a;
                    // show the result
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"*                   The result is: {x}               *");
                    Console.ResetColor();
                    // Ask the user if he/she wants to use the calculator again
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("*     Do you want to do another operation? [Y/N]    *");
                    Console.ResetColor();
                    string useAgain = Console.ReadLine();
                    if (useAgain.ToUpper() == "Y")
                    {
                        Console.Clear();
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
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("****************** ax² + b + c = 0 ******************");
                        Console.ResetColor();
                        Console.WriteLine("*                Enter the value a:                 *");
                        parseChecker = double.TryParse(Console.ReadLine(), out a);
                        if (parseChecker)
                        {
                            if (a == 0)
                            {
                                parseChecker = false;
                            }
                        }
                        if (!parseChecker) { Console.Clear(); }
                    } while (!parseChecker);

                    // Ask the user to enter the (a) and make use it's valid
                    double b;
                    do
                    {
                        Console.WriteLine("*                Enter the value b:                 *");
                        parseChecker = double.TryParse(Console.ReadLine(), out b);
                        if (!parseChecker) { 
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("****************** ax² + b + c = 0 ******************");
                            Console.ResetColor();
                            Console.WriteLine($"*                Enter the value a: {a}               *"); }
                    } while (!parseChecker);

                    // Ask the user to enter the (a) and make use it's valid
                    double c;
                    do
                    {
                        Console.WriteLine("*                Enter the value c:                 *");
                        parseChecker = double.TryParse(Console.ReadLine(), out c);
                        if (!parseChecker) {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("****************** ax² + b + c = 0 ******************");
                            Console.ResetColor();
                            Console.WriteLine($"*                Enter the value a: {a}               *");
                            Console.WriteLine($"*                Enter the value b: {b}               *"); }
                    } while (!parseChecker);

                    // claculate the delta
                    double d;
                    d = CalculateDelta(a, b, c);

                    // Check if Delta is Geater, Smaller or Equal to Zero than show the result accordingly
                    if (d > 0)
                    {
                        DeltaGreaterThanZero(d, a, b);
                    }
                    else if (d == 0)
                    {
                        DeltaEqualToZero(a, b);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("*        There is no solutions to this equation     *");
                        Console.ResetColor();
                    }

                    // Ask the user if he/she wants to use the calculator again
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("*     Do you want to do another operation? [Y/N]    *");
                    Console.ResetColor();
                    string useAgain = Console.ReadLine();
                    if (useAgain.ToUpper() == "Y")
                    {
                        Console.Clear();
                        goto repeat3;
                    }
                    Console.Clear();
                }
                else if (choosen == 4)
                {
                // A geussing game
                    startPlaying:

                    // The correct answer integer
                    int numberGame = 10; 
                    
                    // generate a random integer between 0 and the correct answer (numberGame)
                    Random ran = new Random();
                    int choosedNumber = 0;  
                    choosedNumber = ran.Next(0, numberGame);
                    
                    bool play = true;
                    int guessCounter = 0;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("****************** Guessing Game ******************");
                    Console.ResetColor();
                    while (play)
                    {
                        // Ask the user to enter an number or quit
                        Console.WriteLine($"*   I am thinking of a number between 0 and {numberGame}    *");
                        Console.WriteLine("*      enter a number or write Q to quit:         *");
                        int number = 0;
                        string SNumber = Console.ReadLine();
                        if (SNumber.ToUpper() == "Q") { Console.Clear(); break; }

                        // make sure it's an integer
                        bool succeed = int.TryParse(SNumber, out number);
                        if (!succeed)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("****************** Guessing Game ******************");
                            Console.ResetColor();
                            Console.WriteLine("*           Please add a valid number             *");
                        }
                        else
                        {
                            guessCounter++;
                            if (number == choosedNumber)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"*       You got it right in {guessCounter} guesses              *");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("*       Do you want to play again [Y/N]?           *");
                                Console.ResetColor();
                                string playGameAgain = Console.ReadLine();
                                if (playGameAgain.ToUpper() == "Y")
                                {
                                    Console.Clear();
                                    goto startPlaying;
                                }
                                else
                                {
                                    Console.Clear();
                                    play = false;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("****************** Guessing Game ******************");
                                Console.ResetColor();
                                Console.Write("* Nope, {0} than that   |", number < choosedNumber ? "higher" : "lower");
                                Console.WriteLine($"   Guessing Number: {guessCounter}  *");
                            }
                        }
                    }
                }
                else if (choosen == 5)
                {
                    // exit the program
                    work = false;
                }
            }
            //Environment.Exit(0);
            Thread.Sleep(100);


        }
    }
}
