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

        public async Task<int> GetCdadPorTipo(int tipoMercaderiaId)
        {
            int cdad = await Task.Run(() => _appDbContext.MercaderiaDb
                .Where(el => el.TipoMercaderiaId == tipoMercaderiaId)
                .Count());
            return cdad;
        }

        public async Task<List<Mercaderia>> GetListMercaderia()
        {
            var list = await Task.Run(() => _appDbContext.MercaderiaDb.ToList<Mercaderia>());
            return list;
        }

        public async Task<List<Mercaderia>> GetListMercaderiaPorTipo(int tipoMercaderiaId)
        {
            var list = await Task.Run(() => _appDbContext.MercaderiaDb
                .Where(el => el.TipoMercaderiaId == tipoMercaderiaId)
                .ToList<Mercaderia>());
            return list;
        }

        public async Task<Mercaderia> GetMercaderiaById(int mercaderiaId)
        {
            Mercaderia mercaderia = await Task.Run(() => _appDbContext.MercaderiaDb.FirstOrDefault(el => el.MercaderiaId == mercaderiaId));
            return mercaderia;
        }
    }
}
