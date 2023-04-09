using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
class Program
{
    public void Palindrome(string value)
    {
        bool pal = true;
        int odd = 0;
        int len = value.Length;

        if(len % 2 == 1) odd = 1;
        for(int i = 0; i < len; i++)
        {
            if(value[i] != value[len - 1 - i])
            {
                Console.WriteLine($"{value[i]} at index {i} != {value[len - 1]} at index {len - i - 1}");
                pal = false;
                break;
            }
            if(i == (len / 2) + odd) break;
        }
        if(pal == false) Console.WriteLine("It's not!");
        else Console.WriteLine("It is!");
        Console.WriteLine("----------------------");
    }
    
    static void Main(string[] args)
    {
        Program p = new Program();
        p.Palindrome("mohammed");
        p.Palindrome("radar");
        p.Palindrome("abccba");
    }
}
}
