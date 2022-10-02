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
        public void Print(Orden orden)
        {
            Console.WriteLine(" ------------------------------------------------------");
            Console.WriteLine("| Orden de compra: {0} | \n| Monto: ${1} ({2})", orden.OrdenId, orden.Total, orden.Fecha);
            Console.WriteLine(" ------------------------------------------------------");
        }
        public List<Orden> GetAll()
        {
            var l = _context.OrdenDb.ToList();
            return l;
        }
        public List<Guid> GetAllGuid()
        {
            return _context.OrdenDb.Select(x => x.OrdenId).ToList();
        }

        public List<Orden> GetToday() //ordenes del dia
        {
            var c = DateTime.Now.Date;
            var l = _context.OrdenDb
                .Where(x => x.Fecha.Date.CompareTo(c) == 0)
                .ToList();
            return l;
        }
        //public InfoOrden Datos(Orden orden)
        //{
        //    var c = orden.CarritoId;
        //    var i = _context.OrdenDb
        //        .Include(o => o.Carrito)
        //        .Include(x => x.Carrito.CarritoProducto)
        //        .ThenInclude(c => c.Producto)
        //        .Where(o => o.CarritoId == orden.CarritoId)
        //        .Select(x => new InfoOrden
        //        {
        //            Fecha = orden.Fecha,
        //            Nombre = x.Carrito.Cliente.Nombre,
        //            Apellido = x.Carrito.Cliente.Apellido,
        //            Total = orden.Total,
        //        });
        //    return (InfoOrden)i;
        //}
    }
}
