using Application.Interfaces;
using Domain.Entities;
using System;

namespace Application.UseCase
{
    public class ServiceMercaderia : IServiceMercaderia
    {
        private readonly IQueryMercaderia _query;

        public ServiceMercaderia(IQueryMercaderia query)
        {
            _query = query;
        }
        public List<Mercaderia> GetAllMercaderias()
        {
            var list = _query.GetListMercaderia();
            return list;
        }

        public List<Mercaderia> GetMercaderiasPorTipo(int tipoMercaderiaId)
        {
            var list = _query.GetListMercaderiaPorTipo(tipoMercaderiaId);
            return list;
        }
    }
}
