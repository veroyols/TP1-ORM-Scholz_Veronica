using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Persistence;

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
            _context.CarritoProductoDb.Add(cp);
            _context.SaveChanges(); 
        }

        public void UpdateCP(CarritoProducto cp, int cdad)
        {
            var up = _context.CarritoProductoDb.First(c => c.CarritoId == cp.CarritoId && c.ProductoId == cp.ProductoId);
            up.Cantidad += cdad;
            _context.SaveChanges();
        }
    }
}
