
using Domain.Models;

namespace Application.Interfaces
{
    public interface ICommandComanda
    {
        public Task InsertarComanda(ComandaDto comandaDto);
    }
}
