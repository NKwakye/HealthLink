﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HealthLink.Utility;
using Microsoft.AspNetCore.Mvc;

namespace HealthLink.Models.AccountViewModels
{
    public class RegisterHospitalViewModel  
    {
  
         [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Hospital Name ")]
        public string HospitalName { get; set; }

        [Required]
        [Display(Name = "Telephone")]
        public string Telephone { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "WebsiteUrl")]
        public string WebsiteUrl { get; set; }

        [Required]
        [Display(Name = "Location")]
        public string Location { get; set; }





    }

}

