using Microsoft.EntityFrameworkCore.Migrations;

namespace Bodis_Bianca_Proiect.Migrations
{
    public partial class TraitDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TraitDetails",
                table: "Trait",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TraitDetails",
                table: "Trait");
        }
    }
}
