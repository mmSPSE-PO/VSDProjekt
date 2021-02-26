using Microsoft.EntityFrameworkCore.Migrations;

namespace VSDProjekt.Data.Migrations
{
    public partial class Zasuvky : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "zasuvka",
                columns: table => new
                {
                    zasuvkaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    zariadenieID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zasuvka", x => x.zasuvkaID);
                    table.ForeignKey(
                        name: "FK_zasuvka_zariadenie_zariadenieID",
                        column: x => x.zariadenieID,
                        principalTable: "zariadenie",
                        principalColumn: "zariadenieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_zasuvka_zariadenieID",
                table: "zasuvka",
                column: "zariadenieID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "zasuvka");
        }
    }
}
