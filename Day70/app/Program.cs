using System;
using System.Linq;

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
        static bool PowerOfTwo(int n)
        {
            string res = "";
            for(int i = 0; i < n + 1; i++)
            {
                res += $" {Math.Pow(2,i)}";
                if(Math.Pow(2,i) > n) break;
            }
            string[] res2 = res.Split(' ');
            if(res2.Contains($"{n}")) return true;
            return false;
        }
       static void Main(string[] args)
        {
            Console.WriteLine("464280 >> " + PowerOfTwo(464280));
            Console.WriteLine("4096 >> " + PowerOfTwo(4096));
            Console.WriteLine("333 >> " + PowerOfTwo(333));
            Console.WriteLine("2 >> " + PowerOfTwo(2));
            Console.WriteLine("5 >> " + PowerOfTwo(5));
            
        } 
    }        
}