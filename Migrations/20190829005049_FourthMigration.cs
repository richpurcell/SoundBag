using Microsoft.EntityFrameworkCore.Migrations;

namespace SoundBag.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LineupLink",
                table: "festivals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LineupLink",
                table: "festivals");
        }
    }
}
