using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthLink.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HealthLink.Models
{
    public class AppUser : IdentityUser
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
       public bool IsDonor { set; get; }


    }
}
