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
        static string Calculator(string txt)
        {
            string[] s = txt.Split(" ");            
            int part1 = s[0].Length,
                part2 = s[s.Length - 1].Length,
                    c = txt.Contains('+') ? part1 + part2:
                        txt.Contains('-') ? part1 - part2:
                        txt.Contains('*') ? part1 * part2:
                                    part1 / part2;
            return new StringBuilder().Insert(0, ".", c).ToString();
        }
       static void Main(string[] args)
        {
            Console.WriteLine($">> " + Calculator("..... + ..............."));
            Console.WriteLine(">> " + Calculator("..... - ..."));
            Console.WriteLine(">> " + Calculator("..... - ."));
            Console.WriteLine(">> " + Calculator("...... * ..."));
            Console.WriteLine(">> " + Calculator("..... * .."));
            
        } 
    }        
}