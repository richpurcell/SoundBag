using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoundBag.Migrations
{
    public partial class SixthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "quotes");

            migrationBuilder.CreateTable(
                name: "Association2",
                columns: table => new
                {
                    Association2Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    FestivalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Association2", x => x.Association2Id);
                    table.ForeignKey(
                        name: "FK_Association2_festivals_FestivalId",
                        column: x => x.FestivalId,
                        principalTable: "festivals",
                        principalColumn: "FestivalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Association2_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    PostContent = table.Column<string>(nullable: true),
                    FestivalId = table.Column<int>(nullable: false),
                    created_at = table.Column<string>(nullable: true),
                    updated_at = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Association2_FestivalId",
                table: "Association2",
                column: "FestivalId");

            migrationBuilder.CreateIndex(
                name: "IX_Association2_UserId",
                table: "Association2",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Association2");

            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.CreateTable(
                name: "quotes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    created_at = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    quote = table.Column<string>(nullable: true),
                    updated_at = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quotes", x => x.id);
                });
        }
    }
}
