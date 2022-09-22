using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Entities
{
    public class Carrito
    {
        public Carrito() {}
        public Carrito(int clienteId)
        {
            CarritoId = Guid.NewGuid();
            ClienteId = clienteId;
            Estado = true;
        }

        public Carrito(Guid carritoId, int clienteId, bool estado)
        {
            CarritoId = carritoId;
            ClienteId = clienteId;
            Estado = estado;
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
