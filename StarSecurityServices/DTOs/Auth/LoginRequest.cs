﻿namespace StarSecurityServices.DTOs.Auth
{
    public class LoginRequest
    {
        public string Code { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
