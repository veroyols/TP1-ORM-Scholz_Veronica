using Application.Models;

namespace Application.Interfaces
{
    public interface ICommandComandaMercaderia
    {
        public Task InsertarComandaMercaderia(ComandaDto comandaDto);
    }
}
