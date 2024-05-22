using System;
using System.Collections.Generic;

namespace MilkShop.Data.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? OrderStatus { get; set; }

    public decimal? OrderTotalAmount { get; set; }

    public int? UserId { get; set; }

    public int? PaymentMethodId { get; set; }

    public string? PaymentStatus { get; set; }

    public string? Status { get; set; }

    public string? CreatedDate { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<OrderTracking> OrderTrackings { get; set; } = new List<OrderTracking>();

    public virtual PaymentMethod? PaymentMethod { get; set; }

    public virtual Customer? User { get; set; }
}
