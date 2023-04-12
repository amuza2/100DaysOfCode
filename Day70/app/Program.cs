using System;

namespace SoloLearn;
class Program
{    
    class Dog
    {
        public const int ONE = 1;
        public static int count = 1;
        public Dog()
        {
            count++;
        }
        public static void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }
    static void Main(string[] args)
    {
        Dog a = new Dog();
        Console.WriteLine(Dog.ONE);
    }
}

