using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace Chapter3.Excercise02;

record Car
{
    public double Distance { get; init; }
    public double JourneyTime { get; init; }
}
class Comparison
{
    private readonly Func<Car, double> _valueSelector;
    public double Yesterday { get; private set; }
    public double Today { get; private set; }
    public double Difference { get; private set; }
    public Comparison(Func<Car, double> valueSelector)
    {
        _valueSelector = valueSelector;
    }

    public void Compare(Car yesterdayCar, Car todayCar)
    {
        Yesterday = _valueSelector(yesterdayCar);
        Today = _valueSelector(todayCar);
        Difference = Yesterday - Today;
    }
}

class JourneyComparer
{
    public Comparison Distance { get;}
    public Comparison JourneyTime { get;}
    public Comparison AverageSpeed { get;}
    public JourneyComparer()
    {
        Distance = new Comparison(GetCarDistance);
        JourneyTime = new Comparison(GetCarJourneyTime);
        AverageSpeed = new Comparison(GetCarAverageSpeed);
    }
    static double GetCarDistance(Car car) => car.Distance;
    static double GetCarJourneyTime(Car car) => car.JourneyTime;
    static double GetCarAverageSpeed(Car car) => car.Distance / car.JourneyTime;

    public void Compare(Car yesterday, Car today)
    {
        Distance.Compare(yesterday, today);
        JourneyTime.Compare(yesterday, today);
        AverageSpeed.Compare(yesterday, today);
    }

}


class Program
{    
    static void Main(string[] args)
    {
        var random = new Random();
        string input;
        do
        {
            Console.Write("Yesterday's distance: ");
            input = Console.ReadLine();
            double.TryParse(input, NumberStyles.Any, CultureInfo.CurrentCulture, out var distanceYesterday);
            var carYesterday = new Car
            {
                Distance = distanceYesterday,
                JourneyTime = random.NextDouble() * 10D
            };
            Console.Write("    Today's distance: ");
            input = Console.ReadLine();
            double.TryParse(input, NumberStyles.Any, CultureInfo.CurrentCulture, out var distanceToday);
            var carToday = new Car
            {
                Distance = distanceToday,
                JourneyTime = random.NextDouble() * 10D
            };
            var compare = new JourneyComparer();
            compare.Compare(carYesterday, carToday);
            System.Console.WriteLine();
            System.Console.WriteLine("Journey Details     Distance\tTime\tAvg Speed");
            System.Console.WriteLine("-------------------------------------------------");
            System.Console.Write($"Yesterday         {compare.Distance.Yesterday:N0}     \t");
            System.Console.WriteLine($"{compare.JourneyTime.Yesterday:N0}\t  {compare.AverageSpeed.Yesterday:N0}");
            System.Console.Write($"Today               {compare.Distance.Today:N0}  \t");
            System.Console.WriteLine($"{compare.JourneyTime.Today:N0}\t {compare.AverageSpeed.Today:N0}");
            System.Console.WriteLine("==================================================");
            System.Console.Write($"Diffrence         {compare.Distance.Difference:N0}       \t");
            System.Console.WriteLine($"{compare.JourneyTime.Difference:N0}     \t{compare.AverageSpeed.Difference:N0}");
            System.Console.WriteLine("==================================================");

        } while (!string.IsNullOrEmpty(input));

    }
}
