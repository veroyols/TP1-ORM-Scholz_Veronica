using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Persistence;

namespace PS_Scholz_Veronica._Query
{
    public class QueryProduct : IQueryProduct
    {
        private readonly AppDbContext _context;

        public QueryProduct(AppDbContext context)
        {
            _context = context;
        }
        
        public Producto GetProductbyId(int id)
        {
            var p = _context.ProductoDb.FirstOrDefault<Producto>(p => p.ProductoId == id);
            return p;
        }
        
        public decimal GetPreciobyId(int id)
        {
            var p = _context.ProductoDb.FirstOrDefault<Producto>(p => p.ProductoId == id);
            return p.Precio;
        }
               
        public List<Producto> GetAll()
        {
            var p = _context.ProductoDb.ToList<Producto>();
            return p;
        }

        public bool Exists(int productoId)
        {
            return _context.ProductoDb.Any(p => p.ProductoId == productoId);
        }
    }
}
