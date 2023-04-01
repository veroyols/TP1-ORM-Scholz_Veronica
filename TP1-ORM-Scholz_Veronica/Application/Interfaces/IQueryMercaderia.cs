using Domain.Entities;

namespace Application.Interfaces
{
    public interface IQueryMercaderia
    {
        public List<Mercaderia> GetListMercaderia();
        public List<Mercaderia> GetListMercaderiaPorTipo(int tipoMercaderiaId);
    }
}
