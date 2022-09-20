using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Services
{
    public class ClientServices
    {
        private readonly AppDbContext _context;
        public async Task InsertClient(Cliente cli)
        {
            _context.Add(cli);
            await _context.SaveChangesAsync();
        }
    }
}
