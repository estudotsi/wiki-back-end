using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WikiGC.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "update",
                table: "Portais");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "update",
                table: "Portais",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
