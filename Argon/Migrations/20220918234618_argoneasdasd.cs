using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Argon.Migrations
{
    public partial class argoneasdasd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "Projetos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "Empresas",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Empresas");
        }
    }
}
