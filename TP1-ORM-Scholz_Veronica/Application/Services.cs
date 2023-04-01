using Application.Interfaces;
using Domain.Entities;
using System;

namespace Application
{
    public class Services
    {
        private readonly IQueryMercaderia _queryMercaderia;
        private readonly IQueryTipoMercaderia _queryTipoMercaderia;
        public Services(IQueryMercaderia queryMercaderia, IQueryTipoMercaderia queryTipoMercaderia) { 
            _queryMercaderia = queryMercaderia;
            _queryTipoMercaderia = queryTipoMercaderia;

        }
        public List<Mercaderia> GetAllMercaderias()
        {
            var list = _queryMercaderia.GetListMercaderia();
            return list;
        }
        public List<TipoMercaderia> GetAllTiposMercaderia()
        {
            var list = _queryTipoMercaderia.GetListTiposMercaderia();
            return list;
        }
    }
}
