using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.cqrs_Query
{
    public class QueryMercaderia : IQueryMercaderia
    {
        private readonly AppDbContext _context;

        public QueryMercaderia()
        {
            _context = new AppDbContext();
        }

        public List<Mercaderia> GetListMercaderia()
        {
            var list = _context.MercaderiaDb.ToList<Mercaderia>();
            return list;
        }
    }
}
