using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthLink.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Details { get; set; }

        public string Image { get; set; }

        public DateTime PostedDate { get; set; }

    }
}
