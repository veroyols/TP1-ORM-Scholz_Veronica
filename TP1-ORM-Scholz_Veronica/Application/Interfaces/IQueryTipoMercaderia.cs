using Domain.Entities;

namespace Application.Interfaces
{
    public interface IQueryTipoMercaderia
    {
        public Task<List<TipoMercaderia>> GetListTiposMercaderia();
        public Task<int> GetCantidad(int tipoMercaderia);
        public Task<TipoMercaderia> GetTipo(int tipoMercaderia);
    }
}
