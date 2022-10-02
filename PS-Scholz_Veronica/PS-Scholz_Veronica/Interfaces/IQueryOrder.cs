using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Interfaces
{
    public interface IQueryOrder
    {
        public void GetProductsByCartId(Guid cartid);
        public Orden GetOrderbyId(Guid id);
        public void Print(Orden o);
        public List<Orden> GetAll();
        public List<Orden> GetToday();
        public List<Guid> GetAllGuid();
    }
}
