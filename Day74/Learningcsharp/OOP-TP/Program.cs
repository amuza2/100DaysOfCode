using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TP
{
    public class Person
    {
        private string FirstName;
        public string LastName;
        public int Age;
        public int Telephone;

        public void setName(string name)
        {
            FirstName = name;
        }
        public string getAge() 
        {
            return FirstName;
        }
    }
    internal class Program
    {
        public static int Solution(int num)
        {
            string numString = num.ToString();
            string[] number = numString.ToCharArray().Select(c => c.ToString()).ToArray();
            
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i; j < number.Length; j++)
                {
                    if (int.Parse(number[j]) > int.Parse(number[i]))
                    {
                        string temp = number[j];
                        number[j] = number[i];
                        number[i] = temp;
                    }
                }
            }
            string tempString = "";
            foreach(string str in number)
            {
                tempString += str;
            }
            int result = int.Parse(tempString);
            return result;
        }
        static void Main(string[] args)
        {
            int a = Solution(12435);
            foreach(string s in a.ToString())
            {
                Console.WriteLine(s);
            }
            //Console.WriteLine(Solution(12435));
            
        }
    }
}
