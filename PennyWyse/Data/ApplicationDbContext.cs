using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
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

            
            public new DbSet<User> Users { get; set; }
            public DbSet<Event> Events { get; set; }
            public DbSet<UserEvent> UserEvents { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

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
                user.PasswordHash = passwordHash.HashPassword(user, "$ecreT01");
                modelBuilder.Entity<User>().HasData(user);

                User user2 = new User
                {
                    FirstName = "JD",
                    LastName = "Wheeler",
                    Family = true,
                    LegalAge = false,
                    City = "Nashville",
                    State = "Tennessee",
                    ProfileImageURL = "https://s3.amazonaws.com/37assets/svn/1065-IMG_2529.jpg",

                    UserName = "jd@jd.com",
                    NormalizedUserName = "JD@JD.COM",
                    Email = "jd@jd.com",
                    NormalizedEmail = "JD@JD.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash2 = new PasswordHasher<User>();
                user2.PasswordHash = passwordHash2.HashPassword(user2, "$ecreT01");
                modelBuilder.Entity<User>().HasData(user2);

                User user3 = new User
                {
                    FirstName = "Joey",
                    LastName = "B",
                    Family = false,
                    LegalAge = true,
                    City = "Nashville",
                    State = "Tennessee",
                    ProfileImageURL = "https://s3.amazonaws.com/37assets/svn/1065-IMG_2529.jpg",

                    UserName = "joey@joey.com",
                    NormalizedUserName = "JOEY@JOEY.COM",
                    Email = "joey@joey.com",
                    NormalizedEmail = "JOEY@JOEY.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash3 = new PasswordHasher<User>();
                user3.PasswordHash = passwordHash3.HashPassword(user3, "$ecreT01");
                modelBuilder.Entity<User>().HasData(user3);


                // Create two cohorts
                modelBuilder.Entity<Event>().HasData(
                    new Event()
                    {
                        EventId = 1,
                        Name = "Music City Marathon",
                        Price = 50,
                        StartDate = DateTime.Parse("2019/04/27"),
                        LegalAge = false,
                        FamilyEvent = true,
                        Description =
                            "Run Rock 'n' Roll Nashville Marathon, Half Marathon, 5k, and KiDS ROCK | The Rock 'n' Roll Nashville ... Join us in celebrating 20 years running in Music City!",
                        InfoURL = "https://www.runrocknroll.com/nashville/",
                        ImageURL = "https://pridepublishinggroup.com/pride/wp-content/uploads/2019/01/st-jude-race.jpg",
                        City = "Nashville",
                        State = "Tennessee",
                        EventType = "Sports",
                        CreatorId = null

                    },
                    new Event()
                    {
                        EventId = 2,
                        Name = "Nashville Hot Air Balloon Festival",
                        Price = 300,
                        StartDate = DateTime.Parse("2019/06/22"),
                        LegalAge = false,
                        FamilyEvent = true,
                        Description =
                            "Bring the entire family and come enjoy Nashville's BEST Hot Air Balloon Festival! Is there any better way to kick off summer Tennessee ? !Held on a large field just minutes from downtown join dozens of vendors chefs local musicians artists cooking demonstrations pop - up art galleriesPLUS food and alcohol tasting partners.",
                        InfoURL = "https://victorycup.org/nashville/",
                        ImageURL =
                            "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F52525323%2F211234311650%2F1%2Foriginal.jpg?w=800&auto=compress&rect=0%2C38%2C960%2C480&s=07e01664e96aca88dc46985863a58c81",
                        City = "Nashville",
                        State = "Tennessee",
                        EventType = "Outdoor",
                        CreatorId = null
                    },

                    new Event()
                    {
                        EventId = 3,
                        Name = "Nashville Rosé Festival ",
                        Price = 40,
                        StartDate = DateTime.Parse("2019/05/18"),
                        LegalAge = true,
                        FamilyEvent = false,
                        Description =
                            "Don’t miss the second-annual Nashville Rosé Festival! One of the city’s most talked- and instagrammed-about events last year, we are thrilled celebrate our second year in East Nashville’s East Park and have another chance to support one of our favorite charities, the Tennessee Breast Cancer Coalition. ",
                        InfoURL = "https://www.nashvillerosefestival.com/",
                        ImageURL =
                            "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F50613290%2F33678832033%2F1%2Foriginal.jpg?w=800&auto=compress&rect=133%2C0%2C1654%2C827&s=6d96074a1714d0dc6514f98fe44049de",
                        City = "Nashville",
                        State = "Tennessee",
                        EventType = "Festival",
                        CreatorId = null
                    }
                );

            modelBuilder.Entity<UserEvent>().HasData(

                     new UserEvent()
                     {
                        UserEventId = 1,
                        EventId = 1,
                        UserId = user2.Id

                      },

                     new UserEvent()
                     {
                         UserEventId = 2,
                         EventId = 2,
                         UserId = user2.Id

                     },

                     new UserEvent()
                     {
                         UserEventId = 3,
                         EventId = 3,
                         UserId = user3.Id

                     }
              );
            }
        }
}
