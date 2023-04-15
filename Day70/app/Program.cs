using System;

namespace SoloLearn
{
    class Program
    {
        static void AddSpace(ref string result, string part)
        {
            if(result.Length != 0)
            {
                result += $" {part}";
            }
            else
            {
                result += part;
            }
        }
        static void Output(string[] value)
        {
            foreach(string i in value)
            {
                Console.WriteLine(i);
            }
        }
        static string Remove(string s)
        {
            string[] words = s.Split(' ');
            //Output(words);
            string result = "";
            foreach(string k in words)
            {
                //Console.WriteLine(">>> " + k);
                if(!k.Contains('!')) AddSpace(ref result, k);
                else
                {
                    int counter = 0;
                    foreach(char c in k)
                    {
                        if(c == '!') counter++;
                    }
                    if(counter != 1)
                    {
                        AddSpace(ref result, k);
                    } 
                }
            }
            return result;
        }
       static void Main(string[] args)
        {
            Console.WriteLine(Remove("!Hi! ! !Hi!"));
            Console.WriteLine(Remove("Hi! Hi!"));
            Console.WriteLine(Remove("Hi !Hi! Hi!"));
            Console.WriteLine(Remove("Hi! !Hi! Hi!"));
            Console.WriteLine(Remove("Hi! Hi!! Hi!"));
            
        } 
    }        
}