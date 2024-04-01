namespace EventAndDelegate
{
    public class ShoppingCardModel
    {
        public delegate void TotalHandler(decimal total);
        public List<ProductModel> Items { get; set; } = new List<ProductModel>();
        public decimal GenerateTotal()
        {
            decimal subTotal = Items.Sum(x => x.Price);
            // totalHandler(subTotal);
            
            if(subTotal > 100) return subTotal * 0.8M;
            else if (subTotal > 50) return subTotal * 0.85M;
            else if (subTotal > 10) return subTotal * 0.9M;
            else return subTotal;
        }
    }
}