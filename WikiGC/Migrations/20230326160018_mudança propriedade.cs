using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WikiGC.Migrations
{
    public partial class mudançapropriedade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Atualizado",
                table: "Portais",
                newName: "update");

            migrationBuilder.RenameColumn(
                name: "Ativo",
                table: "Portais",
                newName: "status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "update",
                table: "Portais",
                newName: "Atualizado");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Portais",
                newName: "Ativo");
        }
    }
}
