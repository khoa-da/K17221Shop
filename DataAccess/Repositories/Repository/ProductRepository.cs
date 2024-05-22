using BusinessObject.Models;
using MilkShopBusiness.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkShopBusiness.Repositories.Repository
{
    public class ProductRepository() : IProductRepository
    {   
        private K17221shopContext _context = new K17221shopContext();

        public void AddNew(Product product)
        {
            _context.Products.Add(product);
        }

        public void Delete(int id)
        {
            var x = GetProductByID(id);
            if ( x != null)
            _context.Products.Remove(x);
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product? GetProductByID(int id)
        {
            return _context.Products.Find(id);   
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
        }
    }
}
