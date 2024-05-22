using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkShopBusiness.Repositories.IRepository
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product? GetProductByID(int id);
        void AddNew(Product product);
        void Update(Product product);
        void Delete(int id);
        void Save();
    }
}
