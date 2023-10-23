namespace Shop.Core.Models
{
    public class Product
    {
        //Fields
        private static int _id;
        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int StockCount { get; set; }

        //Constructor is important for this scenario
        public Product()
        {
            _id++;
            Id = _id;
            //this.Name = name;
            //this.Category = category;
            //this.Price = price;
            //this.StockCount = stockcount;
        }
        public override string ToString()
        {
            return $"Id: {Id} Name:{Name} Category:{Category} Price:{Price} Stock:{StockCount}";

        }
    }
}
