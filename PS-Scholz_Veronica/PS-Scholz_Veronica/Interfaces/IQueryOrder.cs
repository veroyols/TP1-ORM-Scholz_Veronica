using PS_Scholz_Veronica.Entities;

namespace PS_Scholz_Veronica.Interfaces
{
    public interface IQueryOrder
    {
        public Orden GetOrderbyId(Guid id);
        public List<Orden> GetAll();
        public List<Orden> GetToday();
        public List<Guid> GetAllGuid();
    }
}
