using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace exercice1
{
    public static class Program
    {
        public static void method1()
        {
            var data = new List<Tuple<int , int>>
            {
                Tuple.Create(1000, 100),
                Tuple.Create(2000, -17),
                Tuple.Create(2500, 170)
            };
            Console.WriteLine("Revenue | Profile | Percent");
            string template = "{0,7:N0} | {1,7:+0;-0} | {2,7:P2}";

            foreach (var item in data)
            {
                double percent = (double)item.Item2 / item.Item1;
                Console.WriteLine(string.Format(template, item.Item1, item.Item2, percent));
            }
        }
        
        private static void Main(string[] args)
        {
         

         

            // var random = new Random();
            // string input;
            // do
            // {
            //     Console.Write("Yesterday's distance: ");
            //     input = Console.ReadLine();
            //     double.TryParse(input, NumberStyles.Any, CultureInfo.CurrentCulture, out var distanceYesterday);
            //     var carYesterday = new Car
            //     {
            //         Distance = distanceYesterday,
            //         JourneyTime = random.NextDouble() * 10D
            //     };
            //     Console.Write("    Today's distance: ");
            //     input = Console.ReadLine();
            //     double.TryParse(input, NumberStyles.Any, CultureInfo.CurrentCulture, out var distanceToday);

            //     var carToday = new Car
            //     {
            //         Distance = distanceToday,
            //         JourneyTime = random.NextDouble() * 10D
            //     };
            //     var comparer = new JourneyComparer();
            //     comparer.Compare(carYesterday, carToday);
            //     Console.WriteLine();
            //     Console.WriteLine("Journey Details\t\tDistance\tTime\tAvg Speed");
            //     Console.WriteLine("---------------------------------------------------------");
            //     Console.WriteLine();
            //     System.Console.Write($"Yesterday\t\t{comparer.Distance.Yesterday:N0} \t\t");
            //     System.Console.WriteLine($"{comparer.JourneyTime.Yesterday:N0}\t{comparer.AverageSpeed.Yesterday:N0}");
            //     System.Console.Write($"Today\t\t\t{comparer.Distance.Today:N0}\t\t");
            //     System.Console.WriteLine($"{comparer.JourneyTime.Today:N0}\t{comparer.AverageSpeed.Today:N0}");
            //     System.Console.WriteLine("========================================================");
            //     System.Console.Write($"Difference\t\t{comparer.Distance.Difference:N0}\t\t");
            //     System.Console.WriteLine($"{comparer.JourneyTime.Difference:N0} \t{comparer.AverageSpeed.Difference:N0}");
            //     System.Console.WriteLine("========================================================");
            // }
            // while (!string.IsNullOrEmpty(input));

        }

        
    }

}

