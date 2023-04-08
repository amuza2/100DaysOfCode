// See https://aka.ms/new-console-template for more information
namespace selfLearning;
class Person
{
    public int Age {get; set;}
}    
class program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.Age = 15;
        Console.WriteLine(p1.Age);
    }
}
