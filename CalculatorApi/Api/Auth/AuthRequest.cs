using System.ComponentModel.DataAnnotations;

namespace Api.Auth
{
    public class AuthRequest
    {
        [Required]
        public string grant_type { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}