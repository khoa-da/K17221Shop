using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserEmail { get; set; }

    public string? UserPassword { get; set; }

    public int? UserRoleId { get; set; }

    public string? Status { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual UserRole? UserRole { get; set; }
}
