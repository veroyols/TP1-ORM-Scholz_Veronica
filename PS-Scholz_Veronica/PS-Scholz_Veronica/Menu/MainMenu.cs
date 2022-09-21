using PS_Scholz_Veronica._Command;
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
        private readonly Service _service;
        public MainMenu(Service service)
        {
            _service = service;
        }
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
                    var cli = ClientData.EnterClientData();
                    _service.commandClient.InsertClient(cli);
                    int id = _service.queryClient.GetIdbyClient(cli);
                    Console.WriteLine("Se ha registrado en el sistema con el Id {0}",id);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 2:
                    var submenu = SubMenu.getInstance();
                    bool m2 = true;
                    while (m2)
                    {
                        submenu.ShowMenu();                        
                        m2 = submenu.ChooseOpt(submenu.InsertOption(-1));
                    }
                    Console.Clear();
                    return true;
                case 3:
                    bool m3 = true;
                    while (m3)
                    {
                        Console.WriteLine("      --------------------");
                        Console.WriteLine("     | 3. Reportar Ventas |");
                        Console.WriteLine("      --------------------");
                        Console.ReadKey(true);
                        m3 = false;
                        //m3 = Menu1();
                    }
                    Console.Clear();
                    return true;
                case 4:
                    Console.WriteLine("      --------------------------");
                    Console.WriteLine("     | 4. Productos disponibles |");
                    Console.WriteLine("      --------------------------");
                    Console.WriteLine("Total: {0} productos. \nDetalle:",_service.queryProduct.CountAll());
                    List<Producto> lp = _service.queryProduct.GetAll();
                    foreach (Producto p in lp)
                        Console.WriteLine("     Id: {0} -> *{1} ({2}): ${3}",p.ProductoId,p.Nombre,p.Marca,p.Precio);
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
