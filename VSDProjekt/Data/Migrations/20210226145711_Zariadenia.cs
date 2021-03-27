using Microsoft.EntityFrameworkCore.Migrations;

namespace VSDProjekt.Data.Migrations
{
    public partial class Zariadenia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "zariadenie",
                columns: table => new
                {
                    zariadenieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Spotreba = table.Column<double>(type: "float", nullable: false),
                    Dlzka = table.Column<double>(type: "float", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zariadenie", x => x.zariadenieID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "zariadenie");
        }
    }
}
