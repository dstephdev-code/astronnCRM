using System.ComponentModel.DataAnnotations;

namespace astronnCRM.Model.InputModels
{
    public class ApplicationUserLoginInputModel
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public required string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public required string ConfirmationPassword { get; set; }

    }
}
