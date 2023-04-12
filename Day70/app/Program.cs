using System;

namespace SoloLearn;
class Program
{    
    class Animal
    {
        public virtual void SayHi()
        {
            Console.WriteLine("Hi I am Animal");
        }
    }
    class Cat : Animal
    {
        public override void SayHi()
        {
            Console.WriteLine("Hi I am Cat");
        }
    }
    class Dog : Animal
    {
        public override void SayHi()
        {
            //base.SayHi();
            Console.WriteLine("Hi I am Dog");
        }
    }
    static void Main(string[] args)
    {
        Cat c = new Cat();
        c.SayHi();
        Dog d = new Dog();
        d.SayHi();
    }
}

