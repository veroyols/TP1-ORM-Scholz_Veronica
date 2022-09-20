using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PS_Scholz_Veronica.Migrations
{
    public partial class product1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "ProductoId", "Codigo", "Descripcion", "Image", "Marca", "Nombre", "Precio" },
                values: new object[] { 1, "ps2c2022-01", "Remeras lisas de colores", "https://drive.google.com/file/d/1_B3cfaKCT0ASUHJ_--YVpxc1gd6QQ_oL/view?usp=sharing", "Simpl", "Remera", 1000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "ProductoId",
                keyValue: 1);
        }
    }
}
