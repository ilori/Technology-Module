namespace p07_Sales_Report
{
    public class Sale
    {
        public Sale(string town, string product, decimal price, decimal quantity)
        {
            Town = town;
            Product = product;
            Price = price;
            Quantity = quantity;
        }

        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}