using PS_Scholz_Veronica.Entities;

namespace PS_Scholz_Veronica.Interfaces
{
    public interface IQueryCart
    {
        public Guid GetGuidbyCart(Carrito cart);
        public int GetClientIdbyCarritoId(Guid cartId);
    }
}
