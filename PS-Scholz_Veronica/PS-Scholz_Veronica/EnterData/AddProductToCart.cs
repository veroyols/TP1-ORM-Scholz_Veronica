using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.PrintData;
using PS_Scholz_Veronica.Servicios;

namespace PS_Scholz_Veronica.EnterData
{
    public class AddProductToCart
    {
        public static decimal Add(Service _service, Carrito carrito) 
        {
            string op = "1";
            decimal total = 0;
            while (op == "1")
            {
                PrintProducts.PrintDisponibles(_service.GetProducts());
                Console.WriteLine("\n       *Ingrese el ID del producto que desea comprar: ");
                int productId = int.Parse(Console.ReadLine()); // TODO: validar que exista
                Console.WriteLine("\n       *Ingrese la cantidad: ");
                int cdad = int.Parse(Console.ReadLine()); // TODO: validar que exista
                var cp = new CarritoProducto(carrito.CarritoId, productId, cdad);
                //crear o updatear el carrito
                _service.ValidarCarritoProducto(cp, cdad);
                total += _service.GetPreciobyProductId(productId) * cdad;
                Console.WriteLine("     ------------------------------------------------- ");
                Console.WriteLine("    | Ingrese 1 para agregar mas productos al carrito:|");
                Console.WriteLine("    |   (cualquier tecla para Finalizar la compra)    |");
                Console.WriteLine("     ------------------------------------------------- ");
                op = Console.ReadLine();
                Console.Clear();
            }
            _service.EndSale(carrito);
            Console.WriteLine("          -------------------------------------------");
            Console.WriteLine("         | Finalizo la carga de productos al carrito |");
            Console.WriteLine("          -------------------------------------------");
            return total;
        }
    }
}