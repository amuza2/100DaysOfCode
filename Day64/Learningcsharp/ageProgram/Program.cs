using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageProgram
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
             *  j = 0 ==> ---*---
             *  j = 1 ==> --***--
             *  j = 2 ==> -*****-
             *  j = 3 ==> *******
             * 
             *  j = 0 ==> ---*--
             *  j = 1 ==> --**--
             *  j = 2 ==> -***--
             *  j = 3 ==> ****--
             * */
            int height = 5;
            int width = 7;
            string s = "";
            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    s += "*";
                }
                Console.WriteLine(s);
                s = "";
            }
        }
    }
}
