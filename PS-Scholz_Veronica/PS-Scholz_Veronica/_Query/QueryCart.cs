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

        //public bool ExistsCartByClientId(int clientId)
        //{
        //    var cart = _context.CarritoDb.Include(c => c.Cliente).First(x => x.ClienteId == clientId);
        //    return _context.CarritoDb.Contains(cart); ;
        //}

        //public bool State(Carrito cart)
        //{
        //    return cart.Estado;
        //}

        //public Carrito GetCartbyClientId(int clientId)
        //{
        //    var cart = _context.CarritoDb.Include(c => c.Cliente).First(x => x.ClienteId == clientId && x.Estado);
        //    return cart;
        //}

        public int GetClientIdbyCarritoId(Guid cartId)
        {
            var cart = _context.CarritoDb.First(x => x.CarritoId == cartId);
            return cart.ClienteId;
        }
    }
}
