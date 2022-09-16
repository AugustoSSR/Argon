using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Argon.Migrations
{
    public partial class ArgoSystem2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "dataAlteracao",
                table: "Projetos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "dataCadastro",
                table: "Projetos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dataAlteracao",
                table: "Projetos");

            migrationBuilder.DropColumn(
                name: "dataCadastro",
                table: "Projetos");
        }
    }
}
