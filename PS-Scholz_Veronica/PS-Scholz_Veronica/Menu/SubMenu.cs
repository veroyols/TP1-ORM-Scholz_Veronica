using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Menu
{
    public class SubMenu : MenuTemplate
    {
        private static SubMenu unico = null;

        public SubMenu(Service service) : base(service)
        {
        }
        public static SubMenu getInstance(Service service)
        {
            if (unico == null)
            {
                unico = new SubMenu(service);
            }
            return unico;
        }
        public override void ShowMenu()
        {
            Console.WriteLine("      --------------------");
            Console.WriteLine("     | 2. Registrar Venta |");
            Console.WriteLine("      --------------------");
            
            Console.WriteLine("Ingrese su ID de cliente: ");
            int clientId = _service.queryClient.EnterId();
            
            Carrito carro = new Carrito(clientId);
            _service.commandCart.InsertCart(carro);
            
            _service.queryProduct.PrintAll();
            Console.WriteLine("Ingrese el ID del producto que desea comprar: ");
            int productId = _service.queryProduct.EnterId();

            Guid carritoId = _service.queryCart.GetGuidbyCart(carro);
            _service.commandCP.InsertCP(new CarritoProducto(carritoId, productId, 1));

            Console.Write("Se ha agregado al carrito: ");
            _service.queryProduct.Print(productId);

            Console.WriteLine("Desea agregar producots al carrito? " +
                "\n1. Si" +
                "\n2. No");
            string rta = Console.ReadLine();


            Console.WriteLine("     0. Volver al menu anterior");
            Console.Write("Ingrese un numero: ");
            return;
        }
        public override bool ChooseOpt(int opt)
        {
            switch (opt)
            {
                case -1:
                    return true;
                case 0:
                    return false;
                case 1:
                    bool m1 = true;
                    while (m1)
                    {
                        Console.Clear();
                        Console.WriteLine("      ---------------------------------");
                        Console.WriteLine("     | 1. Agregar productos al carrito |");
                        Console.WriteLine("      ---------------------------------");
                        Console.ReadKey(true);
                        m1 = false;
                    }
                    return true;
                case 3:
                    return true;
                case 4:
                    return true;
                default:
                    Console.Clear();
                    Console.WriteLine("Revise el menu e ingrese un valor entre 1 y 4:" +
                        "\n----------------------------------------------");
                    return true;
            }
        }
    }
}