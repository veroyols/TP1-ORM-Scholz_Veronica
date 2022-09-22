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
    public class QueryOrder : IQueryOrder
    {
        private readonly AppDbContext _context;

        public QueryOrder(AppDbContext context)
        {
            _context = context;
        }

        public void GetProductsByCartId(Guid cartid)
        {
            var list = _context.OrdenDb.Include(c => c.Carrito).First(c=> c.CarritoId == cartid);

            var a = _context.CarritoDb.Include(x => x.Cliente).ToList();
            return;
            //All<Carrito>(x => x.ClienteId == clientId)
        }
        public Orden GetOrderbyId(Guid id)
        {
            var o = _context.OrdenDb.First<Orden>(or => or.OrdenId == id);
            return o;
        }
        public void Print(Orden o)
        {
            Console.WriteLine("Orden de compra: {0} " +
                "\nCarrito: {1}" +
                "\nMonto: ${3} ({2})", o.OrdenId, o.CarritoId, o.Fecha, o.Total);
        }
    }
}
