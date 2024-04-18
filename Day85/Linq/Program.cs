namespace Program
{
    class Linq
    {
        static void Main(string[] args)
        {
            var actions = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                var closurei = i;
                actions.Add(() => Console.WriteLine($"MyAction: i={closurei}"));
            }
            foreach (var action in actions)
            {
                action();
            }
        }
    }  
}