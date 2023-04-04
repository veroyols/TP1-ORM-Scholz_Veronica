using Domain.Entities;

namespace Application.Interfaces
{
    public interface IQueryMercaderia
    {
        public Task<List<Mercaderia>> GetListMercaderia();
        public Task<List<Mercaderia>> GetListMercaderiaPorTipo(int tipoMercaderiaId);
        public Task<int> GetCdadPorTipo(int tipoMercaderiaId);
    }
}
