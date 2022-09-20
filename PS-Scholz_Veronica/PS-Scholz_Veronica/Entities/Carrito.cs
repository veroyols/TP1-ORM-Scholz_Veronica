using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Persistence
{
    public class Carrito
    {
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
