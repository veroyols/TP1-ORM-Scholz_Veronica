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
    public class CommandOrder : ICommandOrder
    {
        private readonly AppDbContext _context;

        public CommandOrder(AppDbContext context)
        {
            _context = context;
        }
        public void InsertOrder(Orden order)
        {
            _context.OrdenDb.Add(order);
            _context.SaveChanges();
            return;
        }
    }
}
