using System;
using System.Linq;
using System.Text;

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

        struct Book
        {
            public string title;
            public double price;
            public string author;
        }
        
       static void Main(string[] args)
        {
            Book b;
            b.title = "Test";
            b.price = 123.99;
            b.author = "Mohammed";

            Console.WriteLine(b.title);

        } 
    }        
}