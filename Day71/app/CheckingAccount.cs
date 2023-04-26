using System;

namespace Learning;

class Checking : Bank
{
    public Checking(string firstname, string lastname, decimal money)
        : base(firstname, lastname, money){}
    public override void Withdraw(decimal val)
    {
        if(Balance - val < 0)
        {
            Balance -= (val + 35);
            Console.WriteLine($"You over drawn money with total of {val:C2}, you have exta fees of {35:C2}");
            Console.WriteLine("Now Your balance is " + Balance);
        }else
        {
            Balance -= val;
            Console.WriteLine($"you did a withdraw of {val:C2}");
        }
    }

}