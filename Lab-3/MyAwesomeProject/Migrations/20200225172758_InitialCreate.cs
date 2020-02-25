using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAwesomeProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    AddressIdentifier = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Building_Number = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Post_Code = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.AddressIdentifier);
                });

            migrationBuilder.CreateTable(
                name: "people",
                columns: table => new
                {
                    PersonID = table.Column<string>(nullable: false),
                    First_Name = table.Column<string>(nullable: true),
                    Middle_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Date_of_Birth = table.Column<DateTime>(nullable: false),
                    AddressIdentifier = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_people", x => x.PersonID);
                    table.ForeignKey(
                        name: "FK_people_addresses_AddressIdentifier",
                        column: x => x.AddressIdentifier,
                        principalTable: "addresses",
                        principalColumn: "AddressIdentifier",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_people_AddressIdentifier",
                table: "people",
                column: "AddressIdentifier");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "people");

            migrationBuilder.DropTable(
                name: "addresses");
        }
    }
}
