using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica._Command
{
    public class CommandCP : ICommandCP
    {
        private readonly AppDbContext _context;

        public CommandCP(AppDbContext context)
        {
            _context = context;
        }

        public void InsertCP(CarritoProducto cp)
        {
            _context.Add(cp);
            _context.SaveChanges();
            return;
        }
    }
}
