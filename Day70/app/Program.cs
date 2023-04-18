using System;
using System.Linq;
using System.Text;
using System.IO;

namespace SoloLearn
{
    class Program
    {
        static void Output(string[] value)
        {
            foreach(string i in value)
            {
                Console.WriteLine(i);
            }
        }
        
       static void Main(string[] args)
        {
            int a = 10;
            string b = "Mohammed";
            Printer.Print(b);

        } 
        
        class Printer
        {
            public static void Print<T>(T a)
            {
                Console.WriteLine(a);
            }
        }
    }        
}