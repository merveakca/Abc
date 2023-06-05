using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Abc.Northwind.MvcWebUI.Entities
{
    public class CustomIdentityDbContext:DbContext
    {
        public CustomIdentityDbContext(DbContextOptions<CustomIdentityDbContext> options) : base(options)
        {

        }

        public DbSet<CustomIdentityUser> CustomIdentityUser { get; set; }
        public DbSet<CustomIdentityRole> CustomIdentityRole { get; set; }
    }
}
