using MilkShopData.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkShopBusiness
{   
    public interface IPublicBusiness
    {
        Task<IPublicBusiness> CreateAsync();
        Task<IPublicBusiness> UpdateAsync();
        Task<IPublicBusiness> DeleteAsync();
        Task<IPublicBusiness> GetAsync();


    }

    public class ProductBusiness
    {
        private readonly ProductDAO _productDAO;

        
    }
}
