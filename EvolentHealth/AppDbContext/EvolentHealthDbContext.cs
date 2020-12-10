using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EvolentHealth.Models;

namespace EvolentHealth.AppDbContext
{
    public class EvolentHealthDbContext : IdentityDbContext<IdentityUser>
    {
        public EvolentHealthDbContext(DbContextOptions<EvolentHealthDbContext> options):
            base(options){
        }

        public DbSet<Contact> Contacts { get; set; }
        
    }
}
