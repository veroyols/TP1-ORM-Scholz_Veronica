using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Persistence;

namespace PS_Scholz_Veronica._Command
{
    public class CommandOrder : ICommandOrder
    {
        private readonly AppDbContext _context;

        public CommandOrder(AppDbContext context)
        {
            _context = context;
        }
        public async void InsertOrder(Orden order)
        {
            await _context.OrdenDb.AddAsync(order);
            _context.SaveChanges();
        }
    }
}
