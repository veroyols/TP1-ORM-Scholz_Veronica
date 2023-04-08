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
        public async Task<TipoMercaderia> GetTipo(int tipoMercaderia)
        {
            var tipo = await Task.Run(() => _appDbContext.TipoMercaderiaDb
                .FirstOrDefault(item => item.TipoMercaderiaId == tipoMercaderia)
                );
            return tipo;
        }
        public async Task<int> GetCantidad(int tipoMercaderia)
        {
            int cdad = await Task.Run(() => _appDbContext.TipoMercaderiaDb.Count());
            return cdad;
        }
        public async Task<List<TipoMercaderia>> GetListTiposMercaderia()
        {
            var list = await Task.Run(() => _appDbContext.TipoMercaderiaDb.ToList());
            return list;
        }
    }
}
