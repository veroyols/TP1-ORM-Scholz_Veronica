using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Entities
{
    public class CarritoProducto
    {
        public CarritoProducto(Guid carritoId, int productoId, int cantidad)
        {
            CarritoId = carritoId;
            ProductoId = productoId;
            Cantidad = cantidad;
        }

        [Key]
        public Guid CarritoId { get; set; } //PK FK
        [Key]
        public int ProductoId { get; set; } //PK FK
        public int Cantidad { get; set; } 

        //Relaciones
        public Carrito Carrito { get; set; }
        public Producto Producto { get; set; }
    }
}
