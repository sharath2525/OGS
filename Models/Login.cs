using System.ComponentModel.DataAnnotations;

namespace OGS.Models
{
    public class Login
    {
        [Required,EmailAddress(ErrorMessage ="Email is required ")]
        public required string Email { get; set; }

        [Required,MinLength(6,ErrorMessage ="Password is required")]
        public required string Password { get; set; }

        [Required(ErrorMessage ="Role is required")]
        public required string Role { get; set; }

    }
}
