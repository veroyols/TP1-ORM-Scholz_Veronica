using Domain.Models;

namespace Application.Interfaces
{
    public interface IServiceComanda
    {
        public Guid InsertarComanda(int formaEntrega, Dictionary<int,int> precarga);
    }
}
