using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WikiGC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Portais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlProducao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServidorProducao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VersaoWordpressProducao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlHomologacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServidorHomologacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VersaoWordpressHomologacao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Responsavel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portais", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Portais");
        }
    }
}
