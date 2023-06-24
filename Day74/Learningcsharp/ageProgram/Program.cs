using System;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

class Program
{
    class Shape
    {

    }
    class Square : Shape
    {

    }
    static void Main(string[] args)
    {
        Shape shape = new Shape();
        Square square = new Square();
        Shape s = new Square();

        Console.WriteLine(shape.GetType());
        Console.WriteLine(square.GetType());
        Console.WriteLine(s.GetType());
    }
        
}