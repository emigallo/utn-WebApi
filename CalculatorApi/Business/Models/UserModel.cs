using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class UserModel
    {
        public UserModel()
        {

        }

        public UserModel(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        [Key]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}