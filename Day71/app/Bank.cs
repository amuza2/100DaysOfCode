using System;
namespace Learning;

class Bank
{
    decimal _balance;
    public decimal Balance 
    {
        get {return _balance;}
        set{_balance = value;}
    }
    protected string FirstName {get; set;}
    protected string LastName {get; set;}
    public string AccountOwner {
        get => $"{FirstName} {LastName}";
    }
    public Bank(string firstname, string lastname, decimal money){
        FirstName = firstname;
        LastName = lastname;
        Balance += money;
    }
    public void Deposit(decimal val)
    {
        Balance += val;
        Console.WriteLine($"You did a deposite of {val:C2}");
    }
    public virtual void Withdraw(decimal val)
    {
        Balance -= val;
    }

}