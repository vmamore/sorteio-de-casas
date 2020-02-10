using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Familias",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FamiliaId = table.Column<Guid>(nullable: true),
                    Nome = table.Column<string>(nullable: false),
                    DataDeNascimento = table.Column<DateTime>(nullable: false),
                    Renda = table.Column<decimal>(nullable: true),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoas_Familias_FamiliaId",
                        column: x => x.FamiliaId,
                        principalTable: "Familias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResultadosDaAvaliacaoDosCriterios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FamiliaId = table.Column<Guid>(nullable: true),
                    PontuacaoTotal = table.Column<int>(nullable: false),
                    DataDeSelecao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultadosDaAvaliacaoDosCriterios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultadosDaAvaliacaoDosCriterios_Familias_FamiliaId",
                        column: x => x.FamiliaId,
                        principalTable: "Familias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pessoas_FamiliaId",
                table: "Pessoas",
                column: "FamiliaId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultadosDaAvaliacaoDosCriterios_FamiliaId",
                table: "ResultadosDaAvaliacaoDosCriterios",
                column: "FamiliaId",
                unique: true,
                filter: "[FamiliaId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "ResultadosDaAvaliacaoDosCriterios");

            migrationBuilder.DropTable(
                name: "Familias");
        }
    }
}
