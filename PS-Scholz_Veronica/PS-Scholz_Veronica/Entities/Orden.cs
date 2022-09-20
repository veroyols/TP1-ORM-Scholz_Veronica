using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Entities
{
    public class Orden
    {
        [Key]
        public Guid OrdenId { get; set; }
        public Guid CarritoId { get; set; }

        public DateTime Fecha { get; set; }
        public decimal Total { get; set; } 
        
        //Relaciones
        public Carrito Carrito { get; set; }
        
    }
}
