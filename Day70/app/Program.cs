using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn;
class Program
{    
    static void Main(string[] args)
    {
        String[] pairs = { "Color1=red", "Color2=green", "Color3=blue",
                 "Title=Code Repository" };
        foreach (var pair in pairs) 
        {
            int position = pair.IndexOf("=");
            if (position < 0)
                continue;
            Console.WriteLine($"Key: {pair.Substring(0, position)}, Value: '{pair.Substring(position + 1)}'");
                            
        }
    }
}

