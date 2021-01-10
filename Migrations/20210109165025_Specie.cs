using Microsoft.EntityFrameworkCore.Migrations;

namespace Bodis_Bianca_Proiect.Migrations
{
    public partial class Specie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpecieID",
                table: "Animal",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Specie",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecieName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specie", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_SpecieID",
                table: "Animal",
                column: "SpecieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Specie_SpecieID",
                table: "Animal",
                column: "SpecieID",
                principalTable: "Specie",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Specie_SpecieID",
                table: "Animal");

            migrationBuilder.DropTable(
                name: "Specie");

            migrationBuilder.DropIndex(
                name: "IX_Animal_SpecieID",
                table: "Animal");

            migrationBuilder.DropColumn(
                name: "SpecieID",
                table: "Animal");
        }
    }
}
