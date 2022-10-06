using PS_Scholz_Veronica.Entities;

namespace PS_Scholz_Veronica.Interfaces
{
    public interface IQueryClient
    {
        public Cliente GetClientbyId(int id);
        public int GetIdbyClient(Cliente cli);
        public bool Exists(int clienteId);
        public bool ExistsDni(string dni);

    }
}
