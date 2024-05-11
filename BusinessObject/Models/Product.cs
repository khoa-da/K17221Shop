﻿using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public decimal? ProductPrice { get; set; }

    public string? ProductImage { get; set; }

    public int? ProductCategoryId { get; set; }

    public int? ProductBrandId { get; set; }

    public string? Status { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ProductBrand? ProductBrand { get; set; }

    public virtual ProductCategory? ProductCategory { get; set; }
}
