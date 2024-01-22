using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estacionamento.Migrations
{
    public partial class AdicionaTabelaVeiculos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecoInicial = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecoHora = table.Column<string>(type: "decimal(18,2)", nullable: false),
                    Cor = table.Column<string>(nullable: false),
                    Marca = table.Column<string>(nullable: false),
                    Proprietario = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
