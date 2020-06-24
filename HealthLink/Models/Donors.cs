using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLink.Models
{
    public class Donors
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Location { set; get; }

        public string Email { set; get; }

        public string PhoneNumber { set; get; }
    }
}
