using Application.Interfaces;
using Application.UseCase;
using Domain.Entities;
using Infrastructure.cqrs_Query;
using Infrastructure.Persistence;

namespace TP1_ORM_Scholz_Veronica.Create
{
    public class AllServices
    {
        private static readonly AppDbContext _context = new AppDbContext();

        private readonly IQueryMercaderia _queryMercaderia;
        private readonly IQueryTipoMercaderia _queryTipoMercaderia;

        private readonly IServiceMercaderia _serviceMercaderia;
        private readonly IServiceTipoMercaderia _serviceTipoMercaderia;

        private Dictionary<int,int> mercaderiaSeleccionada;

        public AllServices() {
            _queryMercaderia = new QueryMercaderia(_context);
            _queryTipoMercaderia = new QueryTipoMercaderia(_context);

            _serviceMercaderia = new ServiceMercaderia(_queryMercaderia);
            _serviceTipoMercaderia = new ServiceTipoMercaderia(_queryTipoMercaderia);
            mercaderiaSeleccionada = new Dictionary<int, int>();
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

        internal void PrecargaMercaderia(int idMercaderiaSeleccionada)
        {
            if (mercaderiaSeleccionada.ContainsKey(idMercaderiaSeleccionada))
            {
                int cdad = mercaderiaSeleccionada[idMercaderiaSeleccionada];
                mercaderiaSeleccionada[idMercaderiaSeleccionada] = cdad+1;
            }
            else
            {
                mercaderiaSeleccionada.Add(idMercaderiaSeleccionada, 1);
            }
            foreach (var item in mercaderiaSeleccionada)
            {
                Console.WriteLine("Clave (MercaderiaId): {0} - Valor (Cantidad) {1} ", item.Key, item.Value);
            }
        }
        internal void LimpiarPrecargaMercaderia()
        {
            mercaderiaSeleccionada.Clear();
        }
    }
}
