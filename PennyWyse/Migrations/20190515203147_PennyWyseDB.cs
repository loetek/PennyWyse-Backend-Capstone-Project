using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PennyWyse.Migrations
{
    public partial class PennyWyseDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ProfileImageURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    InfoURL = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    EventType = table.Column<string>(nullable: true),
                    CreatorId = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true),
                    UserEventId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserEvents",
                columns: table => new
                {
                    UserEventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEvents", x => x.UserEventId);
                    table.ForeignKey(
                        name: "FK_UserEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEvents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageURL", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "afb60560-4f59-4922-8e41-3051aa30f54d", 0, "Nashville", "83031d25-2cff-4420-bda8-ff9ffb79ede0", "admin@admin.com", true, "admin", "admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEE+C8njCXHHOhKG7wjkeUJNXTOMDqX+6ArtPVfkFgz62mNOvORm8geJJhAOtoRv1fQ==", null, false, "https://s3.amazonaws.com/37assets/svn/1065-IMG_2529.jpg", "d9b0cf6f-2b1c-44fb-a528-b17bae6acc15", "Tennessee", false, "admin@admin.com" },
                    { "55a05d74-3a66-434d-a345-68258f784eae", 0, "Nashville", "59516f99-abf9-4a58-9e4c-0a7e4a1dfcad", "jd@jd.com", true, "JD", "Wheeler", false, null, "JD@JD.COM", "JD@JD.COM", "AQAAAAEAACcQAAAAEFF7sGm7H6sUcbxNbVYq+emJMg2anba/UU29Xyqrbc7X1VB8I/ykdvgbrBbxRgppbQ==", null, false, "https://s3.amazonaws.com/37assets/svn/1065-IMG_2529.jpg", "48c93f27-1bf7-407d-adc3-cf3eb591f570", "Tennessee", false, "jd@jd.com" },
                    { "ad516c46-2420-48f1-bfd4-b119563c6616", 0, "Nashville", "4f26623b-354d-4eb6-bc84-1ae8821edfdc", "joey@joey.com", true, "Joey", "B", false, null, "JOEY@JOEY.COM", "JOEY@JOEY.COM", "AQAAAAEAACcQAAAAEAoex6nit4+6iGkLUudfJFR6Z3yp1e8vjxcU//gBPSh2N1Cx+J6g84AA4rPP4DK5yQ==", null, false, "https://s3.amazonaws.com/37assets/svn/1065-IMG_2529.jpg", "5f28e661-9d8f-43b5-8ecf-07d418aa2eb8", "Tennessee", false, "joey@joey.com" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "City", "CreatorId", "Description", "EventType", "ImageURL", "InfoURL", "Name", "Price", "StartDate", "State", "UserEventId", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, "Nashville", "afb60560-4f59-4922-8e41-3051aa30f54d", "Run Rock 'n' Roll Nashville Marathon, Half Marathon, 5k, and KiDS ROCK | The Rock 'n' Roll Nashville ... Join us in celebrating 20 years running in Music City!", "Sports", "https://pridepublishinggroup.com/pride/wp-content/uploads/2019/01/st-jude-race.jpg", "https://www.runrocknroll.com/nashville/", "Music City Marathon", 50, new DateTime(2019, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee", null, 0, null },
                    { 2, "Nashville", "afb60560-4f59-4922-8e41-3051aa30f54d", "Bring the entire family and come enjoy Nashville's BEST Hot Air Balloon Festival! Is there any better way to kick off summer Tennessee ? !Held on a large field just minutes from downtown join dozens of vendors chefs local musicians artists cooking demonstrations pop - up art galleriesPLUS food and alcohol tasting partners.", "Outdoor", "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F52525323%2F211234311650%2F1%2Foriginal.jpg?w=800&auto=compress&rect=0%2C38%2C960%2C480&s=07e01664e96aca88dc46985863a58c81", "https://victorycup.org/nashville/", "Nashville Hot Air Balloon Festival", 300, new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee", null, 0, null },
                    { 3, "Nashville", "afb60560-4f59-4922-8e41-3051aa30f54d", "Don’t miss the second-annual Nashville Rosé Festival! One of the city’s most talked- and instagrammed-about events last year, we are thrilled celebrate our second year in East Nashville’s East Park and have another chance to support one of our favorite charities, the Tennessee Breast Cancer Coalition. ", "Festival", "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F50613290%2F33678832033%2F1%2Foriginal.jpg?w=800&auto=compress&rect=133%2C0%2C1654%2C827&s=6d96074a1714d0dc6514f98fe44049de", "https://www.nashvillerosefestival.com/", "Nashville Rosé Festival ", 40, new DateTime(2019, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee", null, 0, null },
                    { 4, "Nashville", "55a05d74-3a66-434d-a345-68258f784eae", "Nashville Zoo welcomes all species of beer lovers to the eighth annual Brew at the Zoo happening on Friday, May 31 from 6:30pm to 10:30pm. Animals, live music, local food trucks and over 100 craft beers are on tap at this unique after-hours event voted the best beer event in Nashville by Nashville Scene readers in 2014 and 2016.", "Outdoor", "http://nashvilleguru.com/officialwebsite/wp-content/uploads/2015/05/Brew-at-the-Zoo.jpg", "https://www.nashvillezoo.org/upcoming-events/entry/brew-at-the-zoo/instance/5-31-2019", "Brew at the Zoo", 75, new DateTime(2019, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee", null, 0, null },
                    { 5, "Manchester", "ad516c46-2420-48f1-bfd4-b119563c6616", "The Bonnaroo Music and Arts Festival is an American annual four-day music festival developed and produced by Superfly Presents and AC Entertainment. Since its first year in 2002, it has been held at what is now Great Stage Park on a 650-acre (263 km2) farm in Manchester, Tennessee. The festival typically starts on the second Thursday in June and lasts four days. Main attractions of this festival are the multiple stages featuring live music with a diverse array of musical styles including indie rock, classic rock, world music, hip hop, jazz, americana, bluegrass, country music, folk, gospel, reggae, pop, electronic, and other alternative music.", "Music Festival", "https://www.bonnaroo.com/wp-www-bonnaroo-com/wp/wp-content/uploads/2018/11/logo-1bb87d41-b09cb133.png", "https://www.bonnaroo.com/", "Bonnaroo", 350, new DateTime(2019, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee", null, 0, null },
                    { 6, "Nashville", "55a05d74-3a66-434d-a345-68258f784eae", "Pride parades are outdoor events celebrating lesbian, gay, bisexual, transgender, and queer social and self acceptance, achievements, legal rights and pride. The events also at times serve as demonstrations for legal rights such as same-sex marriage.", "Parade", "http://nashvilleguru.com/officialwebsite/wp-content/uploads/2015/06/Nashville-Pride-Festival-1.jpg", "https://www.nashvillepride.org/", "Nashville Pride", 5, new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee", null, 0, null },
                    { 7, "Nashville", "afb60560-4f59-4922-8e41-3051aa30f54d", "WestEnd Kitchen & Bar is excited to welcome fans of celebrity magician Justin Flom with a special, An Evening of Magic dinner package. The package includes one entrée, one glass of house wine or beer, valet parking plus two general admission tickets to the show.", "Show", "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F56447862%2F50800243798%2F1%2Foriginal.20190207-205651?w=800&auto=compress&rect=0%2C0%2C2160%2C1080&s=a3bfbcc116e5622166604d60a6b2a5b5", "https://www.eventbrite.com/e/an-evening-of-magic-with-justin-flom-at-analog-at-hutton-hotel-tickets-55677038521", "An Evening of Magic with Justin Flom", 50, new DateTime(2019, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee", null, 0, null },
                    { 8, "Nashville", "ad516c46-2420-48f1-bfd4-b119563c6616", "The Master Gardeners of Davidson County will be hosting the Urban Gardening Festival on Saturday, May 18, 2019, from 9:00am to 4:00pm at the Ellington Agricultural Center. The public is invited to learn gardening methods, techniques, and engage with local growers, artisans, exhibitors, educators, and more. There will also be local food trucks with food and beverages. The event is rain or shine. All ages are welcome.", "Outdoor Festival", "http://nashvilleguru.com/officialwebsite/wp-content/uploads/2018/05/Urban-Gardening-Fest-01.jpg", "http://mgofdc.org/ugf", "Urban Gardening Festival", 0, new DateTime(2019, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee", null, 0, null },
                    { 9, "Nashville", "afb60560-4f59-4922-8e41-3051aa30f54d", "The annual East Nashville Crawfish Bash is Saturday, May 25, 2019, from noon to 9:00pm in East Park. The East Nashville celebration will feature local food, art, music, and breweries for a family- and pet-friendly day of fun. Admission is free, but ticket options are also available if you want to secure a plate of crawfish or enjoy VIP perks.", "Outdoor Festival", "https://pridepublishinggroup.com/pride/wp-content/uploads/2019/01/st-jude-race.jpg", "http://eastnashcrawbash.com/", "Nashville Crawfish Boil", 40, new DateTime(2019, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee", null, 0, null },
                    { 10, "Nashville", "55a05d74-3a66-434d-a345-68258f784eae", "Get ready country music fans—it’s almost time for Nashville’s most beloved music event, the CMA Music Festival. The event is Thursday through Sunday, June 6-9, 2019, in Downtown Nashville, and attracts about 80,000 locals and tourists for one weekend of country music lovin’.", "Outdoor Festival", "https://cmafest.com/wp-content/uploads/2019/04/Ascend-Amphitheater-900x500-815x460.jpg", "https://cmafest.com/", "CMA Music Festival", 0, new DateTime(2019, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee", null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "UserEvents",
                columns: new[] { "UserEventId", "EventId", "UserId" },
                values: new object[] { 1, 1, "55a05d74-3a66-434d-a345-68258f784eae" });

            migrationBuilder.InsertData(
                table: "UserEvents",
                columns: new[] { "UserEventId", "EventId", "UserId" },
                values: new object[] { 2, 2, "55a05d74-3a66-434d-a345-68258f784eae" });

            migrationBuilder.InsertData(
                table: "UserEvents",
                columns: new[] { "UserEventId", "EventId", "UserId" },
                values: new object[] { 3, 3, "ad516c46-2420-48f1-bfd4-b119563c6616" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserEventId",
                table: "Events",
                column: "UserEventId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId1",
                table: "Events",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_EventId",
                table: "UserEvents",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_UserId",
                table: "UserEvents",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_UserEvents_UserEventId",
                table: "Events",
                column: "UserEventId",
                principalTable: "UserEvents",
                principalColumn: "UserEventId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_UserId1",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEvents_AspNetUsers_UserId",
                table: "UserEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_UserEvents_UserEventId",
                table: "Events");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "UserEvents");

            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
