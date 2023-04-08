using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class url : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 13,
                column: "Imagen",
                value: "http://drive.google.com/uc?export=view&id=1KwW_hTxoX1OCaowkrUa4zlWiGwyJONkG");

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 14,
                column: "Imagen",
                value: "http://drive.google.com/uc?export=view&id=1tjBKJ7w5JIhhw3C3Fi5ZxLu798SSdbIL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 13,
                column: "Imagen",
                value: "url");

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 14,
                column: "Imagen",
                value: "url");
        }
    }
}
