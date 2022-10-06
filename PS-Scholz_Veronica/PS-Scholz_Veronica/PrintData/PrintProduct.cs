using PS_Scholz_Veronica.Entities;

namespace PS_Scholz_Veronica.PrintData
{
    public class PrintProduct
    {
        public static void Print(Producto p)
        {
            Console.WriteLine("Producto ID: {0} \n" +
                " * {1} {2} (Codigo: {3}) - Precio: ${4}\n" +
                "   Descripcion: {5}", p.ProductoId, p.Nombre, p.Marca, p.Codigo, p.Precio, p.Descripcion);
        }
    }
}
