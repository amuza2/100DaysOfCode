// See https://aka.ms/new-console-template for more information
using System;
(int x, int y) tup = (5, 12);
var tup2 = ("this is a string", 12.5f);
static (int a, int b) myFunction(int a, int b)
{
    return (a + b, a * b);
}

(int, int) result = myFunction(6, 12);
Console.WriteLine($"The first value is {result.Item1}\nThe second value is {result.Item2}");