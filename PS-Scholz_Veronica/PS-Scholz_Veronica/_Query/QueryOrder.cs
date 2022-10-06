using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Persistence;

namespace PS_Scholz_Veronica._Query
{
    public class QueryOrder : IQueryOrder
    {
        private readonly AppDbContext _context;

        public QueryOrder(AppDbContext context)
        {
            _context = context;
        }

        public Orden GetOrderbyId(Guid id)
        {
            var o = _context.OrdenDb.First<Orden>(or => or.OrdenId == id);
            return o;
        }

        //public List<Orden> GetAll()
        //{
        //    var l = _context.OrdenDb.ToList();
        //    return l;
        //}

        //public List<Guid> GetAllGuid()
        //{
        //    return _context.OrdenDb.Select(x => x.OrdenId).ToList();
        //}

        public List<Orden> GetToday()
        {
            var c = DateTime.Now.Date;
            var l = _context.OrdenDb
                .Where(x => x.Fecha.Date.CompareTo(c) == 0)
                .ToList();
            return l;
        }

        public DateTime GetDateByCartId(Guid cartId)
        {
            var order = _context.OrdenDb.FirstOrDefault(x => x.CarritoId == cartId);
            return order.Fecha;
        }
    }
}
