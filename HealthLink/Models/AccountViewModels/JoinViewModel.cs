using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLink.Models.AccountViewModels
{
    public class JoinViewModel
    {

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string registerEmail { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string registerPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("registerPassword", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string registerFirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string registerLastName { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string registerPhoneNumber { get; set; }

        public string FullName { get; set; }


        //Login Section Properties declaration


        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string loginEmail { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string loginPassword { get; set; }


        [Display(Name = "Remember me?")]
        public bool loginRememberMe { get; set; }
    }
}
