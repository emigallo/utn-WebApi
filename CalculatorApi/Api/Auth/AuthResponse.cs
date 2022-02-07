using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Api.Auth
{
    public class AuthResponse
    {
        [Required]
        public string Token { get; set; }

        [Required]
        public string TokenType { get; set; }

        [Required]
        public string ExpiresIn { get; set; }
    }
}