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
    }
}
