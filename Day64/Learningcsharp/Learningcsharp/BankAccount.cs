using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learningcsharp
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner{ get; set; }
        public decimal Balance 
        { 
            get
            {
                Decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        } 
        private static int accountNumber = 1;
        private List<Transaction> allTransactions = new List<Transaction>();
        public BankAccount(string owner)
        {
            Owner = owner;
            this.Number = accountNumber.ToString();
            accountNumber++;
        }

        public void MakeDeposite(decimal amount, DateTime date, string note)
        {

        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}
