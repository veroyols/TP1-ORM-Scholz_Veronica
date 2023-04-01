using Domain.Entities;

namespace Application.Interfaces
{
    public interface IQueryTipoMercaderia
    {
        public List<TipoMercaderia> GetListTiposMercaderia();
    }
}
