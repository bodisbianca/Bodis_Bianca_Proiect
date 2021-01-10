using Microsoft.EntityFrameworkCore.Migrations;

namespace Bodis_Bianca_Proiect.Migrations
{
    public partial class Foster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FosterID",
                table: "Animal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Foster",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FosterName = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Vechime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foster", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_FosterID",
                table: "Animal",
                column: "FosterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Foster_FosterID",
                table: "Animal",
                column: "FosterID",
                principalTable: "Foster",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Foster_FosterID",
                table: "Animal");

            migrationBuilder.DropTable(
                name: "Foster");

            migrationBuilder.DropIndex(
                name: "IX_Animal_FosterID",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "FosterID",
                table: "Animal");
        }
    }
}
