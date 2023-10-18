namespace Shop.Core.Models;

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public string Category { get; set; }
    public int StockCount { get; set; }

    public void GetFullInfo(string name, string category, int price, int stockcount)
    {
        Console.WriteLine($"Name:{Name} Category:{Category} Price:{Price} Stock Count:{StockCount}");

    }

}