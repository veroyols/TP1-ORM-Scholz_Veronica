using Application.Interfaces;

namespace Application.UseCase
{
    public class ServiceComandaMercaderia : IServiceComandaMercaderia
    {
        private readonly ICommandComandaMercaderia _command;

        public ServiceComandaMercaderia(ICommandComandaMercaderia command)
        {
            _command = command;
        }
        public void InsertarMercaderias(Guid comandaId, int mercaderiaId)
        {
            throw new NotImplementedException();
        }
    }
}
