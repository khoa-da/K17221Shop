using MilkShop.Data.Models;
using MilkShopBusiness.ProductBusiness;

namespace MilkShop.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Business.GetAll()");
            ProductBusiness ProductBusiness = new ProductBusiness();
            var productResult = ProductBusiness.GetAll();

            if (productResult.Status > 0 && productResult.Result.Data != null)
            {   Console.WriteLine("D co data");
                var currencies = (List<Product>)productResult.Result.Data;

                if (currencies != null && currencies.Count > 0)
                {
                    foreach (var currency in currencies)
                    {
                        Console.WriteLine(currency.ProductName);
                    }
                }

            }
            else
            {
                Console.WriteLine("Get All Currency fail");
            }
        }
    }
}
