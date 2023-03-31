
namespace TP1_ORM_Scholz_Veronica.Menu
{
    public class SubMenu_Pizzas : MenuTemplate
    {
        public SubMenu_Pizzas() { }

        override public void ShowMenu()
        {
            Console.WriteLine("                      ----------------");
            Console.WriteLine("                     | AGREGAR PIZZAS |");
            Console.WriteLine("                      ----------------");
            Console.WriteLine("             1. Muzzarella");
            Console.WriteLine("             2. Napolitana");
            Console.WriteLine("             3. Roquefort");
            Console.WriteLine("             4. Fugazzeta Rellena");
            Console.WriteLine("             0. Volver");
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
                    Console.WriteLine("\n               -----------------------------");
                    Console.WriteLine("              | Saliendo de SubMenu_Pizzas. |");
                    Console.WriteLine("               -----------------------------");
                    return false;
                case 1:
                    Console.WriteLine("                  -------------");
                    Console.WriteLine("                 | 1. Omelette |");
                    Console.WriteLine("                  -------------");
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 2:
                    Console.WriteLine("                  -----------------");
                    Console.WriteLine("                 | 2. Papas Fritas |");
                    Console.WriteLine("                  -----------------");
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 3:
                    Console.WriteLine("                  ------------------------");
                    Console.WriteLine("                 | 3. Milanesa Napolitana |");
                    Console.WriteLine("                  ------------------------");
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 4:
                    Console.WriteLine("                  ------------------------------");
                    Console.WriteLine("                 | 4. Empanada de jamon y queso |");
                    Console.WriteLine("                  ------------------------------");
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                default:
                    Console.Clear();
                    Console.WriteLine("       ------------------------------------------------");
                    Console.WriteLine("      | Ha ingresado un numero incorrecto.             |" +
                                    "\n      | Revise el menu e ingrese un valor entre 1 y 4. |" +
                                    "\n       ------------------------------------------------");
                    return true;
            }
        }
    }
}
