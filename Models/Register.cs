using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OGS.Models
{
    public class Register
    {
        [Required,EmailAddress]
        public string Email { get; set; }


        [Required,MinLength(6,ErrorMessage ="Password must be atleast 6 characters")]
        public required string Password { get; set; }


        [Required,Compare("Password",ErrorMessage ="Password do not match")]
        public required string ConfirmPassword { get; set; }



        [Required]
        public string Role {  get; set; }


    }
}
