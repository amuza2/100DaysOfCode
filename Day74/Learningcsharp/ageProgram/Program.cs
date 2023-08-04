using System;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

class Program
{
    
    static void Main(string[] args)
    {
        using (var writer = new FileStream("products.csv", FileMode.CreateNew, FileAccess.Write))
        {
            string dataToAppend1 = "Macbook Pro Mid 2014,8GB,512GB SSD,USB 3.0x3,15 screen,Refurbished,750";
            writer.(dataToAppend1);
            string dataToAppend2 = "Macbook Pro Late 2019,16GB,512GB SSD,USB 3.0x3,15 screen,Refurbished,1250";
            writer.WriteLine(dataToAppend2);
        }
            Console.WriteLine("CSV file create successfully!");
    }
        
}