namespace Domain.Models
{
    public class ComandaDto
    {
        public Guid ComandaId;
        public int FormaEntregaId;
        public int PrecioTotal;
        public DateTime Fecha;
        public ComandaDto(int formaEntrega, int precio)
        {
            ComandaId = new Guid();
            FormaEntregaId = formaEntrega;
            PrecioTotal = precio;
            Fecha = DateTime.Now;
        }
    }
}
