using Application.Interfaces;
using Application.Models;

namespace Application.UseCase
{
    public class ServiceComanda : IServiceComanda
    {
        private readonly ICommandComanda _command;

        public ServiceComanda(ICommandComanda command)
        {
            _command = command;
        }
        public Guid InsertarComanda(ComandaDto comandaDto, Dictionary<int, int> precarga) 
        {
            int price = 0;
            foreach (var item in precarga)
            {
//
            }
            comandaDto.PrecioTotal = price;
            _command.InsertarComanda(comandaDto);
            return comandaDto.ComandaId;
        }
    }
}
