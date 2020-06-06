using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLink.Models
{
    public class Hospitals 
    {
        public int Id { get; set; }


        public string Email { get; set; }

        public string WebsiteUrl { get; set; }

        public string Password { get; set; }

        public string HospitalName { get; set; }
        public string Location { get; set; }

        public string Telephone { get; set; }

        public string Phone { get; set; }


    }
}
