using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HandyApp.Models
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        // DB sets for DB
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Asign> Asigns { get; set; }

        public DbSet<Employee> Employees { get; set; }

        // seed to DB for roles
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ApplicationUser appUser = new ApplicationUser
            {
                UserName = "tester",
                Email = "tester@test.com",
                NormalizedEmail = "tester@test.com".ToUpper(),
                NormalizedUserName = "tester".ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false
            };

            PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "Your-PW1");

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "User", NormalizedName = "USER" }
            );
            modelBuilder.Entity<ApplicationUser>().HasData(
                appUser
            );
        }


    }
}
