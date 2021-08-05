using Microsoft.EntityFrameworkCore.Migrations;

namespace Savitar.Infrastructure.Repository.EFCore.Migrations
{
    public partial class ProjectTechnologyCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Services",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTechnologyCategories_Name",
                table: "ProjectTechnologyCategories",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectTechnologyCategories");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Services",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);
        }
    }
}
