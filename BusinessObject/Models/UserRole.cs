using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class UserRole
{
    public int UserRoleId { get; set; }

    public string? UserRoleName { get; set; }

    public string? Status { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
