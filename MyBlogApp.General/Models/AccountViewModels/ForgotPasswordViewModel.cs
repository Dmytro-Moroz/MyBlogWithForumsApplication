using System.ComponentModel.DataAnnotations;

namespace MyBlogApp.General.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
