using System;
using System.Text.RegularExpressions;

namespace Learning;
class Program
{
    static void Main(string[] args)
    {
        Savings p1 = new Savings("Mohammed", "Chami", 0.025m, 1000m);
        Console.WriteLine("Saving Account: " + p1.AccountOwner + " " + p1.Balance.ToString("C2"));
        p1.Deposit(150);
        p1.Withdraw(100);
        Console.WriteLine("Your balance is: " + p1.Balance.ToString("C2"));
        p1.Withdraw(50);
        p1.ApplyInterest();
        Console.WriteLine("Your balance is: " + p1.Balance.ToString("C2"));
        p1.Withdraw(2000);
        Console.WriteLine("Your balance is: " + p1.Balance.ToString("C2"));



    }
}