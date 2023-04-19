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
            Queue<int> q = new Queue<int>();
            q.Enqueue(5);
            q.Enqueue(10);
            q.Enqueue(15);
            Console.WriteLine("Queue: ");
            foreach(int i in q) Console.Write(i + " ");
            Console.WriteLine("\nCount: " +q.Count);
            Console.WriteLine("Dequeue: " + q.Dequeue());
            Console.Write("Queue: ");
            int[] arr = q.ToArray();
            Array.Sort(arr);
            foreach(int i in arr) Console.Write(i + " ");
            Console.WriteLine("\nCount: " + arr.Count());        

        }
    }        
}