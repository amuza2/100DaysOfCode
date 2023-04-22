using System;
using System.Linq;
using System.Text;
using System.IO;

namespace SoloLearn
{
    class Human
        {
            int Age {get; set;}
            public Human(int age) {this.Age = age;}

            public static bool operator> (Human a, Human b){
                return a.Age > b.Age;
            }

            public static bool operator< (Human a, Human b){
                return a.Age < b.Age;
            }
            public static bool operator== (Human a, Human b){
                return a.Age == b.Age;
            }
            public static bool operator!= (Human a, Human b){
                return a.Age != b.Age;
            } 
        }
    class Program
    {
        static void Output<T>(T[] value)
        {
            foreach(T i in value)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        

       static void Main(string[] args)
        {
            Human h1 = new Human(19);
            Human h2 = new Human(18);
            bool isGreater = h1 == h2;
            Console.WriteLine("h1 is greater then h2: " + isGreater);



        }  
    }        
}