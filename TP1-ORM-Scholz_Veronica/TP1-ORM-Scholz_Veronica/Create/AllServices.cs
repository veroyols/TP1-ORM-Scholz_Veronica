using Application.Interfaces;
using Application.UseCase;
using Domain.Entities;
using Infrastructure.cqrs_Query;
using Infrastructure.Persistence;
using System.Collections.Generic;

namespace TP1_ORM_Scholz_Veronica.Create
{
    public class AllServices
    {
        private static readonly AppDbContext _context = new AppDbContext();

        private readonly IQueryMercaderia _queryMercaderia;
        private readonly IQueryTipoMercaderia _queryTipoMercaderia;

        private readonly IServiceMercaderia _serviceMercaderia;
        private readonly IServiceTipoMercaderia _serviceTipoMercaderia;

        public AllServices() {
            _queryMercaderia = new QueryMercaderia(_context);
            _queryTipoMercaderia = new QueryTipoMercaderia(_context);

            _serviceMercaderia = new ServiceMercaderia(_queryMercaderia);
            _serviceTipoMercaderia = new ServiceTipoMercaderia(_queryTipoMercaderia);
        }
        public List<TipoMercaderia> GetAllTiposMercaderia()
        {
            var list = _serviceTipoMercaderia.GetAllTiposMercaderia();
            return list;
        }
        public List<Mercaderia> GetAllMercaderias()
        {
            var list = _serviceMercaderia.GetAllMercaderias();
            return list;
        }
        public List<Mercaderia> GetMercaderiasPorTipo(int tipoMercaderiaId)
        {
            var list = _serviceMercaderia.GetMercaderiasPorTipo(tipoMercaderiaId);
            return list;
        }
        public int GetCantidadMercaderiasPorTipo(int tipoMercaderiaId)
        {
            int cdad = _serviceMercaderia.GetCdadMercaderiasPorTipo(tipoMercaderiaId);
            return cdad;
        }
        public int GetCantidadDeTipos(int tipoMercaderiaId)
        {
            int cdad = _serviceTipoMercaderia.GetCantidadDeTipos(tipoMercaderiaId);
            return cdad;
        }
    }
}
