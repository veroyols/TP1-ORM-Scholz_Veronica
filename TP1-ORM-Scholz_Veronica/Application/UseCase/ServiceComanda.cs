using Application.Interfaces;
using Application.Models;
using Domain.Entities;

namespace Application.UseCase
{
    public class ServiceComanda : IServiceComanda
    {
        private readonly ICommandComanda _command;
        private readonly IQueryComanda _query;

        public ServiceComanda(ICommandComanda command, IQueryComanda query)
        {
            _command = command;
            _query = query;
        }
        public async Task<Guid> InsertarComanda(ComandaDto comandaDto) 
        {
            Comanda comanda = new () 
            { 
                ComandaId = comandaDto.ComandaId,
                FormaEntregaId = comandaDto.FormaEntregaId,
                PrecioTotal = comandaDto.PrecioTotal,
                Fecha = comandaDto.Fecha,
            };
            await _command.InsertarComanda(comanda);
            return comandaDto.ComandaId;
        }
        public async Task<List<TicketDto>> GetAllComandas()
        {
            List<Comanda> allComandas = await _query.GetAllComandas();
            List<TicketDto> ticketList = new ();
            
            foreach (Comanda comanda in allComandas)
            {
                List<MercaderiaPrecioDto> mercaderias = new ();
                MercaderiaPrecioDto mercaderiaPrecioDto = new();
                foreach (var subItem in comanda.ComandaMercaderias.ToList())
                {
                    mercaderiaPrecioDto = new()
                    {
                        Tipo = subItem.Mercaderia.TipoMercaderia.Descripcion,
                        MercaderiaNombre = subItem.Mercaderia.Nombre,
                        PrecioUnitario = subItem.Mercaderia.Precio,
                        Cantidad = 1
                    };
                    mercaderias.Add(mercaderiaPrecioDto);
                }
                ticketList.Add(new TicketDto
                {
                    ComandaId = comanda.ComandaId,
                    PrecioTotal = comanda.PrecioTotal,
                    Fecha = comanda.Fecha,
                    FormaEntregaDescripcion = comanda.FormaEntrega.Descripcion,
                    Mercaderias = mercaderias,
                });
            }
            return ticketList;
        }
    }
}
