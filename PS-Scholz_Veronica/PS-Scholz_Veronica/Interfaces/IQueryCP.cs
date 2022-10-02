using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Interfaces
{
    public interface IQueryCP
    {
        public bool Exists(CarritoProducto cp);
        public void Print(CarritoProducto cp);
        public HashSet<Guid> GetAllGuid();
        public List<Producto> GetProductoByCarrito(Guid carritoId);
        public int[] GetCdadProductoByCarrito(Guid carritoId);
    }
}
