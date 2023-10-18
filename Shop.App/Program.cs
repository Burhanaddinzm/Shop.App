using Shop.Core.Models;

Product[] products = { };

CreateProduct();
void CreateProduct()
{
    Product product = new Product();

    Console.WriteLine("Adi daxil edin");
    product.Name = Console.ReadLine();
    CheckString(product.Name);

    Console.WriteLine("Kateqoriyani daxil edin");
    product.Category = Console.ReadLine();
    CheckString(product.Category);

    Console.WriteLine("Qiymeti daxil edin");
    product.Price = int.Parse(Console.ReadLine());

    Console.WriteLine("Stok sayini daxil edin");
    product.StockCount = int.Parse(Console.ReadLine());



    Array.Resize(ref products, products.Length + 1);
}

void CheckString(string input)
{

    while (string.IsNullOrWhiteSpace(a))
    {
        Console.WriteLine("Input value is not correct");
        a= Console.ReadLine();
    }
}