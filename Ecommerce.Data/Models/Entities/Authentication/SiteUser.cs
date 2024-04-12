﻿

using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Data.Models.Entities.Authentication
{
    public class SiteUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpierationDate { get; set; }
        public List<UserAddress>? UserAddresses { get; set; }
    }
}
