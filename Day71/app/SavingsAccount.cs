using System;

namespace Learning;

class Savings : Bank
{
    int _withdrawCounter = 0;
    int WITHDRAWLIMIT = 3;
    int WITHDRAWCHARGE = 2;
    decimal _interestRate;
    public Savings(string firstname, string lastname, decimal interestrate, decimal money)
        : base (firstname, lastname, money)
        {
            _interestRate = interestrate;
        }

    public override void Withdraw(decimal val)
    {
        
        if(val > Balance)
        {
            Console.WriteLine("You can't withdraw more then you have");
        }else
        {
            base.Withdraw(val);
            _withdrawCounter++;
            Console.WriteLine($"you did a withdraw of {val:C2}");
            if(_withdrawCounter >= WITHDRAWLIMIT)
            {
                base.Withdraw(WITHDRAWCHARGE);
                Console.WriteLine($"More than 3 withdraws - extra charge {WITHDRAWCHARGE:C2}");
            }
        }
        
    }
    public void ApplyInterest()
    {
        Balance += (Balance * _interestRate);
    }
}