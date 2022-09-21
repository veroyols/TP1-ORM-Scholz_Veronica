using Microsoft.EntityFrameworkCore;
using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica._Query
{
    public class QueryProduct : IQueryProduct
    {
        private readonly AppDbContext _context;

        public QueryProduct(AppDbContext context)
        {
            _context = context;
        }

        public Producto GeProductbyId(int id)
        {
            var p = _context.ProductoDb.FirstOrDefault<Producto>(p => p.ProductoId == id);
            return p;
        }

        public int CountAll()
        {
            return _context.ProductoDb.Count();
        }

        public List<Producto> GetAll()
        {
            var p = _context.ProductoDb.ToList<Producto>();
            return p;
        }
    }
}
