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
    public class QueryCart : IQueryCart //consulta
    {
        private readonly AppDbContext _context;

        public QueryCart(AppDbContext context)
        {
            _context = context;
        }

        public Guid GetUUIdbyCart(Carrito cart)
        {
            return cart.CarritoId;
        }
    }
}
