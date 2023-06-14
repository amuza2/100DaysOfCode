using System;
using System.Text.RegularExpressions;

namespace Learning;

class Nombre{
    int nombre;
    public Nombre(int num){nombre = num;}
    public int Numbre{get{return nombre;} set{Numbre = value;}}
    public void getNombre(){Console.WriteLine(Numbre);}
}
class Test{
    public bool Compaire(object obj1, object obj2){
        if(obj1 == obj2) return true;
        else return false;
    }
} 
class Program
{
    static void Main(string[] args)
    {
        Nombre n1 = new Nombre(5);
        Nombre n2 = new Nombre(5);
        Test t1 = new Test();
        Console.WriteLine(t1.Compaire(n1, n2));

        // Savings p1 = new Savings("Mohammed", "Chami", 0.025m, 1000m);
        // Console.WriteLine("Saving Account: " + p1.AccountOwner + " " + p1.Balance.ToString("C2"));
        // p1.Deposit(150);
        // p1.Withdraw(100);
        // Console.WriteLine("Your balance is: " + p1.Balance.ToString("C2"));
        // p1.Withdraw(50);
        // p1.ApplyInterest();
        // Console.WriteLine("Your balance is: " + p1.Balance.ToString("C2"));
        // p1.Withdraw(2000);
        // Console.WriteLine("Your balance is: " + p1.Balance.ToString("C2"));



    }
}