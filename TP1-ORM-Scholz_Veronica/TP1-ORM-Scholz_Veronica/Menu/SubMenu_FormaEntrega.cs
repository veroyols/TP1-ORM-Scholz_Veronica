
namespace TP1_ORM_Scholz_Veronica.Menu
{
    public class SubMenu_FormaEntrega : MenuTemplate
    {
        public SubMenu_FormaEntrega() { }

        override public void ShowMenu()
        {
            Console.WriteLine("                -----------------------------");
            Console.WriteLine("               | SELECCIONE FORMA DE ENTREGA |");
            Console.WriteLine("                -----------------------------");
            Console.WriteLine("             1. Salon");
            Console.WriteLine("             2. Delivery");
            Console.WriteLine("             3. PedidosYa");
            Console.WriteLine("            -------------------------------------");
            Console.Write("\n               Ingrese un numero: ");
        }
        override public bool ChooseOpt(int opt)
        {
            switch (opt)
            {
                case -1:
                    return true;
                case 1:
                    Console.WriteLine("                  ----------");
                    Console.WriteLine("                 | 1. SALON |");
                    Console.WriteLine("                  ----------");
                    Console.ReadKey(true);
                    Console.Clear();
                    return false;
                case 2:
                    Console.WriteLine("                  -------------");
                    Console.WriteLine("                 | 2. DELIVERY |");
                    Console.WriteLine("                  -------------");
                    Console.ReadKey(true);
                    Console.Clear();
                    return false;
                case 3:
                    Console.WriteLine("                  ---------------");
                    Console.WriteLine("                 | 3. PEDIDOS YA |");
                    Console.WriteLine("                  ---------------");
                    Console.ReadKey(true);
                    Console.Clear();
                    return false;
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
