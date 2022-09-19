using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Argon.Migrations
{
    public partial class Cep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Empresas");
        }
    }
}
