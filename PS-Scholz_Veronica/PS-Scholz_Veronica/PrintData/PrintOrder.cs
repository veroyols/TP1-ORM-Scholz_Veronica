using PS_Scholz_Veronica.Entities;

namespace PS_Scholz_Veronica.PrintData
{
    public class PrintOrder
    {
        public static void Print(Orden orden) 
        {
            Console.WriteLine("      ------------------------------------------------------");
            Console.WriteLine("     | Orden de compra: {0} | \n     | Monto: ${1} ({2})", orden.OrdenId, orden.Total, orden.Fecha);
            Console.WriteLine("      ------------------------------------------------------");
        }
    }
}
