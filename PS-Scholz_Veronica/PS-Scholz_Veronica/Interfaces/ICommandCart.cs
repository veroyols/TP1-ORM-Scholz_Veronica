using PS_Scholz_Veronica.Entities;

namespace PS_Scholz_Veronica.Interfaces
{
    public interface ICommandCart
    {
        public void InsertCart(Carrito cart);
        public void StatusFalse(Carrito carro);
    }
}
