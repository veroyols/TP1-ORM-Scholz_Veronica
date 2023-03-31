﻿
namespace TP1_ORM_Scholz_Veronica.Menu
{
    public class SubMenu_Entrada : MenuTemplate
    {
        public SubMenu_Entrada() { }

        override public void ShowMenu()
        {
            Console.WriteLine("                      -----------------");
            Console.WriteLine("                     | AGREGAR ENTRADA |");
            Console.WriteLine("                      -----------------");
            Console.WriteLine("             1. Berenjenas en Escabeche");
            Console.WriteLine("             2. Porotos en Escabeche");
            Console.WriteLine("             3. Humus de Garbanzos");
            Console.WriteLine("             0. Ninguna");
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
                    Console.WriteLine("\n               ------------------------------");
                    Console.WriteLine("              | Saliendo de SubMenu_Entrada. |");
                    Console.WriteLine("               ------------------------------");
                    return false;
                case 1:
                    Console.WriteLine("                  ----------------------------");
                    Console.WriteLine("                 | 1. Berenjenas en Escabeche |");
                    Console.WriteLine("                  ----------------------------");
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 2:
                    Console.WriteLine("                  -------------------------");
                    Console.WriteLine("                 | 2. Porotos en Escabeche |");
                    Console.WriteLine("                  -------------------------");
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 3:
                    Console.WriteLine("                  -----------------------");
                    Console.WriteLine("                 | 3. Humus de Garbanzos |");
                    Console.WriteLine("                  -----------------------");
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                default:
                    Console.Clear();
                    Console.WriteLine("       ------------------------------------------------");
                    Console.WriteLine("      | Ha ingresado un numero incorrecto.             |" +
                                    "\n      | Revise el menu e ingrese un valor entre 1 y 3. |" +
                                    "\n       ------------------------------------------------");
                    return true;
            }
        }
    }
}