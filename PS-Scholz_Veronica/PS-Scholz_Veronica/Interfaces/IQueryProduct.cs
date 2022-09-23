using PS_Scholz_Veronica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Interfaces
{
    public interface IQueryProduct
    {
        public Producto GetProductbyId(int id);
        public List<Producto> GetAll();
        public int CountAll();
        public void Print(int productoId);
        public void Print(Producto producto);
        public void PrintAll();
        public int EnterId();
        public decimal GetPreciobyId(int id);


    }
}
