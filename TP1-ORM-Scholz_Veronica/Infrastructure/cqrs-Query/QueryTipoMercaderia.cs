using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.cqrs_Query
{
    public class QueryTipoMercaderia : IQueryTipoMercaderia
    {
        private readonly AppDbContext _context;

        public QueryTipoMercaderia()
        {
            _context = new AppDbContext();
        }

        public List<TipoMercaderia> GetListTiposMercaderia()
        {
            var list = _context.TipoMercaderiaDb.ToList<TipoMercaderia>();
            return list;
        }
    }
}
