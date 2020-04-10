using Microsoft.EntityFrameworkCore.Migrations;

namespace HappyVillageProject.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formats",
                columns: table => new
                {
                    FormatsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formats", x => x.FormatsId);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    OwnersId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.OwnersId);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImagesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Img = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FormatsId = table.Column<int>(nullable: false),
                    OwnersId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImagesId);
                    table.ForeignKey(
                        name: "FK_Images_Formats_FormatsId",
                        column: x => x.FormatsId,
                        principalTable: "Formats",
                        principalColumn: "FormatsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Images_Owners_OwnersId",
                        column: x => x.OwnersId,
                        principalTable: "Owners",
                        principalColumn: "OwnersId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_FormatsId",
                table: "Images",
                column: "FormatsId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_OwnersId",
                table: "Images",
                column: "OwnersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Formats");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
