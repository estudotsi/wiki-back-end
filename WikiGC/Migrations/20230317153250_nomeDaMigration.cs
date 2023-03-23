using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WikiGC.Migrations
{
    public partial class nomeDaMigration : Migration
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
                    UrlProducao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServidorProducao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersaoWordpressProducao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlHomologacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServidorHomologacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersaoWordpressHomologacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsavel = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
