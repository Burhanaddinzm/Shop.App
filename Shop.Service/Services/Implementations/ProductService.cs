
using Shop.Core.Enums;
using Shop.Core.Models;
using Shop.Service.Services.Interfaces;

namespace Shop.Service.Services.Implementations
{
    public class ProductService : IProductService
    {

        Product[] Products = { };

        /*Gets the input from the user and calls CheckString(); methode for strings, then resizes the array and
        equals the index of the array to the input.*/
        public void CreateProduct()
        {
            Console.WriteLine("Input product name:");
            string Name = Console.ReadLine();
            Name = Name.CheckString();

            Console.WriteLine("Input product category:");
            Console.WriteLine("1.Fruits");
            Console.WriteLine("2.Meat/Fish");
            Console.WriteLine("3.Dairy");
            Console.WriteLine("4.Spices");
            Console.WriteLine("5.Paper Wrap");
            Console.WriteLine("6.Joiletries");
            Console.WriteLine("7.Vegetables");
            Console.WriteLine("8.Frozen Food");
            Console.WriteLine("9.Canned Goods");
            Console.WriteLine("10.Pet Items");
            Console.WriteLine("11.Household");
            Console.WriteLine("12.Cereal");
            Console.WriteLine("13.Pasta/Rice");
            Console.WriteLine("14.Breads");
            Console.WriteLine("15.Baking");
            Console.WriteLine("16.Beverages");
            Console.WriteLine("17.Snacks");
            Console.WriteLine("18.Condiments");
            Console.WriteLine("19.Sauces/Oils");

            int.TryParse(Console.ReadLine(), out int categoryIndex) ;
            while (categoryIndex < 1 || categoryIndex > 19)
            {
                Console.WriteLine("Please input correct category!");
                int.TryParse(Console.ReadLine(), out int categoryIndex2);
                categoryIndex = categoryIndex2;
            }
            ProductCategory category = (ProductCategory)categoryIndex;

            Console.WriteLine("Input product price:");
            double.TryParse(Console.ReadLine(), out double Price);

            Console.WriteLine("Input product stock count:");
            int.TryParse(Console.ReadLine(), out int StockCount);

            Product product = new Product();
            product.Name = Name;
            product.Price = Price;
            product.StockCount = StockCount;
            product.ProductCategory = category;

            Array.Resize(ref Products, Products.Length + 1);

            Products[Products.Length - 1] = product;
            Console.WriteLine("New product created!");
        }

        public void GetProducts()
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

        public void GetProductById()
        {
            Console.WriteLine("Input ID:");
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
                Console.WriteLine($"Product ID {id} is not avalible");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

    }
}
