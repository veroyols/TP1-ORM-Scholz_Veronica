using Microsoft.EntityFrameworkCore;
using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Persistence;

namespace PS_Scholz_Veronica._Query
{
    public class QueryCP : IQueryCP
    {
        private readonly AppDbContext _context;
        public QueryCP(AppDbContext context)
        {
            _context = context;
        }

        public bool Exists(CarritoProducto cp)
        {
            return _context.CarritoProductoDb.Contains(cp);
        }

        //public HashSet<Guid> GetAllGuid()
        //{
        //    return _context.CarritoProductoDb.Select(x => x.CarritoId).ToHashSet();
        //}

        public List<Producto> GetProductoByCarrito(Guid carritoId)
        {
            return _context.CarritoProductoDb
                .Where(x => x.CarritoId == carritoId)
                .Select(x => x.Producto)
                .ToList();
        }

        public int[] GetCdadProductoByCarrito(Guid carritoId)
        {
            return _context.CarritoProductoDb
                .Where(x => x.CarritoId == carritoId)
                .Select(x => x.Cantidad)
                .ToArray();
        }

        public List<CarritoProducto> GetCPByProductId(int productId)
        {
            var q =
                from cp in _context.CarritoProductoDb
                where cp.ProductoId == productId
                where cp.Carrito.Estado == false
                select cp;
            return q.ToList();

        }
    }
}
