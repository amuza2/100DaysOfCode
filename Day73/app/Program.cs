using System;
namespace learning;

class Employee
{
    //int matricule;
    int category;
    public int Category {set; get;}
    //public int Service {set; get};
    //public string Matricule {set; get};
    public Employee(int cat)
    {
        category = cat;
    }
    public int getCategoty()
    {
        return category;
    }
}

class Program{

    static void Main(string[] args)
        {
            Employee e = new Employee(15);
            e.Category = 20;
            Console.WriteLine(e.Category);
            Console.WriteLine(e.getCategoty());

        }
}