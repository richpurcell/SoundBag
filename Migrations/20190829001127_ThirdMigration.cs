using Microsoft.EntityFrameworkCore.Migrations;

namespace SoundBag.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "festivals",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "TicketLink",
                table: "festivals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TicketLink",
                table: "festivals");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "festivals",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
