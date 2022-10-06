using PS_Scholz_Veronica.Entities;

namespace PS_Scholz_Veronica.Interfaces
{
    public interface IQueryProduct
    {
        public Producto GetProductbyId(int id);
        public List<Producto> GetAll();
        public decimal GetPreciobyId(int id);
        public bool Exists(int productoId);

    }
}
