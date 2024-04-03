using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace exercice1
{ 
    public static class Program
    {
       
        private static void Main(string[] args)
        {
            decimal Price = 12648.2156484M;
            string formattedNumber = String.Format("{0:0.#}", Price);
            Console.WriteLine(formattedNumber);



            
            

           

        }

        
    }

}

