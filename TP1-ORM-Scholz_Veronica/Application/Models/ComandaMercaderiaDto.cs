namespace Application.Models
{
    public class ComandaMercaderiaDto
    {
        public Guid ComandaId { get; set; }
        public int MercaderiaId{ get; set; }
        public Dictionary<int, CantidadPrecioDto> mercaderiaSeleccionada { get; set; }
    }
}
