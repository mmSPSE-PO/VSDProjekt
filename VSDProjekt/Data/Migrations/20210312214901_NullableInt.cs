using Microsoft.EntityFrameworkCore.Migrations;

namespace VSDProjekt.Data.Migrations
{
    public partial class NullableInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_zasuvka_zariadenie_zariadenieID",
                table: "zasuvka");

            migrationBuilder.AlterColumn<int>(
                name: "zariadenieID",
                table: "zasuvka",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_zasuvka_zariadenie_zariadenieID",
                table: "zasuvka",
                column: "zariadenieID",
                principalTable: "zariadenie",
                principalColumn: "zariadenieID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_zasuvka_zariadenie_zariadenieID",
                table: "zasuvka");

            migrationBuilder.AlterColumn<int>(
                name: "zariadenieID",
                table: "zasuvka",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_zasuvka_zariadenie_zariadenieID",
                table: "zasuvka",
                column: "zariadenieID",
                principalTable: "zariadenie",
                principalColumn: "zariadenieID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
