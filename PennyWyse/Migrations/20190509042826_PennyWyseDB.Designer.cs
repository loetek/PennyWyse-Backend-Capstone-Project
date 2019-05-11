﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PennyWyse.Data;

namespace PennyWyse.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190509042826_PennyWyseDB")]
    partial class PennyWyseDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PennyWyse.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<int?>("CreatorId");

                    b.Property<string>("Description");

                    b.Property<string>("EventType");

                    b.Property<bool>("FamilyEvent");

                    b.Property<string>("ImageURL");

                    b.Property<string>("InfoURL");

                    b.Property<bool>("LegalAge");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Price");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("State");

                    b.Property<int?>("UserEventId");

                    b.Property<int>("UserId");

                    b.Property<string>("UserId1");

                    b.HasKey("EventId");

                    b.HasIndex("UserEventId");

                    b.HasIndex("UserId1");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = 1,
                            City = "Nashville",
                            Description = "Run Rock 'n' Roll Nashville Marathon, Half Marathon, 5k, and KiDS ROCK | The Rock 'n' Roll Nashville ... Join us in celebrating 20 years running in Music City!",
                            EventType = "Sports",
                            FamilyEvent = true,
                            ImageURL = "https://pridepublishinggroup.com/pride/wp-content/uploads/2019/01/st-jude-race.jpg",
                            InfoURL = "https://www.runrocknroll.com/nashville/",
                            LegalAge = false,
                            Name = "Music City Marathon",
                            Price = 50,
                            StartDate = new DateTime(2019, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            State = "Tennessee",
                            UserId = 0
                        },
                        new
                        {
                            EventId = 2,
                            City = "Nashville",
                            Description = "Bring the entire family and come enjoy Nashville's BEST Hot Air Balloon Festival! Is there any better way to kick off summer Tennessee ? !Held on a large field just minutes from downtown join dozens of vendors chefs local musicians artists cooking demonstrations pop - up art galleriesPLUS food and alcohol tasting partners.",
                            EventType = "Outdoor",
                            FamilyEvent = true,
                            ImageURL = "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F52525323%2F211234311650%2F1%2Foriginal.jpg?w=800&auto=compress&rect=0%2C38%2C960%2C480&s=07e01664e96aca88dc46985863a58c81",
                            InfoURL = "https://victorycup.org/nashville/",
                            LegalAge = false,
                            Name = "Nashville Hot Air Balloon Festival",
                            Price = 300,
                            StartDate = new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            State = "Tennessee",
                            UserId = 0
                        },
                        new
                        {
                            EventId = 3,
                            City = "Nashville",
                            Description = "Don’t miss the second-annual Nashville Rosé Festival! One of the city’s most talked- and instagrammed-about events last year, we are thrilled celebrate our second year in East Nashville’s East Park and have another chance to support one of our favorite charities, the Tennessee Breast Cancer Coalition. ",
                            EventType = "Festival",
                            FamilyEvent = false,
                            ImageURL = "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F50613290%2F33678832033%2F1%2Foriginal.jpg?w=800&auto=compress&rect=133%2C0%2C1654%2C827&s=6d96074a1714d0dc6514f98fe44049de",
                            InfoURL = "https://www.nashvillerosefestival.com/",
                            LegalAge = true,
                            Name = "Nashville Rosé Festival ",
                            Price = 40,
                            StartDate = new DateTime(2019, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            State = "Tennessee",
                            UserId = 0
                        });
                });

            modelBuilder.Entity("PennyWyse.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("Family");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LegalAge");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfileImageURL");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("State");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "b19c83f2-2fa3-4f47-8927-e2e560105bd2",
                            AccessFailedCount = 0,
                            City = "Nashville",
                            ConcurrencyStamp = "29d9d99a-a52a-439f-956f-e72a74627594",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            Family = false,
                            FirstName = "admin",
                            LastName = "admin",
                            LegalAge = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECh9EKBWhcYIjiDTq/9wtEizx3QYDNvLHKFVto2VQdiibvYePp9uQka5E4QjodPs2g==",
                            PhoneNumberConfirmed = false,
                            ProfileImageURL = "https://s3.amazonaws.com/37assets/svn/1065-IMG_2529.jpg",
                            SecurityStamp = "693181cc-f73a-47cc-bea3-cc41259d23f2",
                            State = "Tennessee",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        },
                        new
                        {
                            Id = "b1588c9e-f3b6-4f73-aa7c-987fd5fc720e",
                            AccessFailedCount = 0,
                            City = "Nashville",
                            ConcurrencyStamp = "378262ab-3edc-4694-b771-5a50a20d61a6",
                            Email = "jd@jd.com",
                            EmailConfirmed = true,
                            Family = true,
                            FirstName = "JD",
                            LastName = "Wheeler",
                            LegalAge = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "JD@JD.COM",
                            NormalizedUserName = "JD@JD.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDYgesFf9/lx7Y4s79c7ETu7NunaZCew9GT3dS0DvK5GGD18UNnVKJg4Kb+J4far2Q==",
                            PhoneNumberConfirmed = false,
                            ProfileImageURL = "https://s3.amazonaws.com/37assets/svn/1065-IMG_2529.jpg",
                            SecurityStamp = "6b211772-a684-4855-b549-1bef1ef5d415",
                            State = "Tennessee",
                            TwoFactorEnabled = false,
                            UserName = "jd@jd.com"
                        },
                        new
                        {
                            Id = "59a02b6e-9f7a-47e4-9138-ec87086e12ad",
                            AccessFailedCount = 0,
                            City = "Nashville",
                            ConcurrencyStamp = "a1338bd1-5156-45ab-bb2f-19e65d0099dc",
                            Email = "joey@joey.com",
                            EmailConfirmed = true,
                            Family = false,
                            FirstName = "Joey",
                            LastName = "B",
                            LegalAge = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JOEY@JOEY.COM",
                            NormalizedUserName = "JOEY@JOEY.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEARGul3WxRGVxEWpArCMqEoRaY+iUeyXWVouH4+DLBjWsOy6oJG6Uj64HSQ8721V3Q==",
                            PhoneNumberConfirmed = false,
                            ProfileImageURL = "https://s3.amazonaws.com/37assets/svn/1065-IMG_2529.jpg",
                            SecurityStamp = "a91506ef-92a3-4d5c-b3bf-9ab706399a54",
                            State = "Tennessee",
                            TwoFactorEnabled = false,
                            UserName = "joey@joey.com"
                        });
                });

            modelBuilder.Entity("PennyWyse.Models.UserEvent", b =>
                {
                    b.Property<int>("UserEventId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EventId");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("UserEventId");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("UserEvents");

                    b.HasData(
                        new
                        {
                            UserEventId = 1,
                            EventId = 1,
                            UserId = "b1588c9e-f3b6-4f73-aa7c-987fd5fc720e"
                        },
                        new
                        {
                            UserEventId = 2,
                            EventId = 2,
                            UserId = "b1588c9e-f3b6-4f73-aa7c-987fd5fc720e"
                        },
                        new
                        {
                            UserEventId = 3,
                            EventId = 3,
                            UserId = "59a02b6e-9f7a-47e4-9138-ec87086e12ad"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PennyWyse.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PennyWyse.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PennyWyse.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PennyWyse.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PennyWyse.Models.Event", b =>
                {
                    b.HasOne("PennyWyse.Models.UserEvent")
                        .WithMany("Events")
                        .HasForeignKey("UserEventId");

                    b.HasOne("PennyWyse.Models.User", "User")
                        .WithMany("Events")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("PennyWyse.Models.UserEvent", b =>
                {
                    b.HasOne("PennyWyse.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PennyWyse.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}