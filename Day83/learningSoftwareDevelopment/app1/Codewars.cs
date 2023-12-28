namespace app1;

public class Codewars
{
    public static string ExpandedForm(long num)
    {
        string result = "";
        int zeros = num.ToString().Length - 1;
        foreach (char item in num.ToString())       
        {
            if(!item.Equals('0'))
            {
                if(!string.IsNullOrEmpty(result)) result += " + ";
                result += item;
                for (int i = 0; i < zeros; i++)
                {
                    result += '0';
                }
            }
            zeros--;
        }
        return result;
    }
}
class Program1   
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(Codewars.ExpandedForm(12));
        System.Console.WriteLine(Codewars.ExpandedForm(42));
        System.Console.WriteLine(Codewars.ExpandedForm(70304));
        // System.Console.WriteLine(Codewars.ExpandedForm(""));
    }
}

