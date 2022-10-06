using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;
using PS_Scholz_Veronica.Persistence;


namespace PS_Scholz_Veronica._Command
{
    public class CommandCart : ICommandCart
    {
        private readonly AppDbContext _context;
        public CommandCart(AppDbContext context)
        {
            _context = context;
        }

        public void InsertCart(Carrito cart)
        {
            _context.Add<Carrito>(cart);
            _context.SaveChanges();
        }

        public void StatusFalse(Carrito carro)
        {
            var up = _context.CarritoDb.First(x => x.Equals(carro));
            up.Estado = false;
            _context.SaveChanges();
        }
    }
}