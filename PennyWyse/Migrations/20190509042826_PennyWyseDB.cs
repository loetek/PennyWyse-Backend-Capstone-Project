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
                    Family = table.Column<bool>(nullable: false),
                    LegalAge = table.Column<bool>(nullable: false),
                    ProfileImageURL = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
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
                    LegalAge = table.Column<bool>(nullable: false),
                    FamilyEvent = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    InfoURL = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    EventType = table.Column<string>(nullable: true),
                    CreatorId = table.Column<int>(nullable: true),
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
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Email", "EmailConfirmed", "Family", "FirstName", "LastName", "LegalAge", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageURL", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b19c83f2-2fa3-4f47-8927-e2e560105bd2", 0, "Nashville", "29d9d99a-a52a-439f-956f-e72a74627594", "admin@admin.com", true, false, "admin", "admin", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAECh9EKBWhcYIjiDTq/9wtEizx3QYDNvLHKFVto2VQdiibvYePp9uQka5E4QjodPs2g==", null, false, "https://s3.amazonaws.com/37assets/svn/1065-IMG_2529.jpg", "693181cc-f73a-47cc-bea3-cc41259d23f2", "Tennessee", false, "admin@admin.com" },
                    { "b1588c9e-f3b6-4f73-aa7c-987fd5fc720e", 0, "Nashville", "378262ab-3edc-4694-b771-5a50a20d61a6", "jd@jd.com", true, true, "JD", "Wheeler", false, false, null, "JD@JD.COM", "JD@JD.COM", "AQAAAAEAACcQAAAAEDYgesFf9/lx7Y4s79c7ETu7NunaZCew9GT3dS0DvK5GGD18UNnVKJg4Kb+J4far2Q==", null, false, "https://s3.amazonaws.com/37assets/svn/1065-IMG_2529.jpg", "6b211772-a684-4855-b549-1bef1ef5d415", "Tennessee", false, "jd@jd.com" },
                    { "59a02b6e-9f7a-47e4-9138-ec87086e12ad", 0, "Nashville", "a1338bd1-5156-45ab-bb2f-19e65d0099dc", "joey@joey.com", true, false, "Joey", "B", true, false, null, "JOEY@JOEY.COM", "JOEY@JOEY.COM", "AQAAAAEAACcQAAAAEARGul3WxRGVxEWpArCMqEoRaY+iUeyXWVouH4+DLBjWsOy6oJG6Uj64HSQ8721V3Q==", null, false, "https://s3.amazonaws.com/37assets/svn/1065-IMG_2529.jpg", "a91506ef-92a3-4d5c-b3bf-9ab706399a54", "Tennessee", false, "joey@joey.com" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "City", "CreatorId", "Description", "EventType", "FamilyEvent", "ImageURL", "InfoURL", "LegalAge", "Name", "Price", "StartDate", "State", "UserEventId", "UserId", "UserId1" },
                values: new object[,]
                {
                    { 1, "Nashville", null, "Run Rock 'n' Roll Nashville Marathon, Half Marathon, 5k, and KiDS ROCK | The Rock 'n' Roll Nashville ... Join us in celebrating 20 years running in Music City!", "Sports", true, "https://pridepublishinggroup.com/pride/wp-content/uploads/2019/01/st-jude-race.jpg", "https://www.runrocknroll.com/nashville/", false, "Music City Marathon", 50, new DateTime(2019, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee", null, 0, null },
                    { 2, "Nashville", null, "Bring the entire family and come enjoy Nashville's BEST Hot Air Balloon Festival! Is there any better way to kick off summer Tennessee ? !Held on a large field just minutes from downtown join dozens of vendors chefs local musicians artists cooking demonstrations pop - up art galleriesPLUS food and alcohol tasting partners.", "Outdoor", true, "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F52525323%2F211234311650%2F1%2Foriginal.jpg?w=800&auto=compress&rect=0%2C38%2C960%2C480&s=07e01664e96aca88dc46985863a58c81", "https://victorycup.org/nashville/", false, "Nashville Hot Air Balloon Festival", 300, new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee", null, 0, null },
                    { 3, "Nashville", null, "Don’t miss the second-annual Nashville Rosé Festival! One of the city’s most talked- and instagrammed-about events last year, we are thrilled celebrate our second year in East Nashville’s East Park and have another chance to support one of our favorite charities, the Tennessee Breast Cancer Coalition. ", "Festival", false, "https://img.evbuc.com/https%3A%2F%2Fcdn.evbuc.com%2Fimages%2F50613290%2F33678832033%2F1%2Foriginal.jpg?w=800&auto=compress&rect=133%2C0%2C1654%2C827&s=6d96074a1714d0dc6514f98fe44049de", "https://www.nashvillerosefestival.com/", true, "Nashville Rosé Festival ", 40, new DateTime(2019, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tennessee", null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "UserEvents",
                columns: new[] { "UserEventId", "EventId", "UserId" },
                values: new object[] { 1, 1, "b1588c9e-f3b6-4f73-aa7c-987fd5fc720e" });

            migrationBuilder.InsertData(
                table: "UserEvents",
                columns: new[] { "UserEventId", "EventId", "UserId" },
                values: new object[] { 2, 2, "b1588c9e-f3b6-4f73-aa7c-987fd5fc720e" });

            migrationBuilder.InsertData(
                table: "UserEvents",
                columns: new[] { "UserEventId", "EventId", "UserId" },
                values: new object[] { 3, 3, "59a02b6e-9f7a-47e4-9138-ec87086e12ad" });

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
