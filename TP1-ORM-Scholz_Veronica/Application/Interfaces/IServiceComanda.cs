using Application.Models;

namespace Application.Interfaces
{
    public interface IServiceComanda
    {
        public Guid InsertarComanda(ComandaDto comandaDto, Dictionary<int,int> precarga);
    }
}
