namespace Program
{
    public delegate string Greetings(string name);
    class Linq
    {
        static void Main(string[] args)
        {
           Greetings obj = (name) =>
           {
                return $"Hello {name} welcome to Dotnet!";
           };
           string GreetingsMessage = obj.Invoke("Mohammed");
           System.Console.WriteLine(GreetingsMessage);

        }
    }
}