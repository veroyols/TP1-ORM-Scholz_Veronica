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
        private Dictionary<int, AmountPriceDto> selectedMerchandise;

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

            selectedMerchandise = new Dictionary<int, AmountPriceDto>(); // [id: 1, {cdad: 1, precio: 1}]
        }
        internal async Task<string> GetType(int op)
        {
            string typeDescription = await _serviceTipoMercaderia.GetType(op);
            return typeDescription;
        }
        internal async Task<List<TipoMercaderia>> GetAllTipoMercaderia()
        {
            var list = await _serviceTipoMercaderia.GetAllTiposMercaderia();
            return list;
        }
        internal async Task<List<Mercaderia>> GetMercaderiasByType(int tipoMercaderiaId)
        {
            var list = await _serviceMercaderia.GetMercaderiasByType(tipoMercaderiaId);
            return list;
        }
        internal async Task<int> AmountByType(int tipoMercaderiaId)
        {
            int amount = await _serviceMercaderia.GetAmountByType(tipoMercaderiaId);
            return amount;
        }
        internal async Task<int> GetAmountOfType(int tipoMercaderiaId)
        {
            int amount = await _serviceTipoMercaderia.GetAmountOfType(tipoMercaderiaId);
            return amount;
        }
        internal async Task<int> GetPrice(int idMercaderiaSeleccionada)
        {
            int price = await _serviceMercaderia.GetPrice(idMercaderiaSeleccionada);
            return price;
        }
        internal void AddToSelected(int idMercaderiaSeleccionada, int price)
        {
            if (selectedMerchandise.ContainsKey(idMercaderiaSeleccionada))
            {
                int amount = selectedMerchandise[idMercaderiaSeleccionada].Amount;
                amount += 1;
                selectedMerchandise[idMercaderiaSeleccionada] = new AmountPriceDto { Amount = amount, Price = price };
            }
            else
            {
                selectedMerchandise.Add(idMercaderiaSeleccionada, new AmountPriceDto { Amount = 1, Price = price});
            }
            Console.WriteLine("\n -------------------------------------------------------------");
            Console.WriteLine("                            PRECARGA");
            Console.WriteLine(" -------------------------------------------------------------\n");
            int index = 0;
            foreach (var item in selectedMerchandise)
            {
                index++;
                string nombre = _serviceMercaderia.GetMercaderiaById(item.Key).Result;
                Console.WriteLine("             {0}) {1} | {2} x ${3}) ", index, nombre, item.Value.Amount, item.Value.Price);
            }
            Console.WriteLine("\n         Presione una tecla . . .");
        }
        internal void ClearMerchandisePreload()
        {
            selectedMerchandise.Clear();
        }
        internal async Task SaveOrder(int method)
        {
            if (selectedMerchandise.Count == 0)
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
                int amount = 0;
                int total = 0;
                foreach (var item in selectedMerchandise)
                {
                    amount = item.Value.Amount * item.Value.Price;
                    total += amount;
                }

                //Crear Comanda
                OrderDto orderDto = new ()
                {
                    MethodId = method,
                    Price = total,
                };
                Guid comandaId = await _serviceComanda.InsertComanda(orderDto);
            
                //Agregar Mercaderias
                MerchandiseOrderDto comandaMercaderiaDto = new ()
                {
                    OrderId = comandaId,
                    selectedMerchandise = selectedMerchandise,
                };
                await _serviceComandaMercaderia.InsertMercaderia(comandaMercaderiaDto);
            }
        }
        internal async Task AllComandas()
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

                    foreach (MerchandiseDto merchandise in comanda.Mercaderias) 
                    {
                        Console.WriteLine("          {0}: {1} ({2}x{3})", merchandise.Type, merchandise.MerchandiseName, merchandise.Amount, merchandise.Price);
                    }

                    Console.WriteLine("\n          Total a pagar:.............................. ${0}\n", comanda.PrecioTotal);
                    Console.WriteLine(" -------------------------------------------------------------");
                }
            }
        }
    }
}
