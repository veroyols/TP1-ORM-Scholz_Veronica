using PS_Scholz_Veronica.Entities;
using System.Collections.Generic;

namespace PS_Scholz_Veronica.PrintData
{
    public class PrintProducts
    {
        public static void PrintDisponibles(List<Producto> lp)
        {
            Console.WriteLine("Productos Disponibles:");
            foreach (Producto p in lp)
                Console.WriteLine("     Id: {0} -> *{1} ({2}): ${3}", p.ProductoId, p.Nombre, p.Marca, p.Precio);
        } 
    }
}