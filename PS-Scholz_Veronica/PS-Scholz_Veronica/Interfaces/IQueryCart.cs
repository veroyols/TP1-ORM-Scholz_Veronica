using PS_Scholz_Veronica.Entities;

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
