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
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("Uno", 1);
            d.Add("One", 1);
            d.Add("Two", 2);
            Console.WriteLine(d.ContainsKey("One"));
            d.Remove("One");
            Console.WriteLine(d.ContainsKey("One"));

            foreach(int s in d.Values)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine($"\nCount: {d.Count}");


        }
    }        
}