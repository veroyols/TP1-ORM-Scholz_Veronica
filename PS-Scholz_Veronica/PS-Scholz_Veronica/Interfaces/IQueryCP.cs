using PS_Scholz_Veronica.Entities;

namespace PS_Scholz_Veronica.Interfaces
{
    public interface IQueryCP
    {
        public bool Exists(CarritoProducto cp);
        public List<Producto> GetProductoByCarrito(Guid carritoId);
        public int[] GetCdadProductoByCarrito(Guid carritoId);
        public List<CarritoProducto> GetCPByProductId(int productId);
    }
}
