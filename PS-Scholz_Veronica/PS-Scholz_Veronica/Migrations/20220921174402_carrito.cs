using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PS_Scholz_Veronica.Migrations
{
    public partial class carrito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrito_Cliente_ClienteId",
                table: "Carrito");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrito_Cliente_ClienteId",
                table: "Carrito",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrito_Cliente_ClienteId",
                table: "Carrito");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrito_Cliente_ClienteId",
                table: "Carrito",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId");
        }
    }
}
