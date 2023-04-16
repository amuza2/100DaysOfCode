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
        static string Calculator(string txt)
        {
            string result = "";
            string[] s = txt.Split(' ');
            int part1 = s[0].Length;
            int part2 = s[s.Length - 1].Length;
            string op = s[1];
            int c = 0;
            if(op == "+")
            {
                c = part1 + part2;
            }else if(op == "-")
            {
                c = part1 - part2;
            }else if(op == "*")
            {
                c = part1 * part2;
            }else
            {
                c = part1 / part2;
            }
            for(int i=0; i<c; i++)
            {
                result += ".";
            }
            return result;
        }
       static void Main(string[] args)
        {
            Console.WriteLine($">> " + Calculator("..... + ..............."));
            /*Console.WriteLine(">> " + Calculator("..... - ..."));
            Console.WriteLine(">> " + Calculator("..... - ."));
            Console.WriteLine(">> " + Calculator("...... * ..."));
            Console.WriteLine(">> " + Calculator("..... * .."));
            */
        } 
    }        
}