﻿

namespace Ecommerce.Data.DTOs.Authentication.User
{
    public class LoginResponse
    {
        public TokenType? AccessToken { get; set; }
        public TokenType? RefreshToken { get; set; }
    }
}
