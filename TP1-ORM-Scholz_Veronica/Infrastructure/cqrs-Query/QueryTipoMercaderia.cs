using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.cqrs_Query
{
    public class QueryTipoMercaderia : IQueryTipoMercaderia
    {
        private readonly AppDbContext _appDbContext;

        public QueryTipoMercaderia(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public int GetCantidad(int tipoMercaderia)
        {
            int cdad = _appDbContext.TipoMercaderiaDb.Count();
            return cdad;
        }

        public List<TipoMercaderia> GetListTiposMercaderia()
        {
            var list = _appDbContext.TipoMercaderiaDb.ToList<TipoMercaderia>();
            return list;
        }
    }
}
