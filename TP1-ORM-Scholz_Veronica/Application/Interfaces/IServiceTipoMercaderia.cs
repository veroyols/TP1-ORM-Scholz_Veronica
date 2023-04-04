using Domain.Entities;

namespace Application.Interfaces
{
    public interface IServiceTipoMercaderia
    {
        public Task<List<TipoMercaderia>> GetAllTiposMercaderia();
        public Task<int> GetCantidadDeTipos(int tipoMercaderiaId);

    }
}
