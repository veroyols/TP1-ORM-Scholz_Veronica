using PS_Scholz_Veronica.EnterData;
using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.PrintData;
using PS_Scholz_Veronica.Servicios;

namespace PS_Scholz_Veronica.Menu
{
    public class MainMenu : MenuTemplate
    {
        public MainMenu(Service service) : base(service) {}
        override public void ShowMenu()
        {
            Console.WriteLine("          ------------------");
            Console.WriteLine("         | MENU DE OPCIONES |");
            Console.WriteLine("          ------------------");
            Console.WriteLine("     1. Registrar un nuevo Cliente");
            Console.WriteLine("     2. Registrar una Venta de Productos");
            Console.WriteLine("     3. Reportar Ventas del dia");
            Console.WriteLine("     4. Filtrar Productos Vendidos");
            Console.WriteLine("     0. Salir");
            Console.Write("\nIngrese un numero: ");
        }
        override public bool ChooseOpt(int opt)
        {
            switch (opt)
            {
                case -1:
                    return true;
                case 0:
                    Console.Clear();
                    Console.WriteLine("\n              -------------------------------------");
                    Console.WriteLine("              | Gracias por utilizar este servicio. |");
                    Console.WriteLine("               -------------------------------------");
                    return false;
                case 1:
                    Console.WriteLine("               ----------------------");
                    Console.WriteLine("              | 1. Registrar Cliente |");
                    Console.WriteLine("               ----------------------");
                    int id = _service.RegisterCliente();
                    Console.Clear();
                    Console.WriteLine("Se ha registrado en el sistema con el ID: {0}", id);
                    return true;
                case 2:
                    Console.WriteLine("               --------------------");
                    Console.WriteLine("              | 2. Registrar Venta |");
                    Console.WriteLine("               --------------------");
                    Console.WriteLine("\n       *Ingrese su Cliente ID: ");
                    int clientId = int.Parse(Console.ReadLine()); // TODO: validar que exista
                    Carrito carro = _service.OpenCart(clientId);
                    decimal total = AddProductToCart.Add(_service, carro);
                    var orden = _service.RegisterOrder(carro,clientId,total);
                    PrintOrder.Print(orden);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 3:
                    Console.WriteLine("                -------------------");
                    Console.WriteLine("               | 3. Ventas del dia |");
                    Console.WriteLine("               |  Fecha " + DateTime.Now.ToShortDateString() + "  |");
                    Console.WriteLine("                -------------------");
                    ReportSale.ReportOfDay(_service);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 4:
                    Console.WriteLine("               ------------------------------");
                    Console.WriteLine("              | 4. Buscar Productos Vendidos |");
                    Console.WriteLine("               ------------------------------");
                    PrintProducts.PrintDisponibles(_service.GetProducts());
                    Console.WriteLine("         *Ingrese el ID del producto para ver las ventas: ");
                    int productId = int.Parse(Console.ReadLine()); // TODO: validar que exista
                    int cdad = _service.GetProductSaleToday(productId);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                default:
                    Console.Clear();
                    Console.WriteLine("Ha ingresado un numero incorrecto. " +
                        "\nRevise el menu e ingrese un valor entre 1 y 4:" +
                        "\n----------------------------------------------");
                    return true;
            }
        }
    }
}