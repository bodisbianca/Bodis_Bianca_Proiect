using Microsoft.EntityFrameworkCore.Migrations;

namespace Bodis_Bianca_Proiect.Migrations
{
    public partial class AnimalTrait : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trait",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraitName = table.Column<string>(nullable: true),
                    Avantaje = table.Column<string>(nullable: true),
                    Dezavantaje = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trait", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AnimalTrait",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalID = table.Column<int>(nullable: false),
                    SpecieID = table.Column<int>(nullable: false),
                    TraitID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalTrait", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AnimalTrait_Animal_AnimalID",
                        column: x => x.AnimalID,
                        principalTable: "Animal",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalTrait_Trait_TraitID",
                        column: x => x.TraitID,
                        principalTable: "Trait",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalTrait_AnimalID",
                table: "AnimalTrait",
                column: "AnimalID");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalTrait_TraitID",
                table: "AnimalTrait",
                column: "TraitID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalTrait");

            migrationBuilder.DropTable(
                name: "Trait");
        }
    }
}
