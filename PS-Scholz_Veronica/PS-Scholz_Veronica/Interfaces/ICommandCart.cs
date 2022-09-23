using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Interfaces
{
    public interface ICommandCart
    {
        public void InsertCart(Carrito cart);
        public void StatusFalse(Carrito carro);
    }
}
