using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Model;
using PS_Scholz_Veronica.Servicios;

namespace PS_Scholz_Veronica.PrintData
{
    public class ReportSale
    {
        public static void ReportOfDay(Service _service)
        {
            List<Orden> listaDelDia = _service.GetOrderToday(); 
            foreach (var orden in listaDelDia)
            {
                Cliente cli = _service.GetClientByOrder(orden.CarritoId);

                Console.WriteLine("     ---------------------------------------------------");
                Console.WriteLine("     Ticket Numero: {0} " +
                    "\n     Fecha: {1} " +
                    "\n     Cliente: {2} {3}" +
                    "\n     Productos:", orden.OrdenId, orden.Fecha, cli.Nombre, cli.Apellido);

                List<ProductoCantidad> list = _service.GetProductoCantidad(orden.CarritoId);
                foreach (var product in list)
                    Console.WriteLine("      (*) {0} x{1} ----- ${2}", product.producto.Nombre, product.cantidad, product.producto.Precio);
                Console.WriteLine("     ---------------------------------------------------");
                Console.WriteLine("                        Total a pagar:       ${0}", orden.Total);
                Console.WriteLine("     ---------------------------------------------------\n \n");
            }
        }
    }
}
