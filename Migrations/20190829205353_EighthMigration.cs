using Microsoft.EntityFrameworkCore.Migrations;

namespace SoundBag.Migrations
{
    public partial class EighthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Association2_festivals_FestivalId",
                table: "Association2");

            migrationBuilder.DropForeignKey(
                name: "FK_Association2_users_UserId",
                table: "Association2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Association2",
                table: "Association2");

            migrationBuilder.RenameTable(
                name: "Association2",
                newName: "association2");

            migrationBuilder.RenameIndex(
                name: "IX_Association2_UserId",
                table: "association2",
                newName: "IX_association2_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Association2_FestivalId",
                table: "association2",
                newName: "IX_association2_FestivalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_association2",
                table: "association2",
                column: "Association2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_association2_festivals_FestivalId",
                table: "association2",
                column: "FestivalId",
                principalTable: "festivals",
                principalColumn: "FestivalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_association2_users_UserId",
                table: "association2",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_association2_festivals_FestivalId",
                table: "association2");

            migrationBuilder.DropForeignKey(
                name: "FK_association2_users_UserId",
                table: "association2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_association2",
                table: "association2");

            migrationBuilder.RenameTable(
                name: "association2",
                newName: "Association2");

            migrationBuilder.RenameIndex(
                name: "IX_association2_UserId",
                table: "Association2",
                newName: "IX_Association2_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_association2_FestivalId",
                table: "Association2",
                newName: "IX_Association2_FestivalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Association2",
                table: "Association2",
                column: "Association2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Association2_festivals_FestivalId",
                table: "Association2",
                column: "FestivalId",
                principalTable: "festivals",
                principalColumn: "FestivalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Association2_users_UserId",
                table: "Association2",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
