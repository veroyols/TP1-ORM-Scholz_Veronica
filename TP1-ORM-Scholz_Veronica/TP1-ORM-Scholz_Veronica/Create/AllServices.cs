using Application.Interfaces;
using Application.Models;
using Application.UseCase;
using Domain.Entities;
using Infrastructure.cqrs_Command;
using Infrastructure.cqrs_Query;
using Infrastructure.Persistence;
using System.Text.Json.Nodes;

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
        private Dictionary<int, CantidadPrecioDto> mercaderiaSeleccionada;


        public AllServices() {
            _queryMercaderia = new QueryMercaderia(_context);
            _queryTipoMercaderia = new QueryTipoMercaderia(_context);
            _commandComanda = new CommandComanda(_context);
            _commandComandaMercaderia = new CommandComandaMercaderia(_context);

            _serviceMercaderia = new ServiceMercaderia(_queryMercaderia);
            _serviceTipoMercaderia = new ServiceTipoMercaderia(_queryTipoMercaderia);
            _serviceComanda = new ServiceComanda(_commandComanda);
            _serviceComandaMercaderia = new ServiceComandaMercaderia(_commandComandaMercaderia);

            mercaderiaSeleccionada = new Dictionary<int, CantidadPrecioDto>(); // [{id: 1, cdad: 1, precio: 1}]
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

        internal void PrecargaMercaderia(int idMercaderiaSeleccionada, int price)
        {
            if (mercaderiaSeleccionada.ContainsKey(idMercaderiaSeleccionada))
            {
                int cdad = mercaderiaSeleccionada[idMercaderiaSeleccionada].Cantidad;
                cdad += 1;
                mercaderiaSeleccionada[idMercaderiaSeleccionada] = new CantidadPrecioDto { Cantidad = cdad, Precio = price };
            }
            else
            {
                mercaderiaSeleccionada.Add(idMercaderiaSeleccionada, new CantidadPrecioDto { Cantidad = 1, Precio = price});

            }
            foreach (var item in mercaderiaSeleccionada)
            {
                Console.WriteLine("Clave (MercaderiaId): {0} - Valor (cdad {1}, precio {2}) ", item.Key, item.Value.Cantidad, item.Value.Precio);
            }
        }
        internal void LimpiarPrecargaMercaderia()
        {
            mercaderiaSeleccionada.Clear();
        }
        internal void GuardarPedido(int formaEntrega)
        {
            ComandaDto comandaDto = new ComandaDto
            {
                ComandaId = new Guid(),
                Fecha = new DateTime(),
                FormaEntregaId = formaEntrega
            };
            //Crear Comanda
            Guid comandaId = _serviceComanda.InsertarComanda(comandaDto, new Dictionary<int, int>());
            //Agregar Mercaderias con ese Id
            int mercaderiaId = 1;
            _serviceComandaMercaderia.InsertarMercaderias(comandaId, mercaderiaId);
        }
    }
}
