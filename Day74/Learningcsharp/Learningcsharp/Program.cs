using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.IO;

namespace Learningcsharp
{
    class Program
    {
        public static void Main()
        {
            //Create reference variables
            Product product1, product2, product3;

            //Create objects
            product1= new Product();
            product2= new Product();
            product3= new Product();

            //Initialize fields
            product1.SetProductID(1001);
            product2.SetProductID(1002);
            product3.SetProductID(1003);
            product1.SetProductName("A");
            product2.SetProductName("B");
            product3.SetProductName("C");
            product1.SetCost(4000);
            product2.SetCost(5000);
            product3.SetCost(6500);


            product1.CalculateTax();
            product2.CalculateTax();
            product3.CalculateTax();
            Console.WriteLine(product1.GetTax());
            Console.WriteLine(product2.GetTax());
            Console.WriteLine(product3.GetTax());
            Console.WriteLine(product1.GetDateOfPurchase());

        }
    }
}
