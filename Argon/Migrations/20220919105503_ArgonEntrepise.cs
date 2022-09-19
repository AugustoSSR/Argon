using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Argon.Migrations
{
    public partial class ArgonEntrepise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Empresas");

            migrationBuilder.AddColumn<string>(
                name: "nomeAlteracao",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nomeAlteracao",
                table: "Empresas");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "Empresas",
                type: "int",
                nullable: true);
        }
    }
}
