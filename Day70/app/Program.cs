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
            Stack<int> s = new Stack<int>();
            s.Push(30);
            s.Push(31);
            s.Push(32);
            Console.Write("Stack: ");
            foreach(int i in s) Console.Write(i + " "); 
            Console.Write("\nCount: " + s.Count);
            Console.Write("\nTop: " + s.Peek());
            Console.Write("\nPop: " + s.Pop());
            Console.Write("\nStack: ");
            foreach(int i in s) Console.Write(i + " ");
            Console.WriteLine("\nCount: " + s.Count);
            //s.Clear();
            bool isThere = s.Contains(30);
            Console.WriteLine(isThere);            

        }
    }        
}