using MilkShop.Data.Models;
using MilkShopBusiness.ProductBrandBusiness;
using MilkShopBusiness.ProductBusiness;

namespace MilkShop.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Business.GetAll()");
            //ProductBusiness ProductBusiness = new ProductBusiness();
            //var productResult = ProductBusiness.GetAll();

            //if (productResult.Status > 0 && productResult.Result.Data != null)
            //{   Console.WriteLine("D co data");
            //    var currencies = (List<Product>)productResult.Result.Data;

            //    if (currencies != null && currencies.Count > 0)
            //    {
            //        foreach (var currency in currencies)
            //        {
            //            Console.WriteLine(currency.ProductName);
            //        }
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Get All Currency fail");
            //}

            ProductBrandBusiness productBrandBusiness = new ProductBrandBusiness();
            var productBrands = productBrandBusiness.GetAll();
            var x = (List<ProductBrand>)productBrands.Result.Data;
            foreach ( var item in x)
            {
                Console.WriteLine(item.ProductBrandName);
            }

            var productBrand = productBrandBusiness.GetById(1);
            ProductBrand zay =(ProductBrand) productBrand.Result.Data;
            Console.WriteLine(zay.ProductBrandName);

            ProductBrand productBrand1 = new ProductBrand()
            {
                ProductBrandName = "Bao cho de",
                Status = "true",
                CreatedDate = DateOnly.FromDateTime(DateTime.Now)

            };
            //productBrandBusiness.Save(productBrand1);


            productBrand1.ProductBrandName = "Cac";
            Console.WriteLine(productBrand1.ProductBrandName);
            productBrandBusiness.UpdateAsync(productBrand1);

        }
    }
}
