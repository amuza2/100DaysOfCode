namespace EventAndDelegate
{
    class Program
    {
        static ShoppingCardModel cart = new ShoppingCardModel();
        static void Main(string[] args)
        {
           PopulateCardWithDemoDate();
            System.Console.WriteLine($"The total for the cart is {cart.GenerateTotal(ShowSubTotal):C2}");
           
        }
        private static void PopulateCardWithDemoDate()
        {
            cart.Items.Add(new ProductModel {Name = "Careal", Price = 3.63M});
            cart.Items.Add(new ProductModel {Name = "Milk", Price = 2.95M});
            cart.Items.Add(new ProductModel {Name = "Strawberries", Price = 7.51M});
            cart.Items.Add(new ProductModel {Name = "Blueberries", Price = 8.84M});
        }
        private static void ShowSubTotal(decimal subTotal)
        {
            System.Console.WriteLine($"The subtotal is: {subTotal:C2}");
        }
    }
    
}