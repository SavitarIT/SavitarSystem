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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
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
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DevelopmentTechnologyCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevelopmentTechnologyCategories", x => x.Id);
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
                    RoleId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DevelopmentTechnologies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DevelopmentTechnologyCategoryId = table.Column<int>(type: "int", nullable: false),
                    FirstUse = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUse = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsageFrequency = table.Column<int>(type: "int", nullable: false),
                    Proficiency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevelopmentTechnologies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DevelopmentTechnologies_DevelopmentTechnologyCategories_DevelopmentTechnologyCategoryId",
                        column: x => x.DevelopmentTechnologyCategoryId,
                        principalTable: "DevelopmentTechnologyCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DevelopmentTechnologyProject",
                columns: table => new
                {
                    DevelopmentTechnologiesId = table.Column<int>(type: "int", nullable: false),
                    ProjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevelopmentTechnologyProject", x => new { x.DevelopmentTechnologiesId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_DevelopmentTechnologyProject_DevelopmentTechnologies_DevelopmentTechnologiesId",
                        column: x => x.DevelopmentTechnologiesId,
                        principalTable: "DevelopmentTechnologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DevelopmentTechnologyProject_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "1", "System Administrator", "System Administrator" },
                    { 2, "2", "Administrator", "Administrator" },
                    { 3, "3", "Guest", "Guest" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "bda824e0-409e-4e30-a82a-94a5b4b94d4c", "msmit@savitar.co.za", true, "Michael", "Smit", false, null, "MSMIT@SAVITAR.CO.ZA", "MSMIT@SAVITAR.CO.ZA", "AQAAAAEAACcQAAAAEGEX3z1L/wAyAigS1UFRDkfbScxssOzNrQ4afBPoDGj1XFHfSQSMSt/O4v1qVY+sPw==", null, false, "1d00bb6a-5fb3-4971-bd67-a6d4b7bf34ac", false, "msmit@savitar.co.za" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Savitar IT Solutions", null },
                    { 2, "Aberdare Cables", "https://www.aberdare.co.za" },
                    { 3, "Accutrak Pty (Ltd)", "https://www.accutrak.co.za" },
                    { 4, "Cosoft", null },
                    { 5, "Smartec Technologies", null }
                });

            migrationBuilder.InsertData(
                table: "DevelopmentTechnologyCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Tool" },
                    { 5, "ORM" },
                    { 4, "Database" },
                    { 1, "IDE" },
                    { 2, "Language" },
                    { 3, "Framework" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 3, "Having many years experience in a multitude of languages and frameworks, we can assist with upgrading legacy language/framework systems to more modern languages and frameworks.\r\n<br/><br/>\r\n<b>Use Cases</b>\r\n<ul>\r\n    <li>Angular / React / Vue TO Blazor WebAssembly</li>\r\n    <li>WPF (Windows Presentation Foundation) or Silverlight to Blazor (WebAssembly or Server)</li>    \r\n    <li>.NET Framework TO .NET 5</li>\r\n    <li>C / C++ / Delphi / Visual Basic TO C#</li>\r\n    <li>Desktop application to Web application</li>\r\n</ul>", "Conversions/Upgrades" },
                    { 1, "<p>Specialising in cross platform .NET technologies, we are full stack devs for hire.</p>\r\n<br />\r\n<p>You can purchase time in a multitude of flexible ways, including...</p>\r\n<ul>\r\n    <li>Per Module</li>\r\n    <li>Per Project</li>    \r\n    <li>Per Hour</li>\r\n    <li>1 or more days per week - 1 or more weeks per month (most common). We agree on the pre-booked time and enter into a retainer. The per hour rate is also reduced relative to the kind of time booked in this arrangement.</li>\r\n</ul>\r\n<br />\r\n<p>Your invoice will come from Savitar IT (VAT registered).</p>", "Software Development Services" },
                    { 2, "From the ground up, we can build you a new system adhering to the most current standards and specifications and on top of the latest technologies.", "Complete Systems" },
                    { 4, "We can help your juniors accelerate their learning curves. We love to talk and teach code!", "Mentoring" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "DevelopmentTechnologies",
                columns: new[] { "Id", "DevelopmentTechnologyCategoryId", "FirstUse", "LastUse", "Name", "Proficiency", "UsageFrequency" },
                values: new object[,]
                {
                    { 3, 3, new DateTime(2014, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, ".NET Core", 2, 2 },
                    { 6, 3, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Blazor WebAssembly", 2, 3 },
                    { 5, 3, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Blazor Server", 2, 3 },
                    { 28, 2, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Python", 0, 0 },
                    { 26, 2, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Javascript", 3, 3 },
                    { 13, 2, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turbo Pascal", 3, 2 },
                    { 2, 3, new DateTime(2001, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, ".NET Framework", 3, 3 },
                    { 19, 2, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Basic.NET", 2, 3 },
                    { 14, 2, new DateTime(1995, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delphi", 3, 3 },
                    { 1, 2, new DateTime(2001, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "C#", 3, 3 },
                    { 23, 2, new DateTime(1994, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C++", 3, 0 },
                    { 33, 1, new DateTime(2005, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Borland Developer Studio", 3, 0 },
                    { 31, 1, new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "VS Code", 2, 2 },
                    { 30, 1, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PyCharm", 0, 0 },
                    { 18, 2, new DateTime(1997, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Basic", 2, 0 },
                    { 11, 1, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Visual Studio", 3, 3 },
                    { 20, 3, new DateTime(2003, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web Services", 2, 0 },
                    { 29, 3, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VUE", 0, 0 },
                    { 34, 6, new DateTime(2020, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apache Spark", 0, 0 },
                    { 32, 6, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "PowerShell", 3, 2 },
                    { 27, 6, new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RabbitMQ", 0, 0 },
                    { 10, 6, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Structure Map", 3, 2 },
                    { 12, 6, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Postman", 2, 2 },
                    { 15, 6, new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Excel", 2, 2 },
                    { 21, 3, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Web/REST API", 3, 3 },
                    { 9, 6, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Automapper", 3, 2 },
                    { 24, 5, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Entity Framework", 3, 2 },
                    { 8, 4, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PostgreSQL", 0, 0 },
                    { 7, 4, new DateTime(1998, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Local), "SQL Server", 3, 3 },
                    { 22, 4, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Microsoft Access", 2, 1 },
                    { 16, 4, new DateTime(1997, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AS400 Mainframe", 0, 2 },
                    { 4, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, ".NET 5", 2, 3 },
                    { 25, 5, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nHibernate", 2, 0 },
                    { 35, 6, new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Docker", 0, 1 },
                    { 36, 6, new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MudBlazor", 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ClientId", "Description", "Name", "Url" },
                values: new object[,]
                {
                    { 36, 3, "Smartrail combines state of the art in-line weighbridge technology with low power RFiD tracking technology to give you real time accounting of your production volumes available on surface.\r\n\r\n    I was involved with the server development. This consisted of a Windows Service and IIS Website. The Windows Service took care or ETL and maintenance tasks, and the website for master data, reporting, etc...\r\n\r\nWhen this project started in 2005, my client only had installation files for the first version of their software. It was a Winforms application on the .NET 1 framework. I reverse engineered the system and extracted the required sources. The system was then upgraded to .NET Framework 2, and later to a web application. It then got a re-write about 6 years ago to the system it is currently.", "Smartrail", "https://www.accutrak.co.za/our-products-2/smartrail" },
                    { 17, 1, "<ul>\r\n    <li>Winforms application for cataloging and provide lookup/search functionality of various media.</li>\r\n    <li>In addition, when audio CD's are inserted, the ID of the disc is read and a lookup done to the CD-DB API to retrieve information about the disc.</li>\r\n    <li>Media can be played directly out of Media Magic. All the user has to do is search for the media they want to listen to, then insert the </li>\r\n    <li>System had the ability to rate titles to facilitate lookups by tempo, genre, year, etc...</li>\r\n</ul>", "Media Magic", null },
                    { 16, 1, "Simple user control that plugged into Incredible Connection's existing intranet that would scroll data by branch. Data was supplied via XML.", "Incredible Connection Marquee", null },
                    { 15, 1, "Web application to display the companies profile and related products.", "Hygeria", null },
                    { 14, 1, "This was a system owned / maintained by Savitar IT Solutions for about 8 years, and in use in the hospitality industry.\r\n<ul>\r\n    <li>Targets both the Franchisee and Franchisor.</li>\r\n    <li>Multiple levels of security and access. Franchisee, franchisor and administrator. Each of these levels could further define their own security and permissions based on needs.</li>\r\n    <li>Franchisees could manually capture their daily sales, or upload them automatically using our RESTful API. Stock, supplier, etc... information was manually captured.</li>\r\n    <li>Franchisors could monitor sales, reconcile sales information, generate franshisee fees (and invoice), provide upper management GP reports, setup menu items (by store, group or region), manage stock (including pricing across regions), suppliers, agents, etc...</li>\r\n</ul>", "Franchise Management System", null },
                    { 13, 1, "<ul>\r\n    <li>Winforms application to handle insurance contracts sold to owners of exotic cars like Ferrari, Lamborghini, etc...</li>\r\n    <li>The system tracked teh insurance value and start/end dates.</li>\r\n    <li>When all data was loaded into the system, the system generates a contract for the client. Contract is signed, scanned back into the system and linked to the clients profile.</li>\r\n</ul>", "Ferdinandplan", null }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "ClientId", "Description", "Name", "Url" },
                values: new object[,]
                {
                    { 12, 1, "Dawn wing reached a point where their in-house software had too many problems for the software to be usable. I was contracted to assist them with ironing out the problems and getting the software to a stable position again.", "Dawn Wing", null },
                    { 11, 1, "<ul>\r\n                            <li>Web application catering to both the employer and employee. The system ran very much in the same way PNet does but with some unique ideas provided by the client. This system was also targeted initially at the Nigerian market with the aim of going world wide at a later date.</li>\r\n                            <li>Users gained access to the system via scratch card numbers. The scratch cards are provided at various outlets around Nigeria. The employee user is able to register an account and setup their CV. They are however not able to print the CV or submit to potential employers until a valid scratch card number has been entered.</li>\r\n                            <li>Scratch card numbers are imported into the system via a flat file CSV format. These numbers are then used to verify the numbers entered in by the end user.</li>\r\n                            <li>When the CV information has been input, the end user is then able to locate potential employers based on matching criteria and similarly, employers are able to locate employees via a similar mechanism.</li>\r\n                        </ul>", "CV Magic Worldwide", null },
                    { 10, 1, "<ul>\r\n    <li>Web application for monitoring winning lotto numbers and notifies end users of winning number combinations.</li>\r\n    <li>End users would SMS the numbers they required notififcation for to a 5 digit number (like advertised on TV). The SMS is sent via the ClickATell gateway to the website and loaded into the database against the users cell number. Depending on the code entered, the end user would receive notifications for 2, 4 or 8 week periods.</li>\r\n    <li>The web application owner would load the winning numbers after each draw. If any of the notifications in the system matched the winning numbers, an SMS would be sent to the end users via the ClickATell gateway notifying them of their winning numbers.</li>\r\n</ul>", "CheckMyTicket", null },
                    { 9, 1, "Canoe Kayak World required a website to display products sold in store and to advertise events organized.", "Canoe Kayak World", null },
                    { 8, 1, "Build the Point of Sale module that is integrated in the Brilliant Account package.", "Brilliant Accounting - Point of Sale", null },
                    { 7, 1, "Company web application for advertising athletic events, handling athlete profiles, athlete event registration and displaying event results.\r\n\r\nThis web application was content managed to enable ASA to add and maintain their own pages without the need for a developer.\r\n\r\nSavitar IT was also responsible for the hosting and maintenance of this website for a few years.", "Athletics South Africa", null },
                    { 6, 1, "<ul>\r\n    <li>Similar application to Artemis Red Robot, but this version streams feed from a video camera and freezes the image when a violation is recorded. The system is also a mobile system. The PC is embedded in a hardened plastic suitcase and powered off a 12v battery.</li>\r\n    <li>Speed is recorded via a hand held or tripod mounted laser.</li>\r\n    <li>Red robot violations cannot be handled by this system.</li>\r\n</ul>", "Artemis Mobile Edition", null },
                    { 5, 1, "<ul>\r\n    <li>Traffic violation system installed on freeways and at intersections, and any other deemed to be an area speed or red robot violations are committed.</li>\r\n    <li>Speed is determined based on data fed to the system via pizzo lines laid under the road, or a laser system mounted to the camera unit. The system communicates with a Canon camera of image taking.</li>\r\n    <li>Red robot status is determined by data fed to the system via the traffic lights.</li>\r\n    <li>System can handle red robot violations, speed violations or both.</li>\r\n    <li>System is user configurable for different speed triggers, pizzo line distances, laser calibration, camera flash settings, day/night setup and camera capture delay.</li>\r\n    <li>Speed can determine when cars or trucks are passing over the lines. This is needed so the side of a truck is not snapped when a truck commits a violation. A laser is used to determine if there is a “blockage”. If so, the snap is delayed until the blockage flag is reset.</li>\r\n    <li>Data is stored internally on the camera in a SQL Server 2005 Express database and provides statistics of violations per hour, line passings per hour, etc…</li>\r\n    <li>Data is retrieved by a traffic office by inserting a memory stick into the camera USB port. The system automatically detects the memory stick and transfers data to the memory stick.</li>\r\n    <li>All images and data are stored in files encrypted using triple DES encryption. Data is overlaid on the images before storage as well as being stored alongside the images in the file for retrieval later.</li>\r\n</ul>", "Artemis Red Robot", null },
                    { 4, 1, "Contracted to Adcheck for a number of projects that I am unable to elaborate on due to an NDA in effect", "Adcheck Contractor", null },
                    { 3, 1, "Application written to enable the setting up, tracking and cash reconciliation of Nedbank ATM canisters around South Africa.\r\nI wrote the web application for the system that enabled users to setup the canisters, track their locations, monitor the status and reconcile cash-up once the canisters arrived at the cash centre.", "Absolute Systems", null },
                    { 2, 1, "The company already had a web application built off DotNetNuke. I simply built them a DNN module that facilitated online payments.", "dBit : MWeb Payment Module", null },
                    { 1, 1, "Wanting to learn the new Microsoft Blazor technology, I decided to build this site using the technology to gain some needed experience.<br/><br/>\r\n                        The aim is to introduce different concepts over time, add tools, and just generarlly showcase what Blazor is capable of, and what I can do with it.", "# Savitar WebAssembly and Server : This website :)", null },
                    { 18, 1, "Basic system to handle the management of recycled paper and exporting data to JD Edwards.", "Mondi Recyling RMS", null },
                    { 19, 1, "MWeb Business outsourced a number of web applications to us to do on their behalf. Unable to disclose further information due to an NDA, but a noteworthy entry anyway.", "MWeb Business", null },
                    { 20, 1, "Web application to display companies profile and products available", "Pacify", null },
                    { 21, 1, "<ul>\r\n    <li>Web application for handling timesheets and time invoicing.</li>\r\n    <li>System catered to companies, staff and users.</li>\r\n    <li>Invoices auto or manually emailed. Users could log in to manage/view timesheets, invoices and payments.</li>    \r\n</ul>", "Project Watch", null },
                    { 37, 3, "Minegaze is a GPS based tracking and weighing solution for the surface or open cast trackless mining environments. Minegaze makes use of the GSM network to upload collected data into the cloud with the objective of optimising production.", "Minegaze", "https://www.accutrak.co.za/our-products-2/minegaze/" },
                    { 34, 1, "eCommerce web application for radio controlled helicopters and accessories.", "Xheli", null },
                    { 39, 3, "Trucktrak is a production management system designed specifically for mechanised underground mining operations. Since there is no GPS available underground from which to obtain position, Trucktrak makes use of discretely distributed long life battery operated beacons to obtain position.", "Trucktrak", "https://www.accutrak.co.za/our-products-2/outset/" },
                    { 40, 4, "<ul>\r\n                            <li>Point Of Sale solution serving the hospitality industry. In use by Steers Holdings (Steers, Debonairs, etc..), Fishaways, Something Fishy, Hotdog Café, Scooters, and more.</li>\r\n                            <li>The system had a front end workstation for the till operators to perform sales and a back office for management to generate sales reports, setup menus, and more.</li>\r\n                            <li>All sales were uploaded nightly at the Alphapos Enterprise server – via FTP - to be imported into a data warehouse solution to enable the franchisor to view sales statistics for all franchises and outlets country wide.</li>\r\n                            <li>The application is extremely feature rich and catered to both the franchisee and franchisor needs.</li>\r\n                        </ul>", "Aura", null },
                    { 41, 5, "This is a pre-paid airtime vending system.                            \r\n                            <ul>\r\n                                <li>Vending machines are installed around the country with an interface to enable customers to purchase pre-paid airtime.</li>\r\n                                <li>The vending machine communicates with a server via GPRS/EDGE/3D/HSDPA depending on the signal available at the installed location.</li>\r\n                                <li>Accounts for the vending machine owner are maintained on the server and data is synchronized with the vending machine from time to time.</li>\r\n                                <li>All vending machines are loaded with enough stock to last 2 days. As soon as the stock levels for any product reach 8 hours, the vending machine uploads all sales, and downloads new stock to replenish its-self based on items needed to see it through for the next 2 days.The quantities are determined by calculating average daily sales over the last 14 days. This prevents the terminal from having too little stock and therefore connecting too often or having too much thereby preventing sales from being uploaded regularly.</li>\r\n                                <li>Vending machines use Web Services via the SOAP protocol to communicate with the server.</li>\r\n                                <li>The service side has a complete management web interface to enable staff to setup vending machines, deploy settings to vending machines, manage accounts, funds, import stock, generate GP reports, etc…</li>\r\n                                <li>The server solution had to calculate commissions for account holders based on sales and pre-configured percentage settings.Account holders were also able to login to the web frontend to view sales statistics, draw reports and support queries.</li>\r\n                            </ul>", "Top-It-Up", null },
                    { 42, 5, "<ul>\r\n    <li>System to handle the management of starter packs sold to distributors, then to vendors - and generated commission.</li>\r\n    <li>Allows for distributor and vendor login to enable the rendering of reports for cash balances, stock orders, commissions generated, payments made, etc...</li>\r\n    <li>Starter packs are sold by CellC to a distributor (Hi-Fi Corp, etc...). The stock is sent to the system via flat file and loaded into SQL Server. Vendors then purchase the stock at Point Of Sale terminals at the distributor, with communications via SOAP Web Services in real time.</li>    \r\n</ul>", "CellC Distributor / Vendor Management System", null },
                    { 33, 1, "<ul>\r\n    <li>Winamp 2.x plugin</li>\r\n    <li>Winamp had no mechanism to rate tracks or set tempo. This plug-in enabled a user to rate tracks and set the tempo\r\nvia global hot keys (Winamp did not need focus to handle the hotkeys). Tracks could then be loaded via these\r\nsettings by the end user.</li>\r\n</ul>", "Winamp Ratings", null },
                    { 32, 1, "<ul>\r\n    <li>Winamp 2.x plugin</li>\r\n    <li>Hooks all winamp windows and log internal window messages sent between the various Winamp windows. The plugin is a developer tool to assist plugin developers of Winamp plugins to easily work out which messages to intercept.\r\nThis was released free to the community and assisted me with further Winamp development.</li>\r\n</ul>", "Winamp Monitor", null },
                    { 35, 2, "Management required production information from the factory floor. \r\nThe IT Manager wanted a system coded in VB, but the order of the required software was taking time, so I made a plan using Microsoft Excel (VBA) to extract the information required from the AS400, generate graphs and tables, and dump it on the companies LAN.\r\n\r\nThis system remained in use for around 15 years after I moved on!\r\n\r\nBeing the first PC developer in the company, I was also responsible for assisting with network installation, PC builds, etc...", "AS400ToIntranet", null },
                    { 31, 1, "This application was written back in the Windows For Workgroups days as a frontend to the command line only tool, WinAce. It offered a graphical user interface to the end user for configuring archive settings, storage location and encryption mechanism. Data was then fed via the cmd line to Winace to do the actual work.", "Winace Frontend", null },
                    { 29, 1, "<ul>\r\n    <li>Windows application for the SABC marketing department. The application handled the cataloging and retrieval of adverts that were recorded for use on the various radio stations.</li>\r\n    <li>A custom database backend was developed for use in this application employing the use of C++ structs. The custom database also supported indexing for fast retrieval.</li>\r\n</ul>", "SmartAd", null },
                    { 28, 1, "Simple web application advertising the companies services", "Signature Placements", null },
                    { 27, 1, "Web application to display company information and available products", "Signal Systems", null },
                    { 26, 1, "Web application for handling the distribution of radio controlled helicopters and accessories.\r\n<ul>\r\n    <li>Dual purpose website for both distributors and vendors with pricing to match login.</li>\r\n    <li>The system handles ordering, checkout and shipping tracking. Stock control is maintained on invoice and stock levels are automatically adjusted</li>\r\n</ul>", "Savitar RC", null },
                    { 25, 1, "<ul>\r\n    <li>Winforms application to assist in the manufacturing of plastic materials at Roto-Plastics.</li>\r\n    <li>Enables end users to create recipes based on plastics, colours, dy, material and design.</li>\r\n</ul>", "Roto-Platics", null },
                    { 24, 1, "Application for importing and analysing data fed into the system via XML files, to assist them in determining the structural integrity of the panel's worked in by the miners in the mine. NDA prevents further information.", "Rockwatch.NET", null },
                    { 23, 1, "Web application to handle product information and warranty returns for the RoadAngle GPS product.", "RoadAngle", null },
                    { 22, 1, "Converted the PSCBC web application from .NET 1.1 to .NET 3.5, updated SQL Server, and migrated data.", "PSCBC", null },
                    { 30, 1, "eCommerce web application for advertising, leasing and selling movies and video games.", "Videotown", null },
                    { 38, 3, "Accuchip is an RFid tracking solution for material cars and general rolling stock. This is an RFid solution that can be applied to various rolling stock items and high value equipment to provide proximity detection and location reporting.", "Accuchip", "https://www.accutrak.co.za/our-products-2/accuchip/" }
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
                name: "IX_Clients_Name",
                table: "Clients",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_DevelopmentTechnologies_DevelopmentTechnologyCategoryId",
                table: "DevelopmentTechnologies",
                column: "DevelopmentTechnologyCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DevelopmentTechnologies_Name",
                table: "DevelopmentTechnologies",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_DevelopmentTechnologyCategories_Name",
                table: "DevelopmentTechnologyCategories",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_DevelopmentTechnologyProject_ProjectsId",
                table: "DevelopmentTechnologyProject",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_Name",
                table: "Projects",
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
                name: "DevelopmentTechnologyProject");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DevelopmentTechnologies");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "DevelopmentTechnologyCategories");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
