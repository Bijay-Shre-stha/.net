using System.ComponentModel.DataAnnotations;

namespace Login_Authentication.Models
{
    public class RegisterModel
    {
        [Key]
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}