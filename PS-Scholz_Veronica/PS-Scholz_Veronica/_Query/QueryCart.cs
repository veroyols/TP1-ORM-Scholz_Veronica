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
    public class QueryCart : IQueryCart //consulta
    {
        private readonly AppDbContext _context;

        public QueryCart(AppDbContext context)
        {
            _context = context;
        }
        public Guid GetGuidbyCart(Carrito cart)
        {
            return cart.CarritoId;
        }
        public bool ExistsCartByClientId(int clientId)
        {
            var cart = _context.CarritoDb.Include(c => c.Cliente).First(x => x.ClienteId == clientId);
            return _context.CarritoDb.Contains(cart); ;
        }
        public bool State(Carrito cart)
        {
            return cart.Estado;
        }
        public Carrito GetCartbyClientId(int clientId)
        {
            //            var cart = _context.CarritoDb.Include(c => c.Cliente).First(x => x.ClienteId == clientId && x.Estado=true);
            var cart = _context.CarritoDb.Include(c => c.Cliente).First(x => x.ClienteId == clientId && x.Estado == true);
            return cart;
        }
    }
}
