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

                int productId = EnterId.Producto(_service);
                int cdad = EnterId.Cantidad(_service);

                var cp = new CarritoProducto(carrito.CarritoId, productId, cdad);
                //crear o updatear el carrito
                _service.ValidarCarritoProducto(cp, cdad);
                total += _service.GetPreciobyProductId(productId) * cdad;
                Console.WriteLine("         ------------------------------------------------- ");
                Console.WriteLine("        | Ingrese 1 para agregar mas productos al carrito:|");
                Console.WriteLine("        |   (cualquier tecla para Finalizar la compra)    |");
                Console.WriteLine("         ------------------------------------------------- ");
                op = Console.ReadLine();
                Console.Clear();
            }
            _service.EndSale(carrito);
            Console.WriteLine("              -------------------------------------------");
            Console.WriteLine("             | Finalizo la carga de productos al carrito |");
            Console.WriteLine("              -------------------------------------------");
            return total;
        }
    }
}