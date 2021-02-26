using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VSDProjekt.Model;

namespace VSDProjekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<VSDProjekt.Model.zariadenie> zariadenie { get; set; }
        public DbSet<VSDProjekt.Model.zasuvka> zasuvka { get; set; }
    }
}
