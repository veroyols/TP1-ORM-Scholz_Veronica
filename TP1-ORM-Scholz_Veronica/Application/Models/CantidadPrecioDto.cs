namespace Application.Models
{
    public class CantidadPrecioDto
    {
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public void SetCantidad(int cdad)
        {
            Cantidad = cdad;
        }
    }
}
