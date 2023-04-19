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
            SortedList<string, int> sl = new SortedList<string, int>();
            sl.Add("Mohammed", 30);
            sl.Add("Chami", 31);
            sl.Add("amuza", 29);
            Console.WriteLine("Sorted List: ");
            foreach(string s in sl.Keys) Console.WriteLine(s +": " + sl[s]);
            Console.WriteLine("\nCount: " + sl.Count);

        }
    }        
}