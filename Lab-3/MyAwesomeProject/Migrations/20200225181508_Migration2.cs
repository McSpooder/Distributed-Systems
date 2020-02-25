using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAwesomeProject.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Middle_Name",
                newName: "Middle_Names",
                table: "people");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Middle_Names",
                newName: "Middle_Name",
                table: "people");
        }
    }
}
