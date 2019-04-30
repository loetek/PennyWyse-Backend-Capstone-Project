using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PennyWyse.Models;

namespace PennyWyse.Data
{
        public class ApplicationDbContext : IdentityDbContext<User>
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

            
            public DbSet<User> Users { get; set; }
            public DbSet<Event> Events { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Create a new user for Identity Framework
                User user = new User
                {
                    FirstName = "admin",
                    LastName = "admin",
                    Family = false,
                    LegalAge = false,
                    City = "Nashville",
                    State = "Tennessee",
                    ProfileImageURL = "https://s3.amazonaws.com/37assets/svn/1065-IMG_2529.jpg",

                    UserName = "admin@admin.com",
                    NormalizedUserName = "ADMIN@ADMIN.COM",
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<User>();
                user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
                modelBuilder.Entity<User>().HasData(user);

                // Create two cohorts
                modelBuilder.Entity<User>().HasData(
                    new Event()
                    {
                        Id = 1,
                        Name = "Music City Marathon",
                        Price = 50,
                        StartDate = (2019, 04, 27)
                        LegalAge = True
                       
                        [Display(Name = "Legal Age")]
                        public bool LegalAge { get; set; }
                        [Display(Name = "Family Friendly")]
                        public bool FamilyEvent { get; set; }
                        [Display(Name = "Event Description")]
                        public string Description { get; set; }
                        [Display(Name = "More Info")]
                        public string InfoURL { get; set; }
                        [Display(Name = "Event Image")]
                        public string ImageURL { get; set; }
                        [Display(Name = "Event Location")]
                        public string Location { get; set; }
                        [Display(Name = "Event Type")]
                        public string EventType { get; set; }
                        [Display(Name = "Creator")]
                        public int CreatorId { get; set; }
                    },
                    new Cohort()
                    {
                        CohortId = 2,
                        Name = "Day Cohort 11"
                    }
                );

                // Create two students
                modelBuilder.Entity<Student>().HasData(
                    new Student()
                    {
                        StudentId = 1,
                        FirstName = "Jakob"
        
                        LastName = "Wildman",
                        CohortId = 2
                    },
                    new Student()
                    {
                        StudentId = 2,
                        FirstName = "Susan"
        
                        LastName = "MacAfee",
                        CohortId = 1
                    }
                );
            }
        }
}
