using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}