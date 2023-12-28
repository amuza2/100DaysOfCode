using System;
using System.Diagnostics;

namespace app1;

class Program
{
    public int CalculateDiscount(int amount, int discountAmount, int minimumAmount)
    {
        int amountToBePaid;
        if (amount > minimumAmount)
        {
            amountToBePaid = amount - discountAmount;
        }
        else
        {
            amountToBePaid = amount;
        }
        return amountToBePaid;
    }
    static void Main(string[] args)
    {
        // Debug.Assert(CalculateDiscount(5000, 10, 4500) == 4990);
        // Debug.Assert(CalculateDiscount(5000, 10, 5500) == 5000);
        // System.Console.WriteLine(CalculateDiscount(5000, 5500, 4500));
    }

}