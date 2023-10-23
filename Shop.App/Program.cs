using Shop.Service.Services;

ShoppingService shoppingService = new ShoppingService();
ShowMenu();
//Variable for the main app's functionality
string request = Console.ReadLine();
//Main app-----------------------------------
while (request != "0")
{

    switch (request)
    {
        case "1":
            shoppingService.CreateProduct();
            break;
        case "2":
            shoppingService.ShowProducts();
            break;
        case "3":
            shoppingService.ShowProductById();
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