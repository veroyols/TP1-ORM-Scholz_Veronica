using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.cqrs_Query
{
    public class QueryMercaderia : IQueryMercaderia
    {
        private readonly AppDbContext _appDbContext;

        public QueryMercaderia(AppDbContext context)
        {
            _appDbContext = context;
        }

        public int GetCdadPorTipo(int tipoMercaderiaId)
        {
            int cdad = _appDbContext.MercaderiaDb
                .Where(el => el.TipoMercaderiaId == tipoMercaderiaId)
                .Count();
            return cdad;
        }

        public List<Mercaderia> GetListMercaderia()
        {
            var list = _appDbContext.MercaderiaDb.ToList<Mercaderia>();
            return list;
        }

        public List<Mercaderia> GetListMercaderiaPorTipo(int tipoMercaderiaId)
        {
            var list = _appDbContext.MercaderiaDb
                .Where(el => el.TipoMercaderiaId == tipoMercaderiaId)
                .ToList<Mercaderia>();
            return list;
        }
    }
}
