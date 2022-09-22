using PS_Scholz_Veronica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Interfaces
{
    public interface IQueryClient
    {
        public Cliente GetClientbyId(int id);
        public int GetIdbyClient(Cliente cli);
        public int EnterId();

    }
}
