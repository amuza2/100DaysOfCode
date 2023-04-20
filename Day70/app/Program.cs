using System;
using System.Linq;
using System.Text;
using System.IO;

namespace SoloLearn
{
    class Program
    {
        static void Output<T>(T[] value)
        {
            foreach(T i in value)
            {
                Console.WriteLine(i);
            }
        }
        public static string IsItANum(string str)
        {
            string res = "";
            bool AddValue = false;

            foreach(char s in str)
            {
                if(s == '0')
                {
                    AddValue = true;
                }
                if(AddValue)
                {
                    bool isDigit = Char.IsDigit(s);
                    if(isDigit) res += s;
                }  
            }
            if(res.Length == 11) {return res;}

            return "Not a phone number";
        }
       static void Main(string[] args)
        {
            string res = IsItANum("0192387415456");
            Console.WriteLine(res);
        }
    }        
}