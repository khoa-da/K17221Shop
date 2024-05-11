using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class PaymentMethod
{
    public int PaymentMethodId { get; set; }

    public string? PaymentMethodName { get; set; }

    public string? Status { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
