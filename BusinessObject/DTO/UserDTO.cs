using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }

        public string? UserName { get; set; }

        public string? UserEmail { get; set; }

        public string? UserPassword { get; set; }

        public int? UserRoleId { get; set; }

        public string? Status { get; set; }
    }
}
