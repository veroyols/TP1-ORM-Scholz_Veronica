using PS_Scholz_Veronica._Command;
using PS_Scholz_Veronica._Query;
using PS_Scholz_Veronica.EnterData;
using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Persistence;
using PS_Scholz_Veronica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("     4. Productos Disponibles");
            Console.WriteLine("     0. Salir");
            Console.Write("\nIngrese un numero: ");
            return;
        }
        override public bool ChooseOpt(int opt)
        {
            switch (opt)
            {
                case -1:
                    return true;
                case 0:
                    Console.Clear();
                    Console.WriteLine("\n      -------------------------------------");
                    Console.WriteLine("     | Gracias por utilizar este servicio. |");
                    Console.WriteLine("      -------------------------------------");
                    return false;
                case 1:
                    Console.WriteLine("      ----------------------");
                    Console.WriteLine("     | 1. Registrar Cliente |");
                    Console.WriteLine("      ----------------------");
                    _service.RegisterCliente();
                    return true;
                case 2:
                    Console.WriteLine("      --------------------");
                    Console.WriteLine("     | 2. Registrar Venta |");
                    Console.WriteLine("      --------------------");
                    
                    Console.WriteLine("Ingrese su ID de cliente: ");
                    int clientId = _service.queryClient.EnterId(); //pide y busca
                    Carrito carro = _service.OpenCart(clientId);
                    decimal total = _service.AddProductosToCart(carro);
                    var o = _service.RegisterOrder(carro,clientId,total);
                    _service.queryOrder.Print(o);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 3:
                    Console.WriteLine("      --------------------");
                    Console.WriteLine("     | 3. Reportar Ventas |");
                    Console.WriteLine("      --------------------");

                    List<Orden> l = _service.queryOrder.GetAll(); //lista de ordenes
                    foreach (var item in l)
                    {
                        _service.queryOrder.Print(item);
                    }

                    var carritos = _service.queryCP.GetAllGuid();
                    foreach (var carritoId in carritos)
                    {
                        Console.WriteLine("Carrito Id: {0}", carritoId);
                        var list = _service.queryCP.GetProductoByCarrito(carritoId);
                        foreach (var item in list)
                        {
                            _service.queryProduct.Print(item);
                        }
                    }
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 4:
                    Console.WriteLine("      --------------------------");
                    Console.WriteLine("     | 4. Productos disponibles |");
                    Console.WriteLine("      --------------------------");

                    _service.queryProduct.PrintAll();
                                       
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
