using System;
using System.Collections.Generic;

namespace MilkShop.Data.Models;

public partial class ProductCategory
{
    public int ProductCategoryId { get; set; }

    public string? ProductCategoryName { get; set; }

    public string? Status { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
