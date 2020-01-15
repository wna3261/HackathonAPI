using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hackathon_API.Migrations
{
    public partial class ConcursoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Candidatos",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ConcursoId",
                table: "Candidatos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Concursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    NumeroVagas = table.Column<int>(nullable: false),
                    DataConcurso = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concursos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_ConcursoId",
                table: "Candidatos",
                column: "ConcursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidatos_Concursos_ConcursoId",
                table: "Candidatos",
                column: "ConcursoId",
                principalTable: "Concursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidatos_Concursos_ConcursoId",
                table: "Candidatos");

            migrationBuilder.DropTable(
                name: "Concursos");

            migrationBuilder.DropIndex(
                name: "IX_Candidatos_ConcursoId",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConcursoId",
                table: "Candidatos");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Candidatos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);
        }
    }
}
