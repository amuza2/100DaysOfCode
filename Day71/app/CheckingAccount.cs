using System;

namespace Learning;

class Checking : Bank
{
    const decimal OVERDRAW_CHARGE = 35.0m;
    public Checking(string firstname, string lastname, decimal money)
        : base(firstname, lastname, money){}
    public override void Withdraw(decimal val)
    {
        if(val > Balance)
        {
            val += OVERDRAW_CHARGE;
            //Console.WriteLine($"You over drawn money with total of {val:C2}, you have exta fees of {OVERDRAW_CHARGE:C2}");
            //Console.WriteLine("Now Your balance is " + Balance);
        }
        //Console.WriteLine($"you did a withdraw of {val:C2}");
        base.Withdraw(val);
        
    }

}