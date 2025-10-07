﻿using Microsoft.AspNetCore.Identity;

namespace DiveDeep.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Order>? Orders { get; set; }
    }
}
