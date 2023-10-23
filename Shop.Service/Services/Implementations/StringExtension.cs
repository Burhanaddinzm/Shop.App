
namespace Shop.Service.Services.Implementations
{
    public static class StringExtension
    {
        //Reads if string contains Null or Whitespace, then trims whitespace from start and end. 
        public static string CheckString(this string data)
        {
            while (string.IsNullOrWhiteSpace(data))
            {
                Console.WriteLine("Incorrect data!");
                data = Console.ReadLine();
            }
            data = data.Trim();
            return data;
        }
    }
}
