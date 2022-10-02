using PS_Scholz_Veronica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Model
{
    public class Venta
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }    
        public List<CarritoProducto> CarritoProductos { get; set; }
        public DateTime Fecha { get; set; }
    }
}
