using Application.Interfaces;
using Application.Models;
using Application.UseCase;
using Domain.Entities;
using Infrastructure.cqrs_Command;
using Infrastructure.cqrs_Query;
using Infrastructure.Persistence;

namespace TP1_ORM_Scholz_Veronica.Create
{
    public class AllServices
    {
        private static readonly AppDbContext _context = new AppDbContext();

        private readonly IQueryMercaderia _queryMercaderia;
        private readonly IQueryTipoMercaderia _queryTipoMercaderia;
        private readonly IQueryComanda _queryComanda;

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
            _queryComanda = new QueryComanda(_context);
            _commandComanda = new CommandComanda(_context);
            _commandComandaMercaderia = new CommandComandaMercaderia(_context);

            _serviceMercaderia = new ServiceMercaderia(_queryMercaderia);
            _serviceTipoMercaderia = new ServiceTipoMercaderia(_queryTipoMercaderia);
            _serviceComanda = new ServiceComanda(_commandComanda, _queryComanda);
            _serviceComandaMercaderia = new ServiceComandaMercaderia(_commandComandaMercaderia);

            mercaderiaSeleccionada = new Dictionary<int, CantidadPrecioDto>(); // [id: 1, {cdad: 1, precio: 1}]
        }
        internal async Task<string> GetTipo(int op)
        {
            string tipo = await _serviceTipoMercaderia.GetTipo(op);
            return tipo;
        }
        internal async Task<List<TipoMercaderia>> GetAllTiposMercaderia()
        {
            var list = await _serviceTipoMercaderia.GetAllTiposMercaderia();
            return list;
        }
        internal async Task<List<Mercaderia>> GetAllMercaderias()
        {
            var list = await _serviceMercaderia.GetAllMercaderias();
            return list;
        }
        internal async Task<List<Mercaderia>> GetMercaderiasPorTipo(int tipoMercaderiaId)
        {
            var list = await _serviceMercaderia.GetMercaderiasPorTipo(tipoMercaderiaId);
            return list;
        }
        internal async Task<int> GetCantidadMercaderiasPorTipo(int tipoMercaderiaId)
        {
            int cdad = await _serviceMercaderia.GetCdadMercaderiasPorTipo(tipoMercaderiaId);
            return cdad;
        }
        internal async Task<int> GetCantidadDeTipos(int tipoMercaderiaId)
        {
            int cdad = await _serviceTipoMercaderia.GetCantidadDeTipos(tipoMercaderiaId);
            return cdad;
        }
        internal async Task<int> GetPrecio(int idMercaderiaSeleccionada)
        {
            int precio = await _serviceMercaderia.GetPrecio(idMercaderiaSeleccionada);
            return precio;
        }
        internal void PrecargaMercaderia(int idMercaderiaSeleccionada, int price)
        {
            if (mercaderiaSeleccionada.ContainsKey(idMercaderiaSeleccionada))
            {
                int cdad = mercaderiaSeleccionada[idMercaderiaSeleccionada].Cantidad;
                cdad += 1;
                mercaderiaSeleccionada[idMercaderiaSeleccionada] = new CantidadPrecioDto { Cantidad = cdad, PrecioUnitario = price };
            }
            else
            {
                mercaderiaSeleccionada.Add(idMercaderiaSeleccionada, new CantidadPrecioDto { Cantidad = 1, PrecioUnitario = price});
            }
            Console.WriteLine("\n -------------------------------------------------------------");
            Console.WriteLine("                            PRECARGA");
            Console.WriteLine(" -------------------------------------------------------------\n");
            int i = 0;
            foreach (var item in mercaderiaSeleccionada)
            {
                i++;
                string nombre = _serviceMercaderia.GetMercaderiaById(item.Key).Result;
                Console.WriteLine("             {0}) {1} | {2} x ${3}) ", i, nombre, item.Value.Cantidad, item.Value.PrecioUnitario);
            }
            Console.WriteLine("\n         Presione una tecla . . .");
        }
        internal void LimpiarPrecargaMercaderia()
        {
            mercaderiaSeleccionada.Clear();
        }
        internal async Task GuardarPedido(int formaEntrega)
        {
            if (mercaderiaSeleccionada.Count == 0)
            {
                Console.WriteLine("\n -------------------------------------------------------------");
                Console.WriteLine("               SU PEDIDO NO CONTIENE PRODUCTOS.");
                Console.WriteLine(" -------------------------------------------------------------\n");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine(" -------------------------------------------------------------");
                Console.WriteLine("             MUCHAS GRACIAS POR SU COMPRA ");
                Console.WriteLine("             ESTAMOS PREPARANDO SU PEDIDO ");
                Console.WriteLine(" -------------------------------------------------------------\n");
                Console.ReadKey(true);
                int monto = 0;
                int total = 0;
                foreach (var item in mercaderiaSeleccionada)
                {
                    monto = item.Value.Cantidad * item.Value.PrecioUnitario;
                    total += monto;
                }

                //Crear Comanda
                ComandaDto comandaDto = new ()
                {
                    FormaEntregaId = formaEntrega,
                    PrecioTotal = total,
                };
                Guid comandaId = await _serviceComanda.InsertarComanda(comandaDto);
            
                //Agregar Mercaderias
                ComandaMercaderiaDto comandaMercaderiaDto = new ()
                {
                    ComandaId = comandaId,
                    mercaderiaSeleccionada = mercaderiaSeleccionada,
                };
                await _serviceComandaMercaderia.InsertarMercaderias(comandaMercaderiaDto);
            }
        }
        internal async Task EnlistarComandas()
        {
            List<TicketDto> ticketList = await _serviceComanda.GetAllComandas();
            if (ticketList.Count == 0)
            {
                Console.WriteLine(" -------------------------------------------------------------");
                Console.WriteLine("              Aun no se han registrado comandas               ");
                Console.WriteLine(" -------------------------------------------------------------");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n -------------------------------------------------------------");
                Console.WriteLine("                   2. ENLISTAR COMANDAS                       ");
                Console.WriteLine(" -------------------------------------------------------------\n");

                foreach (var comanda in ticketList)
                {
                    Console.WriteLine("\n {0} ({1}) - {2}\n",
                        comanda.Fecha.ToShortDateString(), comanda.ComandaId, comanda.FormaEntregaDescripcion);

                    foreach (MercaderiaPrecioDto mercaderia in comanda.Mercaderias) //diccionario<string tipo, MercaderiaPrecioDto>
                    {
                        //                    Console.WriteLine("     " + mercaderia.Key);
                        Console.WriteLine("          {0}: {1} ({2}x{3})", mercaderia.Tipo, mercaderia.MercaderiaNombre, mercaderia.Cantidad, mercaderia.PrecioUnitario);
                    }

                    Console.WriteLine("\n          Total a pagar:.............................. ${0}\n", comanda.PrecioTotal);
                    Console.WriteLine(" -------------------------------------------------------------");
                }
            }
        }
    }
}
