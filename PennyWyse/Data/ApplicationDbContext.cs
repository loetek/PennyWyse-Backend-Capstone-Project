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
                        
                        Description =
                            "Run Rock 'n' Roll Nashville Marathon, Half Marathon, 5k, and KiDS ROCK | The Rock 'n' Roll Nashville ... Join us in celebrating 20 years running in Music City!",
                        InfoURL = "https://www.runrocknroll.com/nashville/",
                        ImageURL = "https://pridepublishinggroup.com/pride/wp-content/uploads/2019/01/st-jude-race.jpg",
                        City = "Nashville",
                        State = "Tennessee",
                        EventType = "Sports",
                        CreatorId = user.Id

                    },
               
                    new Event()
                    {
                        EventId = 2,
                        Name = "Nashville Hot Air Balloon Festival",
                        Price = 300,
                        StartDate = DateTime.Parse("2019/06/22"),
                        
                        Description =
                            "Bring the entire family and come enjoy Nashville's BEST Hot Air Balloon Festival! Is there any better way to kick off summer Tennessee ? !Held on a large field just minutes from downtown join dozens of vendors chefs local musicians artists cooking demonstrations pop - up art galleriesPLUS food and alcohol tasting partners.",
                        InfoURL = "https://victorycup.org/nashville/",
                        ImageURL =
                            "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F52525323%2F211234311650%2F1%2Foriginal.jpg?w=800&auto=compress&rect=0%2C38%2C960%2C480&s=07e01664e96aca88dc46985863a58c81",
                        City = "Nashville",
                        State = "Tennessee",
                        EventType = "Outdoor",
                        CreatorId = user.Id
                    },

                    new Event()
                    {
                        EventId = 3,
                        Name = "Nashville Rosé Festival ",
                        Price = 40,
                        StartDate = DateTime.Parse("2019/05/18"),
                     
                        Description =
                            "Don’t miss the second-annual Nashville Rosé Festival! One of the city’s most talked- and instagrammed-about events last year, we are thrilled celebrate our second year in East Nashville’s East Park and have another chance to support one of our favorite charities, the Tennessee Breast Cancer Coalition. ",
                        InfoURL = "https://www.nashvillerosefestival.com/",
                        ImageURL =
                            "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F50613290%2F33678832033%2F1%2Foriginal.jpg?w=800&auto=compress&rect=133%2C0%2C1654%2C827&s=6d96074a1714d0dc6514f98fe44049de",
                        City = "Nashville",
                        State = "Tennessee",
                        EventType = "Festival",
                        CreatorId = user.Id
                    },
                         new Event()
                         {
                             EventId = 4,
                             Name = "Brew at the Zoo",
                             Price = 75,
                             StartDate = DateTime.Parse("2019/05/31"),
                            
                             Description =
                            "Nashville Zoo welcomes all species of beer lovers to the eighth annual Brew at the Zoo happening on Friday, May 31 from 6:30pm to 10:30pm. Animals, live music, local food trucks and over 100 craft beers are on tap at this unique after-hours event voted the best beer event in Nashville by Nashville Scene readers in 2014 and 2016.",
                             InfoURL = "https://www.nashvillezoo.org/upcoming-events/entry/brew-at-the-zoo/instance/5-31-2019",
                             ImageURL = "http://nashvilleguru.com/officialwebsite/wp-content/uploads/2015/05/Brew-at-the-Zoo.jpg",
                             City = "Nashville",
                             State = "Tennessee",
                             EventType = "Outdoor",
                             CreatorId = user2.Id

                         }, new Event()
                         {
                             EventId = 5,
                             Name = "Bonnaroo",
                             Price = 350,
                             StartDate = DateTime.Parse("2019/06/13"),
                           
                             Description = "The Bonnaroo Music and Arts Festival is an American annual four-day music festival developed and produced by Superfly Presents and AC Entertainment. Since its first year in 2002, it has been held at what is now Great Stage Park on a 650-acre (263 km2) farm in Manchester, Tennessee. The festival typically starts on the second Thursday in June and lasts four days. Main attractions of this festival are the multiple stages featuring live music with a diverse array of musical styles including indie rock, classic rock, world music, hip hop, jazz, americana, bluegrass, country music, folk, gospel, reggae, pop, electronic, and other alternative music.",
                             InfoURL = "https://www.bonnaroo.com/",
                             ImageURL = "https://www.bonnaroo.com/wp-www-bonnaroo-com/wp/wp-content/uploads/2018/11/logo-1bb87d41-b09cb133.png",
                             City = "Manchester",
                             State = "Tennessee",
                             EventType = "Music Festival",
                             CreatorId = user3.Id

                         }, new Event()
                         {
                             EventId = 6,
                             Name = "Nashville Pride",
                             Price = 5,
                             StartDate = DateTime.Parse("2019/06/22"),
                            
                             Description =
                            "Pride parades are outdoor events celebrating lesbian, gay, bisexual, transgender, and queer social and self acceptance, achievements, legal rights and pride. The events also at times serve as demonstrations for legal rights such as same-sex marriage.",
                             InfoURL = "https://www.nashvillepride.org/",
                             ImageURL = "http://nashvilleguru.com/officialwebsite/wp-content/uploads/2015/06/Nashville-Pride-Festival-1.jpg",
                             City = "Nashville",
                             State = "Tennessee",
                             EventType = "Parade",
                             CreatorId = user2.Id

                         }, new Event()
                         {
                             EventId = 7,
                             Name = "An Evening of Magic with Justin Flom",
                             Price = 50,
                             StartDate = DateTime.Parse("2019/05/24"),
                             
                             Description =
                            "WestEnd Kitchen & Bar is excited to welcome fans of celebrity magician Justin Flom with a special, An Evening of Magic dinner package. The package includes one entrée, one glass of house wine or beer, valet parking plus two general admission tickets to the show.",
                             InfoURL = "https://www.eventbrite.com/e/an-evening-of-magic-with-justin-flom-at-analog-at-hutton-hotel-tickets-55677038521",
                             ImageURL = "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F56447862%2F50800243798%2F1%2Foriginal.20190207-205651?w=800&auto=compress&rect=0%2C0%2C2160%2C1080&s=a3bfbcc116e5622166604d60a6b2a5b5",
                             City = "Nashville",
                             State = "Tennessee",
                             EventType = "Show",
                             CreatorId = user.Id

                         }, new Event()
                         {
                             EventId = 8,
                             Name = "Urban Gardening Festival",
                             Price = 0,
                             StartDate = DateTime.Parse("2019/05/18"),
                             
                             Description =
                            "The Master Gardeners of Davidson County will be hosting the Urban Gardening Festival on Saturday, May 18, 2019, from 9:00am to 4:00pm at the Ellington Agricultural Center. The public is invited to learn gardening methods, techniques, and engage with local growers, artisans, exhibitors, educators, and more. There will also be local food trucks with food and beverages. The event is rain or shine. All ages are welcome.",
                             InfoURL = "http://mgofdc.org/ugf",
                             ImageURL = "http://nashvilleguru.com/officialwebsite/wp-content/uploads/2018/05/Urban-Gardening-Fest-01.jpg",
                             City = "Nashville",
                             State = "Tennessee",
                             EventType = "Outdoor Festival",
                             CreatorId = user3.Id

                         }, new Event()
                         {
                             EventId = 9,
                             Name = "Nashville Crawfish Boil",
                             Price = 40,
                             StartDate = DateTime.Parse("2019/05/25"),
                            
                             Description =
                            "The annual East Nashville Crawfish Bash is Saturday, May 25, 2019, from noon to 9:00pm in East Park. The East Nashville celebration will feature local food, art, music, and breweries for a family- and pet-friendly day of fun. Admission is free, but ticket options are also available if you want to secure a plate of crawfish or enjoy VIP perks.",
                             InfoURL = "http://eastnashcrawbash.com/",
                             ImageURL = "https://pridepublishinggroup.com/pride/wp-content/uploads/2019/01/st-jude-race.jpg",
                             City = "Nashville",
                             State = "Tennessee",
                             EventType = "Outdoor Festival",
                             CreatorId = user.Id

                         }, new Event()
                         {
                             EventId = 10,
                             Name = "CMA Music Festival",
                             Price = 0,
                             StartDate = DateTime.Parse("2019/04/27"),
                             
                             Description =
                            "Get ready country music fans—it’s almost time for Nashville’s most beloved music event, the CMA Music Festival. The event is Thursday through Sunday, June 6-9, 2019, in Downtown Nashville, and attracts about 80,000 locals and tourists for one weekend of country music lovin’.",
                             InfoURL = "https://cmafest.com/",
                             ImageURL = "https://cmafest.com/wp-content/uploads/2019/04/Ascend-Amphitheater-900x500-815x460.jpg",
                             City = "Nashville",
                             State = "Tennessee",
                             EventType = "Outdoor Festival",
                             CreatorId = user2.Id

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
