﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Learningcsharp
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }
        public Transaction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date= date;
            Notes = note;
        }
    }
}
