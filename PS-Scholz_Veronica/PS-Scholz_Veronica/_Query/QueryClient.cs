using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Persistence;

namespace PS_Scholz_Veronica._Query
{
    public class QueryClient : IQueryClient
    {
        private readonly AppDbContext _context;

        public QueryClient (AppDbContext context)
        {
            _context = context;
        }

        public Cliente GetClientbyId(int id)
        {
            var cli = _context.ClienteDb.First<Cliente>(cli => cli.ClienteId == id);
            return cli;
        }

        public int GetIdbyClient(Cliente cli)
        {
            return cli.ClienteId;
        }
        public bool Exists(int clienteId)
        {
            return _context.ClienteDb.Any(p => p.ClienteId == clienteId);
        }
        public bool ExistsDni(string dni)
        {
            return _context.ClienteDb.Any(p => p.DNI == dni);
        }

    }
}
