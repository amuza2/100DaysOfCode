using System.Globalization;
using System.Text.RegularExpressions;

namespace ExtracingData
{
    class Program
    {
        public static void print<T>(ICollection<T> lst)
        {
            foreach (var item in lst)
            {
                System.Console.Write(item + " ");
            }
        }
        static void Main(string[] args)
        {
            string log = "[2014-08-05T11:07:12.267897] - SALE - PRODUCT: 1345 - PRICE: $09.99";

            string[] logSplited = log.Split(new string[] {" - "}, StringSplitOptions.None);
            string timeStampString = logSplited[0].Trim('[', ']');
            DateTime formatedDate = DateTime.ParseExact(timeStampString, "yyyy-MM-ddTHH:mm:ss.ffffff", CultureInfo.InvariantCulture);

            int productID = int.Parse(logSplited[2].Split(" ")[1]);
            string priceStr = logSplited[3];
            decimal price = 0;
            MatchCollection matches = Regex.Matches(priceStr, @"\d+\.\d+");
            if(matches.Count > 0) price = decimal.Parse(matches[0].Value);
            

            
        }
    }
}