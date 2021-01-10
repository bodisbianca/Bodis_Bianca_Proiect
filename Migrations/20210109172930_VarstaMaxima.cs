using Microsoft.EntityFrameworkCore.Migrations;

namespace Bodis_Bianca_Proiect.Migrations
{
    public partial class VarstaMaxima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DifIntretinere",
                table: "Specie",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VarstaMaxima",
                table: "Specie",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DifIntretinere",
                table: "Specie");

            migrationBuilder.DropColumn(
                name: "VarstaMaxima",
                table: "Specie");
        }
    }
}
