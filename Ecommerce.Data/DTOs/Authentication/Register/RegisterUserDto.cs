﻿

using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data.DTOs.Authentication.Register
{
    public class RegisterUserDto
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public List<string>? Roles { get; set; } = new();
    }
}