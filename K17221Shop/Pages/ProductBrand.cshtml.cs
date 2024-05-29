using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MilkShop.Data.Models;
using MilkShopBusiness.ProductBrandBusiness;

namespace K17221Shop.Pages
{
    [BindProperties]
    public class ProductBrandModel : PageModel
    {
        private readonly IProductBrandBusiness _productBrandBusiness;

        // Constructor to inject the service
        public ProductBrandModel(IProductBrandBusiness productBrandBusiness)
        {
            _productBrandBusiness = productBrandBusiness;
        }

        public ProductBrand productBrand { get; set; } = default!;

        public List<ProductBrand> productBrands { get; set; } = new List<ProductBrand>();

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _productBrandBusiness.GetAll == null || productBrand == null)
            {
                return Page();
            }


            await _productBrandBusiness.Save(productBrand);

            return Page();
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var result = await _productBrandBusiness.GetAll();

            if (result?.Data == null)
            {
                return NotFound();
            }

            productBrands = (List<ProductBrand>)result.Data;

            return Page();
        }
    }
}
