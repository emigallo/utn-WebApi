using System;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class LoginModel
    {
        public LoginModel()
        {
        }

        public LoginModel(int id, string name, string email, DateTime date)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Date = date;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}