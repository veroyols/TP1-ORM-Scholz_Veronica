using System.ComponentModel.DataAnnotations;

namespace PS_Scholz_Veronica.Entities
{
    public class Orden
    {
        public Orden() { }
        public Orden(Guid carritoId, decimal monto)
        {
            OrdenId = Guid.NewGuid();
            CarritoId = carritoId;
            Total = monto;
            Fecha = DateTime.Now;
        }

        [Key]
        public Guid OrdenId { get; set; }
        public Guid CarritoId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; } 
        
        //Relaciones
        public Carrito Carrito { get; set; }
        
    }
}
