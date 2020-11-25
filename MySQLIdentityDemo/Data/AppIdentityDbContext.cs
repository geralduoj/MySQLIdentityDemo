using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MySQLIdentityDemo.Data
{
    public class AppIdentityDbContext : IdentityDbContext
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUser>().Property(u => u.Id).HasMaxLength(128);
            modelBuilder.Entity<IdentityUser>().Property(u => u.UserName).HasMaxLength(128);
            modelBuilder.Entity<IdentityUser>().Property(u => u.NormalizedUserName).HasMaxLength(128);
            modelBuilder.Entity<IdentityRole>().Property(r => r.Id).HasMaxLength(128);
            modelBuilder.Entity<IdentityRole>().Property(r => r.Name).HasMaxLength(128);
            modelBuilder.Entity<IdentityRole>().Property(r => r.NormalizedName).HasMaxLength(128);
        }
    }
}
