namespace Application.Interfaces
{
    public interface IServiceComandaMercaderia
    {
        public void InsertarMercaderias(Guid comandaId, int mercaderiaId);
    }
}
