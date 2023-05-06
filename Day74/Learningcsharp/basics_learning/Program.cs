using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace SoloLearn
{
    class Staff
    {
        protected string name;
        int numberOfStuff;
        public int NumberOfStuff
        {
            get { return numberOfStuff; }
            set
            {
                if (value > 0) numberOfStuff = value;
            }
        }
        public Staff(string n_ame)
        {
            name = n_ame;
            Console.WriteLine($"Account of name: {name} created");
        }
    }

    class Worker : Staff
    {
        public Worker(string n, int id, string n_ame) : base(n_ame)
        {
            Console.WriteLine($"Child name is {n} and ID is {id}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}