using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class OrderTracking
{
    public int OrderTrackingId { get; set; }

    public int? OrderId { get; set; }

    public string? OrderTrackingStatus { get; set; }

    public DateTime? OrderTrackingDate { get; set; }

    public string? Status { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public virtual Order? Order { get; set; }
}
