using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Argon.Migrations
{
    public partial class argonEngenheiros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Projetos");

            migrationBuilder.AddColumn<string>(
                name: "nomeCadastro",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nomeAlteracao",
                table: "Projetos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nomeCadastro",
                table: "Projetos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "dataCadastro",
                table: "Empresas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nomeCadastro",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Arquivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numeroCaderno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Empresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nomeCadastro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nomeAlteracao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arquivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Engenheiros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<int>(type: "int", nullable: false),
                    CREA = table.Column<int>(type: "int", nullable: false),
                    nomeAlteracao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nomeCadastro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dataVencimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engenheiros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arquivos");

            migrationBuilder.DropTable(
                name: "Engenheiros");

            migrationBuilder.DropColumn(
                name: "nomeCadastro",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "nomeAlteracao",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "nomeCadastro",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "nomeCadastro",
                table: "Empresas");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioID",
                table: "Projetos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "dataCadastro",
                table: "Empresas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
