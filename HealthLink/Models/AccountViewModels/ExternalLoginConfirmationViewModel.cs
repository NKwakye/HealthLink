using System.ComponentModel.DataAnnotations;

namespace HealthLink.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public object LoginModel { get; set; }
    }
}
