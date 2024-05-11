using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class ProductBrand
{
    public int ProductBrandId { get; set; }

    public string? ProductBrandName { get; set; }

    public string? Status { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
