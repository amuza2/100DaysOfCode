using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;

namespace SoloLearn
{
    
    class Program
    {
        static void Output<T>(T[] value)
        {
            foreach(T i in value)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        

       static void Main(string[] args)
        {
            Book b1 = new Book("C# for starters", "Mohammed", 255, 35);
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1.ToString('F'));
            Console.WriteLine(b1.ToString('B'));

        }  
    }        
}