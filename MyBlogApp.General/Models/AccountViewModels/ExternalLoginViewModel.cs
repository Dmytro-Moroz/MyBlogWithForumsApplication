using System.ComponentModel.DataAnnotations;

namespace MyBlogApp.General.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
