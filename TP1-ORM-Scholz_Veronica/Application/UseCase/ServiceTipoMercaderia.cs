using Application.Interfaces;
using Domain.Entities;

namespace Application.UseCase
{
    public class ServiceTipoMercaderia : IServiceTipoMercaderia
    {
        private readonly IQueryTipoMercaderia _query;

        public ServiceTipoMercaderia(IQueryTipoMercaderia query)
        {
            _query = query;
        }

        public async Task<string> GetTipo(int tipoMercaderiaId)
        {
            string tipo = await Task.Run(() => _query.GetTipo(tipoMercaderiaId).Result.Descripcion);
            return tipo;
        }
        public async Task<List<TipoMercaderia>> GetAllTiposMercaderia()
        {
            var list = await _query.GetListTiposMercaderia();
            return list;
        }

        public async Task<int> GetCantidadDeTipos(int tipoMercaderiaId)
        {
            int cdad = await _query.GetCantidad(tipoMercaderiaId);
            return cdad;
        }
    }
}
