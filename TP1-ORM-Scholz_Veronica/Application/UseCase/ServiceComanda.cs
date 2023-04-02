using Application.Interfaces;

namespace Application.UseCase
{
    public class ServiceComanda : IServiceComanda
    {
        private readonly ICommandComanda _command;

        public ServiceComanda(ICommandComanda command)
        {
            _command = command;
        }
        public Guid InsertarComanda(int formaEntrega, Dictionary<int, int> precarga) //Dictionary<mercaderiaId,cdad>
        {
            //crearComanda(formaEntrega, precio, fecha) devolver Guid
            //crearComandaMercaderia(mercaderiaId, comandaId)
            return new Guid();
        }
    }
}
