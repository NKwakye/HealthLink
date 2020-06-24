using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HealthLink.Models
{
    public class ApplicationDBContext : IdentityDbContext<AppUser>
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Hospitals> Hospitals { get; set; }

        public DbSet<Donors> Donors { get; set; }

        public DbSet<Recievers> Recievers { get; set; }

        public DbSet<BlogPost> BlogPosts { get; set; }
    }   
}
