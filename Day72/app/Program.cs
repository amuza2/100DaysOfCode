using System;
namespace Learning;


abstract class Shape
{
    public abstract double Area();
    public void Dispplay() {Console.WriteLine("This is a shape.");}
}

class Rectangle : Shape
{
    public double Width {get; set;}
    public double Height {get; set;}
    public override double Area()
    {
        return Width * Height;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Rectangle r = new Rectangle();
        r.Width = 20;
        r.Height = 2;
        Console.WriteLine(r.Area());
        r.Dispplay();
    }
}
