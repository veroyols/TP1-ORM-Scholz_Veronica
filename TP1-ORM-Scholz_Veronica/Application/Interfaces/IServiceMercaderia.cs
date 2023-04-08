using Domain.Entities;

namespace Application.Interfaces
{
    public interface IServiceMercaderia
    {
        public Task<List<Mercaderia>> GetAllMercaderias();
        public Task<List<Mercaderia>> GetMercaderiasPorTipo(int tipoMercaderiaId);
        public Task<int> GetCdadMercaderiasPorTipo(int tipoMercaderiaId);
        public Task<string> GetMercaderiaById(int id);
        public Task<int> GetPrecio(int id); 
    }
}
