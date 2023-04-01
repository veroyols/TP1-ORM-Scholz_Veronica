using Domain.Entities;

namespace Application.Interfaces
{
    public interface IServiceMercaderia
    {
        public List<Mercaderia> GetAllMercaderias();
        public List<Mercaderia> GetMercaderiasPorTipo(int tipoMercaderiaId);
    }
}
