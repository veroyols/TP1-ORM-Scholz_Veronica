using Microsoft.EntityFrameworkCore;
using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Persistence;

namespace PS_Scholz_Veronica._Query
{
    public class QueryCart : IQueryCart
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

        public int GetClientIdbyCarritoId(Guid cartId)
        {
            var cart = _context.CarritoDb.First(x => x.CarritoId == cartId);
            return cart.ClienteId;
        }
    }
}
