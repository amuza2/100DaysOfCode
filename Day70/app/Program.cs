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
            HashSet<int> hs = new HashSet<int>();
            hs.Add(5);
            hs.Add(10);
            hs.Add(15);
            hs.Add(0);

            foreach(int i in hs)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nCount: " + hs.Count);

            HashSet<int> hs2 = new HashSet<int>();
            hs2.Add(10);
            hs2.Add(15);
            hs2.Add(0);

        }
    }        
}