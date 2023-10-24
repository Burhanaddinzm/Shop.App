
using Shop.Core.Models;
using Shop.Service.Services.Interfaces;
using Shop.Service.Services.Implementations;
namespace Shop.Service.Services
{
    public class ShoppingService : IShoppingService
    {

        Product[] Products = { };

        /*Gets the input from the user and calls CheckString(); methode for strings, then resizes the array and
        equals the index of the array to the input.*/
        public void CreateProduct()
        {
            Console.WriteLine("Input product name");
            string Name = Console.ReadLine();
            Name = Name.CheckString();

            Console.WriteLine("Input product category");
            string Category = Console.ReadLine();
            Category = Category.CheckString();

            Console.WriteLine("Input product price");
            int.TryParse(Console.ReadLine(), out int Price);

            Console.WriteLine("Input product stock count");
            int.TryParse(Console.ReadLine(), out int StockCount);

            Product product = new Product(/*Name, Category, Price, StockCount*/);
            product.Name = Name;
            product.Price = Price;
            product.StockCount = StockCount;
            product.Category = Category;
            Array.Resize(ref Products, Products.Length + 1);

            Products[Products.Length - 1] = product;
            Console.WriteLine("New product created!");
        }

        public void ShowProducts()
        {
            foreach (Product product in Products)
            {
                Console.WriteLine(product);
            }
            //Alternative
            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.WriteLine(products[i]());

            //}

        }

        public void ShowProductById()
        {
            Console.WriteLine("Input ID");
            int.TryParse(Console.ReadLine(), out int id);
            Product result = default;
            foreach (Product product in Products)
            {
                if (product.Id == id)
                {
                    result = product;
                    break;
                }
            }

            if (result == null)
            {
                Console.WriteLine($"{id} product ID is not avalible");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

    }
}
