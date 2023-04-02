using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class nombresMercaderia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormaEntrega",
                columns: table => new
                {
                    FormaEntregaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaEntrega", x => x.FormaEntregaId);
                });

            migrationBuilder.CreateTable(
                name: "TipoMercaderia",
                columns: table => new
                {
                    TipoMercaderiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoMercaderia", x => x.TipoMercaderiaId);
                });

            migrationBuilder.CreateTable(
                name: "Comanda",
                columns: table => new
                {
                    ComandaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormaEntregaId = table.Column<int>(type: "int", nullable: false),
                    PrecioTotal = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comanda", x => x.ComandaId);
                    table.ForeignKey(
                        name: "FK_Comanda_FormaEntrega_FormaEntregaId",
                        column: x => x.FormaEntregaId,
                        principalTable: "FormaEntrega",
                        principalColumn: "FormaEntregaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mercaderia",
                columns: table => new
                {
                    MercaderiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoMercaderiaId = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    Ingredientes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Preparacion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Imagen = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercaderia", x => x.MercaderiaId);
                    table.ForeignKey(
                        name: "FK_Mercaderia_TipoMercaderia_TipoMercaderiaId",
                        column: x => x.TipoMercaderiaId,
                        principalTable: "TipoMercaderia",
                        principalColumn: "TipoMercaderiaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComandaMercaderia",
                columns: table => new
                {
                    ComandaMercaderiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MercaderiaId = table.Column<int>(type: "int", nullable: false),
                    ComandaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComandaMercaderia", x => x.ComandaMercaderiaId);
                    table.ForeignKey(
                        name: "FK_ComandaMercaderia_Comanda_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "Comanda",
                        principalColumn: "ComandaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComandaMercaderia_Mercaderia_MercaderiaId",
                        column: x => x.MercaderiaId,
                        principalTable: "Mercaderia",
                        principalColumn: "MercaderiaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FormaEntrega",
                columns: new[] { "FormaEntregaId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Salon" },
                    { 2, "Delivery" },
                    { 3, "Pedidos Ya" }
                });

            migrationBuilder.InsertData(
                table: "TipoMercaderia",
                columns: new[] { "TipoMercaderiaId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Entrada" },
                    { 2, "Minutas" },
                    { 3, "Pastas" },
                    { 4, "Parrilla" },
                    { 5, "Pizzas" },
                    { 6, "Sandwich" },
                    { 7, "Ensaladas" },
                    { 8, "Bebidas" },
                    { 9, "Cerveza Artesanal" },
                    { 10, "Postres" }
                });

            migrationBuilder.InsertData(
                table: "Mercaderia",
                columns: new[] { "MercaderiaId", "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion", "TipoMercaderiaId" },
                values: new object[,]
                {
                    { 1, "url", "Berenjenas en Escabeche (ingredientes)", "Berenjenas en Escabeche", 100, "Berenjenas en Escabeche (preparacion)", 1 },
                    { 2, "url", "Porotos en Escabeche (ingredientes)", "Porotos en Escabeche", 100, "Porotos en Escabeche (preparacion)", 1 },
                    { 3, "url", "Humus de Garbanzo (ingredientes)", "Humus de Garbanzo", 100, "Humus de Garbanzo (preparacion)", 1 },
                    { 4, "url", "Milanesa Napolitana (ingredientes)", "Milanesa Napolitana", 100, "Milanesa Napolitana (preparacion)", 2 },
                    { 5, "url", "Papas Fritas (ingredientes)", "Papas Fritas", 100, "Papas Fritas (preparacion)", 2 },
                    { 6, "url", "Empanada (ingredientes)", "Empanada", 100, "Empanada (preparacion)", 2 },
                    { 7, "url", "Omelette (ingredientes)", "Omelette", 100, "Omelette (preparacion)", 2 },
                    { 8, "url", "Tarta (ingredientes)", "Tarta", 100, "Tarta (preparacion)", 2 },
                    { 9, "url", "Fideos con salsa cuatro quesos (ingredientes)", "Fideos con salsa cuatro quesos", 100, "Fideos con salsa cuatro quesos (preparacion)", 3 },
                    { 10, "url", "Noquis con Salsa Bolognesa (ingredientes)", "Noquis con Salsa Bolognesa", 100, "Noquis con Salsa Bolognesa (preparacion)", 3 },
                    { 11, "url", "Sorrentinos con Salsa Filetto (ingredientes)", "Sorrentinos con Salsa Filetto", 100, "Sorrentinos con Salsa Filetto (preparacion)", 3 },
                    { 12, "url", "Provoleta (ingredientes)", "Provoleta", 100, "Provoleta (preparacion)", 4 },
                    { 13, "url", "Parrillada para 1 (ingredientes)", "Parrillada para 1", 100, "Parrillada para 1 (preparacion)", 4 },
                    { 14, "url", "Parrillada para 2 (ingredientes)", "Parrillada para 2", 100, "Parrillada para 2 (preparacion)", 4 },
                    { 15, "url", "Muzzarella (ingredientes)", "Muzzarella", 100, "Muzzarella (preparacion)", 5 },
                    { 16, "url", "Napolitana (ingredientes)", "Napolitana", 100, "Napolitana (preparacion)", 5 },
                    { 17, "url", "Roquefort (ingredientes)", "Roquefort", 100, "Roquefort (preparacion)", 5 },
                    { 18, "url", "Fugazetta Rellena (ingredientes)", "Fugazetta Rellena", 100, "Fugazetta Rellena (preparacion)", 5 },
                    { 19, "url", "Hamburguesa (ingredientes)", "Hamburguesa", 100, "Hamburguesa (preparacion)", 6 },
                    { 20, "url", "Pollo Cesar (ingredientes)", "Pollo Cesar", 100, "Pollo Cesar (preparacion)", 6 },
                    { 21, "url", "Lechuga y Cebolla (ingredientes)", "Lechuga y Cebolla", 100, "Lechuga y Cebolla (preparacion)", 7 },
                    { 22, "url", "Agua (ingredientes)", "Agua", 100, "Agua (preparacion)", 8 },
                    { 23, "url", "Agua con Gas (ingredientes)", "Agua con Gas", 100, "Agua con Gas (preparacion)", 8 },
                    { 24, "url", "CocaCola (ingredientes)", "CocaCola", 100, "CocaCola (preparacion)", 8 },
                    { 25, "url", "Agua Tonica (ingredientes)", "Agua Tonica", 100, "Agua Tonica (preparacion)", 8 },
                    { 26, "url", "Vino (ingredientes)", "Vino", 100, "Vino (preparacion)", 8 },
                    { 27, "url", "Blonde (ingredientes)", "Blonde", 100, "Blonde (preparacion)", 9 },
                    { 28, "url", "Honey (ingredientes)", "Honey", 100, "Honey (preparacion)", 9 },
                    { 29, "url", "IPA (ingredientes)", "IPA", 100, "IPA (preparacion)", 9 },
                    { 30, "url", "Budin de Pan (ingredientes)", "Budin de Pan", 100, "Budin de Pan (preparacion)", 10 },
                    { 31, "url", "Copa Helada (ingredientes)", "Copa Helada", 100, "Copa Helada (preparacion)", 10 },
                    { 32, "url", "Panqueques con Dulce de Leche (ingredientes)", "Panqueques con Dulce de Leche", 100, "Panqueques con Dulce de Leche (preparacion)", 10 },
                    { 33, "url", "Frutilla con Crema (ingredientes)", "Frutilla con Crema", 100, "Frutilla con Crema (preparacion)", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comanda_FormaEntregaId",
                table: "Comanda",
                column: "FormaEntregaId");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaMercaderia_ComandaId",
                table: "ComandaMercaderia",
                column: "ComandaId");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaMercaderia_MercaderiaId",
                table: "ComandaMercaderia",
                column: "MercaderiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mercaderia_TipoMercaderiaId",
                table: "Mercaderia",
                column: "TipoMercaderiaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComandaMercaderia");

            migrationBuilder.DropTable(
                name: "Comanda");

            migrationBuilder.DropTable(
                name: "Mercaderia");

            migrationBuilder.DropTable(
                name: "FormaEntrega");

            migrationBuilder.DropTable(
                name: "TipoMercaderia");
        }
    }
}
