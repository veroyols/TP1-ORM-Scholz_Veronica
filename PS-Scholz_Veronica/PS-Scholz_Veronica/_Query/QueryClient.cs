using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Persistence;
using PS_Scholz_Veronica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica._Query
{
    public class QueryClient : IQueryClient //consulta
    {
        private readonly AppDbContext _context;

        public QueryClient (AppDbContext context)
        {
            _context = context;
        }
        public Cliente GetClientbyId(int id)
        {
            var cli = _context.ClienteDb.FirstOrDefault<Cliente>(cli => cli.ClienteId == id);
            return cli;
        }
        public int GetIdbyClient(Cliente cli)
        {
            return cli.ClienteId;
        }

        public int EnterId()
        {
            bool m = true;
            int clientId = new int();
            while (m)
            {
                try
                {
                    clientId = int.Parse(Console.ReadLine());
                    GetClientbyId(clientId);
                    m = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("No se ha encontrado cliente con ese ID, intente con otro.");
                }
            }
            return clientId;
        }
    }
}
