using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class CriadoTabelaStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(maxLength: 150, nullable: false),
                    CadastroValido = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "CadastroValido", "Descricao" },
                values: new object[] { 1, true, "Cadastro válido" });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 2, "Já possui uma casa" },
                    { 3, "Selecionado em outro processo de seleção" },
                    { 4, "Cadastro incompleto" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
