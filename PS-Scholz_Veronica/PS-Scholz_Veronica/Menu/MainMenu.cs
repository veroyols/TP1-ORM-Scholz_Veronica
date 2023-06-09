﻿using PS_Scholz_Veronica.EnterData;
using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Model;
using PS_Scholz_Veronica.PrintData;
using PS_Scholz_Veronica.Servicios;

namespace PS_Scholz_Veronica.Menu
{
    public class MainMenu : MenuTemplate
    {
        public MainMenu(Service service) : base(service) {}
        override public void ShowMenu()
        {
            Console.WriteLine("                      ------------------");
            Console.WriteLine("                     | MENU DE OPCIONES |");
            Console.WriteLine("                      ------------------");
            Console.WriteLine("             1. Registrar un nuevo Cliente");
            Console.WriteLine("             2. Registrar una Venta de Productos");
            Console.WriteLine("             3. Reportar Ventas del dia");
            Console.WriteLine("             4. Filtrar Productos Vendidos");
            Console.WriteLine("             0. Salir");
            Console.WriteLine("            -------------------------------------");
            Console.Write("\n               Ingrese un numero: ");
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
                    Console.WriteLine("                  ----------------------");
                    Console.WriteLine("                 | 1. Registrar Cliente |");
                    Console.WriteLine("                  ----------------------");
                    int id = _service.RegisterClient();
                    Console.Clear();
                    Console.WriteLine("       ----------------------------------------------------");
                    Console.WriteLine("      |     Se ha registrado en el sistema con el ID: {0}    |", id);
                    Console.WriteLine("       ----------------------------------------------------");
                    return true;
                case 2:
                    Console.WriteLine("                  --------------------");
                    Console.WriteLine("                 | 2. Registrar Venta |");
                    Console.WriteLine("                  --------------------\n");
                    int clientId = EnterId.Cliente(_service);

                    Carrito carro = _service.OpenCart(clientId);
                    
                    decimal total = AddProductToCart.Add(_service, carro);
                    var orden = _service.RegisterOrder(carro,clientId,total);
                    PrintOrder.Print(orden);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 3:
                    Console.WriteLine("                  -------------------");
                    Console.WriteLine("                 | 3. Ventas del dia |");
                    Console.WriteLine("                 |  Fecha " + DateTime.Now.ToShortDateString() + "  |");
                    Console.WriteLine("                  -------------------");
                    ReportSale.ReportOfDay(_service);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 4:
                    Console.WriteLine("                  ------------------------------");
                    Console.WriteLine("                 | 4. Buscar Productos Vendidos |");
                    Console.WriteLine("                  ------------------------------");
                    PrintProducts.PrintDisponibles(_service.GetProducts());
                    Console.Write("       *Ingrese el ID del producto para ver las ventas: ");
                    
                    int productId = int.Parse(Console.ReadLine()); 
                    List<ProductSold> listaDeVentasConProd = _service.GetProductSold(productId);
                    Producto producto = _service.GetProductById(productId);
                    PrintProduct.Print(producto);
                    int unidades = 0;
                    int contadorDeVentas = 0;
                    foreach (var item in listaDeVentasConProd)
                    {
                        unidades += item.amount;
                        contadorDeVentas++;
                        Console.WriteLine("       ----------------------------------------------------");
                        Console.WriteLine("       VENTA {0} - {1}", contadorDeVentas, item.date.ToShortDateString());
                        Console.WriteLine("       CLIENTE: {0} {1} --> {2} unidades", item.clientName, item.clientLastName, item.amount);
                    }
                    Console.WriteLine("       ----------------------------------------------------");
                    Console.WriteLine("       Se vendieron {0} unidades en {1} ventas. \n       Total: ${2}", unidades, listaDeVentasConProd.Count, unidades *producto.Precio);
                    Console.WriteLine("       ----------------------------------------------------");
                    Console.WriteLine("       ----------------------------------------------------");
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                default:
                    Console.Clear();
                    Console.WriteLine("       ----------------------------------------------------");
                    Console.WriteLine("       Ha ingresado un numero incorrecto. " +
                        "\n       Revise el menu e ingrese un valor entre 1 y 4:" +
                        "\n       ----------------------------------------------------");
                    return true;
            }
        }
    }
}