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
        public static int NbDig(int n, int d)
        {
            string s = "";
            int counter = 0;
            for(int i=0; i<=n; i++)
            {
                s = Math.Pow(i,2).ToString();
                foreach(char v in s)
                {
                    if((int)Char.GetNumericValue(v) == d) counter++;
                }
            }
            return counter;
        }
       static void Main(string[] args)
        {
            Console.WriteLine(NbDig(5750,0));
        } 
    }        
}