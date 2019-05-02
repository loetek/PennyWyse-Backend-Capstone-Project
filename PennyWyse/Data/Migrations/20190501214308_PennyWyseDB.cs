using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PennyWyse.Data.Migrations
{
    public partial class PennyWyseDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Family",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "LegalAge",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ProfileImageURL",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    LegalAge = table.Column<bool>(nullable: false),
                    FamilyEvent = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    InfoURL = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    EventType = table.Column<string>(nullable: true),
                    CreatorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "Family", "FirstName", "LastName", "LegalAge", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageURL", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4f867d1a-81e4-4ca0-8c72-bcfb4bf32127", 0, "Nashville", "843a2c82-4ff3-4308-b3ae-c8852f50fb35", "admin@admin.com", true, false, "admin", "admin", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAECRpGhqtTAJqEbGg0Na+Twd+W9htk8e5qiGuaTX7hWpipXHFAVupHBApQpIjPeIDqA==", null, false, "https://s3.amazonaws.com/37assets/svn/1065-IMG_2529.jpg", "7dc71d1f-d907-4852-b84f-d4aad0d2782b", "Tennessee", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "City", "CreatorId", "Description", "EventType", "FamilyEvent", "ImageURL", "InfoURL", "LegalAge", "Name", "Price", "StartDate", "State" },
                values: new object[,]
                {
                    { 1, "Nashville", null, "Run Rock 'n' Roll Nashville Marathon, Half Marathon, 5k, and KiDS ROCK | The Rock 'n' Roll Nashville ... Join us in celebrating 20 years running in Music City!", "Sports", true, "https://pridepublishinggroup.com/pride/wp-content/uploads/2019/01/st-jude-race.jpg", "https://www.runrocknroll.com/nashville/", false, "Music City Marathon", 50, new DateTime(2019, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee" },
                    { 2, "Nashville", null, "Bring the entire family and come enjoy Nashville's BEST Hot Air Balloon Festival! Is there any better way to kick off summer Tennessee ? !Held on a large field just minutes from downtown join dozens of vendors chefs local musicians artists cooking demonstrations pop - up art galleriesPLUS food and alcohol tasting partners.", "Outdoor", true, "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F52525323%2F211234311650%2F1%2Foriginal.jpg?w=800&auto=compress&rect=0%2C38%2C960%2C480&s=07e01664e96aca88dc46985863a58c81", "https://victorycup.org/nashville/", false, "Nashville Hot Air Balloon Festival", 300, new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee" },
                    { 3, "Nashville", null, "Don’t miss the second-annual Nashville Rosé Festival! One of the city’s most talked- and instagrammed-about events last year, we are thrilled celebrate our second year in East Nashville’s East Park and have another chance to support one of our favorite charities, the Tennessee Breast Cancer Coalition. ", "Festival", false, "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F50613290%2F33678832033%2F1%2Foriginal.jpg?w=800&auto=compress&rect=133%2C0%2C1654%2C827&s=6d96074a1714d0dc6514f98fe44049de", "https://www.nashvillerosefestival.com/", true, "Nashville Rosé Festival ", 40, new DateTime(2019, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f867d1a-81e4-4ca0-8c72-bcfb4bf32127");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Family",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LegalAge",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfileImageURL",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "AspNetUsers");
        }
    }
}
