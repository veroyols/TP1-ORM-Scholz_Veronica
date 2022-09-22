using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PS_Scholz_Veronica._Command
{
    public class CommandClient : ICommandClient
    {
        private readonly AppDbContext _context;

        public CommandClient(AppDbContext context)
        {
            _context = context;
        }
        public void InsertClient(Cliente cliente)
        {
            _context.ClienteDb.Add(cliente);
            _context.SaveChanges();
            return;
        }
    }
}
