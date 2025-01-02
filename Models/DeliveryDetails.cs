using System.ComponentModel.DataAnnotations;

namespace OGS.Models
{
    public class DeliveryDetails
    {
        [Required(ErrorMessage ="Recipient's name is required")]
        [Display(Name="Recipient's Name")]
        public string RecipientName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City/Suburb is required")]
        [Display(Name = "City/Suburb")]
        public string City { get; set; }

        [Required(ErrorMessage = "State/Territory is required")]
        [Display(Name = "State/Territory")]
        public string State {  get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"^(\+\d{1,3}[- ]?)?\d{10}$", ErrorMessage = "Invalid mobile number")]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

    }
}
