namespace Shop.Core.Models
{
    public class Product
    {
        //Properties
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int StockCount { get; set; }

        //Constructor is important for this scenario
        public Product(string name, string category, int price, int stockcount)
        {
            this.Name = name;
            this.Category = category;
            this.Price = price;
            this.StockCount = stockcount;
        }
        public string GetFullInfo()
        {
            return $"Name:{Name} Category:{Category} Price:{Price} Stock:{StockCount}";

        }
    }
}
