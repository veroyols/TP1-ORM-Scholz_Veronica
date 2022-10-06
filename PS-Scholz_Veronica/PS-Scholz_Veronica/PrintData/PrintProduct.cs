using PS_Scholz_Veronica.Entities;

namespace PS_Scholz_Veronica.PrintData
{
    public class PrintProduct
    {
        public static void Print(Producto p)
        {
            Console.WriteLine("       ----------------------------------------------------\n" +
                "       Producto ID: {0}                     Precio: ${5}\n" +
                "        * {1} {2} (Codigo: {3}) \n" +
                "       Descripcion: {4} \n" +
                "       ", p.ProductoId, p.Nombre, p.Marca, p.Codigo, p.Descripcion, p.Precio);
        }
    }
}
