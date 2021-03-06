using EntityLayer.IdentityModels;
using EntityLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
   public class MyContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<Company>Companies  { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<City>().HasIndex(c => new { c.PlateCode }).IsUnique(true);


            base.OnModelCreating(builder);
        }

    }
}
