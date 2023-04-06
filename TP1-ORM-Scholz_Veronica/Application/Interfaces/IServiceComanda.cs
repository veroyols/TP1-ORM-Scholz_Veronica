using Application.Models;

namespace Application.Interfaces
{
    public interface IServiceComanda
    {
        public Task<Guid> InsertarComanda(ComandaDto comandaDto);
        public Task<List<TicketDto>> GetAllComandas();

    }
}
