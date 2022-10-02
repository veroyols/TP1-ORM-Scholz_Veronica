using PS_Scholz_Veronica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Interfaces
{
    public interface IQueryCart
    {
        public Guid GetGuidbyCart(Carrito cart);
        public Carrito GetCartbyClientId(int clientId);
        public bool ExistsCartByClientId(int clientId);
        public bool State(Carrito cart);
        public int GetClientIdbyCarritoId(Guid cartId);

    }
}
