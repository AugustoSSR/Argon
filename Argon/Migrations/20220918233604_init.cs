using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Argon.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Usuarios",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Tipo",
                table: "Projetos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Empresa",
                table: "Projetos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ART",
                table: "Projetos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Concessionaria",
                table: "Projetos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Engenheiros",
                table: "Projetos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "Projetos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Protocolo",
                table: "Projetos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Situacao",
                table: "Projetos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNPJ = table.Column<int>(type: "int", nullable: false),
                    NomeFantasia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Razao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dataCadastro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    dataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropColumn(
                name: "ART",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "Concessionaria",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "Engenheiros",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "Protocolo",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "Projetos");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Projetos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Empresa",
                table: "Projetos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
