using Microsoft.EntityFrameworkCore.Migrations;

namespace RailwaySystem.API.Migrations
{
    public partial class Class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fare",
                table: "bookings",
                newName: "fare");

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "passenger",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "passenger");

            migrationBuilder.RenameColumn(
                name: "fare",
                table: "bookings",
                newName: "Fare");
        }
    }
}
