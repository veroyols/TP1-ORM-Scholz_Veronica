using Application.Interfaces;
using Domain.Entities;

namespace Application.UseCase
{
    public class ServiceTipoMercaderia : IServiceTipoMercaderia
    {
        private readonly IQueryTipoMercaderia _query;

        public ServiceTipoMercaderia(IQueryTipoMercaderia query)
        {
            _query = query;
        }
        public List<TipoMercaderia> GetAllTiposMercaderia()
        {
            var list = _query.GetListTiposMercaderia();
            return list;
        }
    }
}
