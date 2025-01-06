using System.ComponentModel.DataAnnotations;

namespace OGS.Models
{
    public class Login
    {
        [Required,EmailAddress(ErrorMessage ="Email is required ")]
        public string Email { get; set; }

        [Required,MinLength(6,ErrorMessage ="Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Role is required")]
        public string Role { get; set; }

    }
}
