using Application.Interfaces;
using Application.UseCase;
using Domain.Entities;
using Domain.Models;
using Infrastructure.cqrs_Command;
using Infrastructure.cqrs_Query;
using Infrastructure.Persistence;
using System.Runtime.CompilerServices;

namespace TP1_ORM_Scholz_Veronica.Create
{
    public class AllServices
    {
        private static readonly AppDbContext _context = new AppDbContext();

        private readonly IQueryMercaderia _queryMercaderia;
        private readonly IQueryTipoMercaderia _queryTipoMercaderia;

        private readonly ICommandComanda _commandComanda;
        private readonly ICommandComandaMercaderia _commandComandaMercaderia;

        private readonly IServiceMercaderia _serviceMercaderia;
        private readonly IServiceTipoMercaderia _serviceTipoMercaderia;
        private readonly IServiceComanda _serviceComanda;
        private readonly IServiceComandaMercaderia _serviceComandaMercaderia;

        //Lista de precarga
        private Dictionary<int,int> mercaderiaSeleccionada;

        public AllServices() {
            _queryMercaderia = new QueryMercaderia(_context);
            _queryTipoMercaderia = new QueryTipoMercaderia(_context);
            _commandComanda = new CommandComanda(_context);
            _commandComandaMercaderia = new CommandComandaMercaderia(_context);

            _serviceMercaderia = new ServiceMercaderia(_queryMercaderia);
            _serviceTipoMercaderia = new ServiceTipoMercaderia(_queryTipoMercaderia);
            _serviceComanda = new ServiceComanda(_commandComanda);
            _serviceComandaMercaderia = new ServiceComandaMercaderia(_commandComandaMercaderia);

            mercaderiaSeleccionada = new Dictionary<int, int>();
        }
        internal List<TipoMercaderia> GetAllTiposMercaderia()
        {
            var list = _serviceTipoMercaderia.GetAllTiposMercaderia();
            return list;
        }
        internal List<Mercaderia> GetAllMercaderias()
        {
            var list = _serviceMercaderia.GetAllMercaderias();
            return list;
        }
        internal List<Mercaderia> GetMercaderiasPorTipo(int tipoMercaderiaId)
        {
            var list = _serviceMercaderia.GetMercaderiasPorTipo(tipoMercaderiaId);
            return list;
        }
        internal int GetCantidadMercaderiasPorTipo(int tipoMercaderiaId)
        {
            int cdad = _serviceMercaderia.GetCdadMercaderiasPorTipo(tipoMercaderiaId);
            return cdad;
        }
        internal int GetCantidadDeTipos(int tipoMercaderiaId)
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
        internal void GuardarPedido(int formaEntrega)
        {
            Guid comandaId = _serviceComanda.InsertarComanda(formaEntrega, mercaderiaSeleccionada);
            int mercaderiaId = 1;
            _serviceComandaMercaderia.InsertarMercaderias(comandaId, mercaderiaId);
        }
    }
}
