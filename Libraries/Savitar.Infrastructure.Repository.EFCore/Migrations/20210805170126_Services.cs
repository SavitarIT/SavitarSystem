using Microsoft.EntityFrameworkCore.Migrations;

namespace Savitar.Infrastructure.Repository.EFCore.Migrations
{
    public partial class Services : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_Services_Title",
                table: "Services",
                column: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
