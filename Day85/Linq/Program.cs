namespace Program
{
    class Linq
    {
        static void Main(string[] args)
        {
            var colors = new List<string> { "red", "green",};
            colors.Add("orange");
            colors.AddRange(new string[] {"yellow", "pink"});
            colors.Insert(0, "blue");

            var exist = colors.Exists(color =>
                color.EndsWith("ink"));
            System.Console.WriteLine(exist);
        }
    }  
}