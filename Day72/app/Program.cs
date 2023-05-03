using System;
namespace Learning;

interface IShape 
{
    void Draw();
    void Finish(){
        Console.WriteLine("Done!");
    }
}
class Circle : IShape 
{
    public void Draw() {
        Console.WriteLine("Circle Draw");
    }
    public void Finish(){
        Console.WriteLine("End!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        IShape c = new Circle();
        Circle a = new Circle();
        c.Finish();
        a.Finish();       
    }
}