using Domain.Entities;

namespace Application.Interfaces
{
    public interface IServiceMercaderia
    {
        public Task<List<Mercaderia>> GetAllMercaderias();
        public Task<List<Mercaderia>> GetMercaderiasPorTipo(int tipoMercaderiaId);
        public Task<int> GetCdadMercaderiasPorTipo(int tipoMercaderiaId);
       
    }
}
