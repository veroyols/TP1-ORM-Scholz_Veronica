using System.ComponentModel.DataAnnotations;

namespace PS_Scholz_Veronica.Entities
{
    public class Carrito
    {
        public Carrito(int clienteId)
        {
            CarritoId = Guid.NewGuid();
            ClienteId = clienteId;
            Estado = true;
        }
        [Key]
        public Guid CarritoId { get; set; } 
        public int ClienteId { get; set; } 
        public bool Estado { get; set; }
        //Relaciones
        public Cliente Cliente { get; set; }
        public IList<CarritoProducto> CarritoProducto { get; set; }
        public Orden Orden { get; set; }

    }
}
