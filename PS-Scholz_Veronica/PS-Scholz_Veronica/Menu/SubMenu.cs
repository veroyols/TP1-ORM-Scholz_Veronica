using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Menu
{
    public class SubMenu : MenuTemplate
    {
        private static SubMenu unico = null;
        private SubMenu() { }
        public static SubMenu getInstance()
        {
            if (unico == null)
            {
                unico = new SubMenu();
            }
            return unico;
        }
        public override void ShowMenu()
        {
            Console.WriteLine("      -------------------");
            Console.WriteLine("     | 2. Menu de Ventas |");
            Console.WriteLine("      -------------------");
            Console.WriteLine("     1. Ingresar ID de cliente");
            Console.WriteLine("     2. ");
            Console.WriteLine("     3. ");
            Console.WriteLine("     4. ");
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