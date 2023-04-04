namespace Application.Models
{
    public class ComandaDto
    {
        public Guid ComandaId { get; set; }
        public int FormaEntregaId { get; set; }
        public int PrecioTotal{ get; set; }
        public DateTime Fecha{ get; set; }
        public ComandaDto() 
        {
            ComandaId = Guid.NewGuid();
            Fecha = DateTime.Now;
        }
    }
}
