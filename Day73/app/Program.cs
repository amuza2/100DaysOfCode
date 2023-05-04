using System;
namespace learning;

class Staff
{
    protected string name;
    protected int numberOfStuff;
    public int NumberOfStuff
    {
        get{return numberOfStuff;}
        set
        {
            if(value > 0) numberOfStuff = value;
        }
    }
    public Staff(string n_ame)
    {
        name = n_ame;
        Console.WriteLine($"Account of name: {name} created");
    }
    public string CalculateFree()
    {
        return $"Fee of {name} is {numberOfStuff * 5}";
    }
}

class Worker : Staff
{
    public Worker(int n, string n_ame) : base(n_ame)
    {
        Console.WriteLine($"Child name is {n_ame} and num is {n}");
    }
}


class Program{

    static void Main(string[] args)
        {
            Worker w1 = new Worker(5, "med");
            Worker w2 = new Worker(10, "amuza");
            
        }
}