using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PS_Scholz_Veronica.Migrations
{
    public partial class orden : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrito_Orden_CarritoId",
                table: "Carrito");

            migrationBuilder.DropForeignKey(
                name: "FK_CarritoProducto_Carrito_CarritoId",
                table: "CarritoProducto");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_CarritoId",
                table: "Orden",
                column: "CarritoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CarritoProducto_Carrito_CarritoId",
                table: "CarritoProducto",
                column: "CarritoId",
                principalTable: "Carrito",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orden_Carrito_CarritoId",
                table: "Orden",
                column: "CarritoId",
                principalTable: "Carrito",
                principalColumn: "CarritoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarritoProducto_Carrito_CarritoId",
                table: "CarritoProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_Orden_Carrito_CarritoId",
                table: "Orden");

            migrationBuilder.DropIndex(
                name: "IX_Orden_CarritoId",
                table: "Orden");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrito_Orden_CarritoId",
                table: "Carrito",
                column: "CarritoId",
                principalTable: "Orden",
                principalColumn: "OrdenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarritoProducto_Carrito_CarritoId",
                table: "CarritoProducto",
                column: "CarritoId",
                principalTable: "Carrito",
                principalColumn: "CarritoId");
        }
    }
}
