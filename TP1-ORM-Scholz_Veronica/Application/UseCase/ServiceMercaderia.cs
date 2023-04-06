using Application.Interfaces;
using Domain.Entities;

namespace Application.UseCase
{
    public class ServiceMercaderia : IServiceMercaderia
    {
        private readonly IQueryMercaderia _query;

        public ServiceMercaderia(IQueryMercaderia query)
        {
            _query = query;
        }
        public async Task<List<Mercaderia>> GetAllMercaderias()
        {
            var list = await _query.GetListMercaderia();
            return list;
        }

        public async Task<int> GetCdadMercaderiasPorTipo(int tipoMercaderiaId)
        {
            int cdad = await _query.GetCdadPorTipo(tipoMercaderiaId);
            return cdad;
        }

        public async Task<List<Mercaderia>> GetMercaderiasPorTipo(int tipoMercaderiaId)
        {
            var list = await _query.GetListMercaderiaPorTipo(tipoMercaderiaId);
            return list;
        }
    }
}
