using System;
using System.Collections.Generic;

namespace MilkShop.Data.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string CompanyAddress { get; set; } = null!;

    public string CompanyPhone { get; set; } = null!;

    public string CompanyEmail { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? CreateDated { get; set; }

    public int? ProductId { get; set; }
}
