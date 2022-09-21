using PS_Scholz_Veronica._Command;
using PS_Scholz_Veronica._Query;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Servicios
{
    public class Service
    {
        private static readonly AppDbContext _context = new AppDbContext();
        public ICommandClient commandClient = new CommandClient(_context);
        public IQueryClient queryClient = new QueryClient(_context);
        public IQueryProduct queryProduct = new QueryProduct(_context);
        public IQueryCart queryCart = new QueryCart(_context);
        public ICommandCart commandCart = new CommandCart(_context);

    }
}
