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
    public virtual string CalculateFree()
    {
        return $"Fee of {name} is {numberOfStuff * 5}";
    }
}

class Worker : Staff
{
    public Worker(int n, string n_ame) : base(n_ame)
    {
        numberOfStuff = n;
    }
}

class VipWorker : Staff
{
    int bonus;
    public VipWorker(int bs, int n, string n_ame) : base(n_ame)
    {
        bonus = bs;
        numberOfStuff = n;
        Console.WriteLine($"VIP {n_ame} created");
    }

    public override string CalculateFree()
    {
        //return base.CalculateFree();
        return $"Fee of {name} is {numberOfStuff * 5 + bonus}";
    }
}

class Program{
    static void Main(string[] args)
        {
            Staff[] companyMember = new Staff[5];
            int index = 0;
            companyMember[index++] = new Worker(5, "med");
            companyMember[index++] = new Worker(10, "amuza");
            companyMember[index++] = new VipWorker(5, 12, "Chami");
            Console.WriteLine(typeof(Worker));
            foreach(Staff s in companyMember)
            {
                if(s != null)
                {
                    Console.Write(s.GetType() + " ");
                    Console.WriteLine(s.CalculateFree());

                }
            }
            

            
        }
}