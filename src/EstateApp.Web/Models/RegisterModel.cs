using System.ComponentModel.DataAnnotations;

namespace EstateApp.Web.Models
{

    public class RegisterModel
    {

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Name")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}