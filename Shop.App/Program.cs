using Shop.Core.Models;

Product[] products = { };

Console.WriteLine("1.Create Product");
Console.WriteLine("2.Show Products");
Console.WriteLine("0.Close App");
//Variable for the main app's functionality
string Request = Console.ReadLine();
//Main app-----------------------------------
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
//-------------------------------------------

/*Gets the input from the user and calls CheckString(); methode for strings, then resizes the array and
equals the index of the array to the input.*/
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

//Calls the GetFullInfo(); methode for every object in array.
void ShowProduct()
{
    foreach (Product product in products)
    {
        Console.WriteLine(product.GetFullInfo());
    }
    //Alternative
    //for (int i = 0; i < products.Length; i++)
    //{
    //    Console.WriteLine(products[i].GetFullInfo());

    //}

}
//Reads if string contains Null or Whitespace, then trims whitespace from start and end. 
void CheckString(string data)
{
    while (string.IsNullOrWhiteSpace(data))
    {
        Console.WriteLine("Incorrect data!");
        data = Console.ReadLine();
        data.Trim();
    }
}