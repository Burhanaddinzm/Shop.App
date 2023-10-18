using Shop.Core.Models;
Product[] products = { };

Console.WriteLine("1.Create Product");
Console.WriteLine("2.Show Products");
Console.WriteLine("0.Close App");
string Request = Console.ReadLine();

while (Request != "0")
{

    switch (Request)
    {
        case "1":
            CreateProduct();
            break;
        case "2":
            ShowProduct();
            break;
        default:
            Console.WriteLine("This option is not valid!");
            break;
    }

    Console.WriteLine("1.Create Product");
    Console.WriteLine("2.Show Products");
    Console.WriteLine("0.Close App");
    Request = Console.ReadLine();
}

void CreateProduct()
{
    Console.WriteLine("Input product name");
    string Name = Console.ReadLine();
    CheckString(Name);

    Console.WriteLine("Input product category");
    string Category = Console.ReadLine();
    CheckString(Category);

    Console.WriteLine("Input product price");
    int Price = int.Parse(Console.ReadLine());

    Console.WriteLine("Input product stock count");
    int StockCount = int.Parse(Console.ReadLine());

    Product product = new Product(Name, Category, Price, StockCount);

    Array.Resize(ref products, products.Length + 1);

    products[products.Length - 1] = product;
    Console.WriteLine("New product created!");
}

void ShowProduct()
{
    foreach (Product product in products)
    {
        Console.WriteLine(product.GetFullInfo());
    }
}

void CheckString(string data)
{
    while (string.IsNullOrWhiteSpace(data))
    {
        Console.WriteLine("Incorrect data!");
        data = Console.ReadLine();
        data.Trim();
    }
}