using Microsoft.EntityFrameworkCore.Migrations;

namespace Bodis_Bianca_Proiect.Migrations
{
    public partial class DetaliiFoster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DetaliiFoster",
                table: "Foster",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetaliiFoster",
                table: "Foster");
        }
    }
}
