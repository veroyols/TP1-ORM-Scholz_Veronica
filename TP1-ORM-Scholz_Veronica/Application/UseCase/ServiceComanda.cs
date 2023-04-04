using Application.Interfaces;
using Application.Models;
using Domain.Entities;

namespace Application.UseCase
{
    public class ServiceComanda : IServiceComanda
    {
        private readonly ICommandComanda _command;

        public ServiceComanda(ICommandComanda command)
        {
            _command = command;
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
    }
}
