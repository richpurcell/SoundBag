using Microsoft.EntityFrameworkCore.Migrations;

namespace SoundBag.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "festivals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "festivals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "festivals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "festivals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "festivals");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "festivals");

            migrationBuilder.DropColumn(
                name: "State",
                table: "festivals");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "festivals");
        }
    }
}
