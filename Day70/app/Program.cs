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
            Stack<int> intStack = new Stack<int>();
            intStack.Push(30, 29, 28);
            intStack.Get();
        } 
        
        class Stack<T>
        {
            int index = 0;
            T[] innerArray = new T[100];
            public void Push(T item1, T item2, T item3)
            {
                innerArray[index++] = item1;
                innerArray[index++] = item2;
                innerArray[index++] = item3;
            }
            public void Get()
            {
                foreach(T item in innerArray)
                {
                    Console.WriteLine(item + " ");
                }
            }
            public void CheckArray(int index1, int index2, int index3)
            {
                Console.WriteLine($"{innerArray[index1]} - {innerArray[index2]} - {innerArray[index3]}");
            }
        }
    }        
}