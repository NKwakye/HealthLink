using System.ComponentModel.DataAnnotations;

namespace HealthLink.Models.AccountViewModels
{
    public class HosipitalLoginViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string HospitalName { get; set; }

        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }


    }
}
