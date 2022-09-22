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
            return;
        }

        public void StatusFalse(Guid id)
        {
            var up = _context.CarritoDb.First(x => x.CarritoId == id);
            up.Estado = false;
            _context.SaveChanges();
            return;

        }
    }
}