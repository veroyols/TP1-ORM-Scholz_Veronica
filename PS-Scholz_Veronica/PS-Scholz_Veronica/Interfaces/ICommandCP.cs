using PS_Scholz_Veronica.Entities;

namespace PS_Scholz_Veronica.Interfaces
{
    public interface ICommandCP
    {
        public void InsertCP(CarritoProducto cp);
        public void UpdateCP(CarritoProducto cp, int cdad);
    }
}
