using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICommandComanda
    {
        public Task InsertarComanda(Comanda comanda);
    }
}
