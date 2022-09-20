using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PS_Scholz_Veronica.Migrations
{
    public partial class products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 1,
                columns: new[] { "Descripcion", "Image", "Precio" },
                values: new object[] { "Remera de algodon lisa, varios colores.", "https://drive.google.com/file/d/1AWEbI7NFytjQr0PcRNfqGjlWLDcW1BDr/view?usp=sharing", 3000m });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "ProductoId", "Codigo", "Descripcion", "Image", "Marca", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 2, "ps2c2022-02", "Buzo de friza liso, varios colores.", "https://drive.google.com/file/d/136zDTZUkUbs5Z4eoumK-Gm5J-Ex7aN2y/view?usp=sharing", "Simpl", "Buzo", 4000m },
                    { 3, "ps2c2022-03", "Canguro de friza liso, varios colores.", "https://drive.google.com/file/d/1OoBv1FyptSBujAqBvTV61F3zkm6GLeb6/view?usp=sharing", "Simpl", "Buzo Canguro", 4500m },
                    { 4, "ps2c2022-04", "Campera de frisa lisa, varios colores.", "https://drive.google.com/file/d/1zomCjyxcP1uyJxRonUVcAtDKC-y8LHmD/view?usp=sharing", "Simpl", "Campera", 5000m },
                    { 5, "ps2c2022-05", "Musculosa de algodon lisa, varios colores.", "https://drive.google.com/file/d/1DGa8_Ows-LfNxczRkvcBrQwX5lsh89_n/view?usp=sharing", "Simpl", "Musculosa", 2700m },
                    { 6, "ps2c2022-06", "Pantalon jogging de friza.", "https://drive.google.com/file/d/12P_zAj696O3cYBeWToXWM93nQEgIFlW0/view?usp=sharing", "Simpl", "Pantalon Jogging", 4700m },
                    { 7, "ps2c2022-07", "Campera de jean corta.", "https://drive.google.com/file/d/11-i6M5B8fZySpeS2XjaaEioi3Puq2DCS/view?usp=sharing", "Simpl", "Campera Jean", 4900m },
                    { 8, "ps2c2022-08", "Pantalon de jean claro.", "https://drive.google.com/file/d/1Vo-6YDNc4hoce7NkVrYVe3YQrf97QnG3/view?usp=sharing", "Simpl", "Pantalon Jean", 6300m },
                    { 9, "ps2c2022-09", "Sweater Bremer Negro.", "https://drive.google.com/file/d/16kEM1AO29k__3ayUe8zbe2DqodGbUzZ_/view?usp=sharing", "Simpl", "Sweater Bremer Negro", 5100m },
                    { 10, "ps2c2022-10", "Camiseta algodon, varios colores.", "https://drive.google.com/file/d/1udHiMsJF53vY67yJYEh9TRHon7e0w8vC/view?usp=sharing", "Simpl", "Camiseta", 5200m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 1,
                columns: new[] { "Descripcion", "Image", "Precio" },
                values: new object[] { "Remeras lisas de colores", "https://drive.google.com/file/d/1_B3cfaKCT0ASUHJ_--YVpxc1gd6QQ_oL/view?usp=sharing", 1000m });
        }
    }
}
