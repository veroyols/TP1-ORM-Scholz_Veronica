using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Menu
{
    public class MainMenu
    {
        public void ShowMenu()
        {
            Console.WriteLine("     MENU DE OPCIONES");
            Console.WriteLine("1. Registrar un nuevo Cliente");
            Console.WriteLine("2. Registrar una Venta de Productos");
            Console.WriteLine("3. Reportar Ventas del dia");
            Console.WriteLine("4. Buscar Productos Disponibles");
            Console.WriteLine("5. Salir");
            Console.Write("Ingrese un numero: ");
            return;
        }
        public int InsertOption(int op)
        {
            try
            {
                op = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            catch (FormatException e)
            {
                Console.Write(e.Message + " \nPress any key to continue . . . ");
                Console.ReadKey(true);
            }
            catch (OverflowException e)
            {
                Console.Write(e.Message + " \nPress any key to continue . . . ");
                Console.ReadKey(true);
            }
            catch (Exception e)
            {
                Console.Write(e.Message + " \nPress any key to continue . . . ");
                Console.ReadKey(true);
            }
            return op;  
        }
        public bool ChooseOpt(int opt)
        {
            switch (opt)
            {
                case 0:
                    //Console.WriteLine("Ha ingresado cero. Revise el menu de opciones: ");
                    return true;
                case 1:
                    bool m1 = true;
                    while (m1)
                    {
                        Console.WriteLine("1. Registrar Cliente");
                        Console.WriteLine("--------------------");
                        Console.ReadKey(true);
                        m1 = false;
                        //m1 = Menu1();
                    }
                    Console.Clear();
                    return true;
                case 2:
                    bool m2 = true;
                    while (m2)
                    {
                        Console.WriteLine("2. Registrar Ventas");
                        Console.WriteLine("--------------------");
                        Console.ReadKey(true);
                        m2 = false;
                        //m2 = Menu1();
                    }
                    Console.Clear();
                    return true;
                case 3:
                    bool m3 = true;
                    while (m3)
                    {
                        Console.WriteLine("3. Reportar Ventas");
                        Console.WriteLine("--------------------");
                        Console.ReadKey(true);
                        m3 = false;
                        //m3 = Menu1();
                    }
                    Console.Clear();
                    return true;
                case 4:
                    bool m4 = true;
                    while (m4)
                    {
                        Console.WriteLine("4. Buscar Producto");
                        Console.WriteLine("--------------------");
                        Console.ReadKey(true);
                        m4 = false;
                        //m4 = Menu1();
                    }
                    Console.Clear();
                    return true;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Gracias por utilizar este servicio.");
                    Console.WriteLine("-----------------------------------");
                    return false;
                default:
                    Console.Clear();
                    Console.WriteLine("Ha ingresado un numero incorrecto. " +
                        "\nRevise el menu e ingrese un valor entre 1 y 4:");
                    return true;
            }
        }
    }
}
