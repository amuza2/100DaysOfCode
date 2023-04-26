using System;

namespace Learning;

class Savings : Bank
{
    int _withdrawCounter = 3;
    decimal _interestRate;
    public Savings(string firstname, string lastname, decimal interestrate, decimal money)
        : base (firstname, lastname, money)
        {
            _interestRate = interestrate;
        }

    public override void Withdraw(decimal val)
    {
        int withdrawFee = 2;
        if(_withdrawCounter > 0) withdrawFee = 0;
        if(Balance - (val + withdrawFee) < 0)
        {
            Console.WriteLine("You can't withdraw more then you have");
        }else
        {
            Balance -= (val + withdrawFee);
            _withdrawCounter--;
            Console.WriteLine($"you did a withdraw of {val:C2}");
        }
    }
    public void ApplyInterest()
    {
        decimal interest = Balance * _interestRate;
        Balance += interest;
    }
}