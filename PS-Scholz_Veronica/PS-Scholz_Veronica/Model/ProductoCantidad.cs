using PS_Scholz_Veronica.Entities;

namespace PS_Scholz_Veronica.Model
{
    public class ProductoCantidad
    {
        public Producto producto { get; set; }
        public int cantidad { get; set; }
        public ProductoCantidad(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }
    }
}
