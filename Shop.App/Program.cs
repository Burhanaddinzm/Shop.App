using Shop.Service.Services.Implementations;

ProductService productService = new ProductService();
ShowMenu();

string request = Console.ReadLine();
//Main app-----------------------------------
while (request != "0")
{

    switch (request)
    {
        case "1":
            productService.CreateProduct();
            break;
        case "2":
            productService.GetProducts();
            break;
        case "3":
            productService.GetProductById();
            break;
        default:
            Console.WriteLine("This option is not valid!");
            break;
    }
    ShowMenu();
    request = Console.ReadLine();
}
//-------------------------------------------
void ShowMenu()
{
    Console.WriteLine("1.Create Product");
    Console.WriteLine("2.Show Products");
    Console.WriteLine("3.Show Product by ID");
    Console.WriteLine("0.Close App");
}