using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Savitar.Infrastructure.Repository.EFCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTechnologyCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTechnologyCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "ProjectTechnologies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    FirstUse = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUse = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsageFrequency = table.Column<int>(type: "int", nullable: false),
                    Proficiency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTechnologies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTechnologies_ProjectTechnologyCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProjectTechnologyCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ProjectTechnologyCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "IDE" },
                    { 2, "Language" },
                    { 3, "Framework" },
                    { 4, "Database" },
                    { 5, "ORM" },
                    { 6, "Tool" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "<p>Specialising in cross platform .NET technologies, I am a full stack dev for hire.</p>\r\n<p>I have been a coder since I was 15 in 1986 and turned professional in 1996. I have been a coder ever since - and won't have it any other way. This passion for what I do ensures you get software written with pride.</p>\r\n<br />\r\n<p>You can purchase my time in a multitude of flexible ways, including...</p>\r\n<ul>\r\n    <li>Per Module</li>\r\n    <li>Per Project</li>    \r\n    <li>Per Hour</li>\r\n    <li>1 or more days per week - 1 or more weeks per month (most common). We agree on the pre-booked time and enter into a retainer. The per hour rate is also reduced relative to the kind of time booked in this arrangment.</li>\r\n</ul>\r\n<br />\r\n<p>Your invoice will come from Savitar IT (VAT registered).</p>", "Software Development Services" },
                    { 2, "From the ground up, I can build you a new system adhering to the most current standards and specifications.\r\n<br/><br/>\r\nEnterprise systems built on top of open source .NET Core.\r\n                ", "Complete Systems" },
                    { 3, "Having many years experience in a multitude of languages and frameworks (please see <a href='/skillsmatrix'>Skills Matrix</a>), I can assist with upgrading legacy language/framework systems to more modern languages and frameworks.\r\n<br/><br/>\r\n<b>Use Cases</b>\r\n<ul>\r\n    <li>Angular / React / Vue TO Blazor WebAssembly</li>\r\n    <li>WPF (Windows Presentation Foundation) or Silverlight to Blazor (WebAssembly or Server)</li>    \r\n    <li>.NET Framework TO .NET 5</li>\r\n    <li>C / C++ / Delphi / Visual Basic TO C#</li>\r\n    <li>Desktop application to Web application</li>\r\n</ul>", "Conversions/Upgrades" },
                    { 4, "I can help your juniors accellerate their learning curves. I love to talk and teach code!", "Mentoring" }
                });

            migrationBuilder.InsertData(
                table: "ProjectTechnologies",
                columns: new[] { "Id", "CategoryId", "FirstUse", "LastUse", "Name", "Proficiency", "UsageFrequency" },
                values: new object[,]
                {
                    { 11, 1, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Visual Studio", 3, 3 },
                    { 4, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, ".NET 5", 2, 3 },
                    { 16, 4, new DateTime(1997, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AS400 Mainframe", 0, 2 },
                    { 22, 4, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Microsoft Access", 2, 1 },
                    { 7, 4, new DateTime(1998, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Local), "SQL Server", 3, 3 },
                    { 8, 4, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PostgreSQL", 0, 0 },
                    { 24, 5, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Entity Framework", 3, 2 },
                    { 29, 3, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VUE", 0, 0 },
                    { 25, 5, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nHibernate", 2, 0 },
                    { 15, 6, new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Excel", 2, 2 },
                    { 12, 6, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Postman", 2, 2 },
                    { 10, 6, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Structure Map", 3, 2 },
                    { 27, 6, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RabbitMQ", 0, 0 },
                    { 32, 6, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "PowerShell", 3, 2 },
                    { 34, 6, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apache Spark", 0, 0 },
                    { 9, 6, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Automapper", 3, 2 },
                    { 35, 6, new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Docker", 0, 1 },
                    { 21, 3, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Web/REST API", 3, 3 },
                    { 2, 3, new DateTime(2001, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, ".NET Framework", 3, 3 },
                    { 30, 1, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PyCharm", 0, 0 },
                    { 31, 1, new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "VS Code", 2, 2 },
                    { 33, 1, new DateTime(2005, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borland Developer Studio", 3, 0 },
                    { 23, 2, new DateTime(1994, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C++", 3, 0 },
                    { 1, 2, new DateTime(2001, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "C#", 3, 3 },
                    { 14, 2, new DateTime(1995, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delphi", 3, 3 },
                    { 20, 3, new DateTime(2003, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web Services", 2, 0 },
                    { 18, 2, new DateTime(1997, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Basic", 2, 0 },
                    { 13, 2, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turbo Pascal", 3, 2 },
                    { 26, 2, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Javascript", 3, 3 },
                    { 28, 2, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Python", 0, 0 },
                    { 5, 3, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Blazor Server", 2, 3 },
                    { 6, 3, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Blazor WebAssembly", 2, 3 },
                    { 3, 3, new DateTime(2014, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, ".NET Core", 2, 2 },
                    { 19, 2, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Basic.NET", 2, 3 },
                    { 36, 6, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MudBlazor", 2, 2 }
                });

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
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTechnologies_CategoryId",
                table: "ProjectTechnologies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTechnologies_Name",
                table: "ProjectTechnologies",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTechnologyCategories_Name",
                table: "ProjectTechnologyCategories",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Services_Title",
                table: "Services",
                column: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "ProjectTechnologies");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ProjectTechnologyCategories");
        }
    }
}
