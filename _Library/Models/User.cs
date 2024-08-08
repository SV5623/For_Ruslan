using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace RuslanPR_Library.Models
{
    public class User : IdentityUser
    {
        public ICollection<Project> Projects { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}