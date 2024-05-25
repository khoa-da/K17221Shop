using MilkShop.Data.DAO;
using MilkShop.Data.Models;
using MilkShop.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkShop.Data
{
    public class UnitOfWork
    {
        private MilkShopContext _context;
        private ProductCategoryRepository _productCategoryRepository;

        public UnitOfWork() { }

        public ProductCategoryRepository ProductCategoryRepository
        {
            get
            { 
                return _productCategoryRepository ??= new ProductCategoryRepository();
            }
        }
    }
}
