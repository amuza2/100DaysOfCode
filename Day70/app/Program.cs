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
            Book b1 = new Book("Intoduction to C#", "Mohammed", 175, 20);
            Magazine m1 = new Magazine("Build Cross-platform mobile apps with MAUI", "Mohammed", 250, 10);
            //Console.WriteLine(b1.GetInfo());
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b1.Price);
            Console.WriteLine(m1.GetDescription());
            Console.WriteLine(m1.Price);

        }  
    }        
}