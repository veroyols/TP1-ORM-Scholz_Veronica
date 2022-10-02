
using Microsoft.EntityFrameworkCore;
using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Model;
using PS_Scholz_Veronica.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void Print(CarritoProducto cp)
        {
            Console.WriteLine("{0} {1} {2}", cp.CarritoId.ToString(), cp.ProductoId, cp.Cantidad);
        }
        public List<CarritoProducto> GetAll()
        {
            var p = _context.CarritoProductoDb.ToList<CarritoProducto>();
            return p;
        }
        public HashSet<Guid> GetAllGuid()
        {
            return _context.CarritoProductoDb.Select(x => x.CarritoId).ToHashSet();
        }

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
    }
}
