using System;
using System.Runtime.CompilerServices;

namespace exercice1
{
    public delegate bool DateValidationHandler(DateTime dateTime);
    public class Order
    {
        private readonly DateValidationHandler _orderDateValidator;
        private readonly DateValidationHandler _deleveryDateValidator;
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Order(DateValidationHandler orderDateValidator,
            DateValidationHandler deliveryDateValidator)
        {
            _orderDateValidator = orderDateValidator;
            _deleveryDateValidator = deliveryDateValidator;
        }
        public bool isValid() =>
            _orderDateValidator(OrderDate) &&
            _deleveryDateValidator(DeliveryDate);
    }
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
        private static bool IsWeekendDate(DateTime date)
        {
            System.Console.WriteLine("Called IsWeekendDate");
            return date.DayOfWeek == DayOfWeek.Saturday ||
            date.DayOfWeek == DayOfWeek.Sunday;
        }
        private static bool IsPastDate(DateTime date)
        {
            System.Console.WriteLine("Called IsPastDate");
            return date < DateTime.Today;
        }
        private static void Main(string[] args)
        {
            var orderValidator = new DateValidationHandler(IsPastDate);
            var deliveryValidator = new DateValidationHandler(IsWeekendDate);
            var order = new Order(orderValidator, deliveryValidator)
            {
                OrderDate = DateTime.Today.AddDays(-10),
                DeliveryDate = new DateTime(2024,12, 28)
            };

            System.Console.WriteLine($"Ordered: {order.OrderDate:dd-MMM-yy}");
            System.Console.WriteLine($"Desivered: {order.DeliveryDate:ddd-dd-MMM-yy}");
            System.Console.WriteLine($"IsValid: {order.isValid()}");
        }
    }

}

