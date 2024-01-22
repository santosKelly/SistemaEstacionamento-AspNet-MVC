using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estacionamento.Migrations
{
    public partial class RecriandoMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "proprietário",
                table: "Veiculos",
                newName: "Proprietario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Proprietario",
                table: "Veiculos",
                newName: "proprietário");
        }
    }
}
