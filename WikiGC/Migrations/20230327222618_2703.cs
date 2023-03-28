using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WikiGC.Migrations
{
    public partial class _2703 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "status",
                table: "Portais",
                newName: "Status");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Portais",
                newName: "status");
        }
    }
}
