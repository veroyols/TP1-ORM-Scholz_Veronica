using TP1_ORM_Scholz_Veronica.Create;

namespace TP1_ORM_Scholz_Veronica.Menu
{
    public class SubMenuFormaEntrega : MenuTemplate
    {
        protected readonly AllServices _services;
        public int formaEntrega;

        public SubMenuFormaEntrega(AllServices services)
        {
            _services = services;
        }

        public void ShowMenu() //logica de bd
        {
            Console.WriteLine("                -----------------------------");
            Console.WriteLine("               | SELECCIONE FORMA DE ENTREGA |");
            Console.WriteLine("                -----------------------------");
            Console.WriteLine("             1. Salon");
            Console.WriteLine("             2. Delivery");
            Console.WriteLine("             3. PedidosYa");
            Console.WriteLine("             0. Descartar Pedido");
            Console.WriteLine("            -------------------------------------");
            Console.Write("\n               Ingrese un numero: ");
        }
        public bool ChooseOpt(int opt)
        {
            switch (opt)
            {
                case -1:
                    return true;
                case 0:
                    Console.WriteLine("                     -----------------");
                    Console.WriteLine("                    | CANCELAR PEDIDO |");
                    Console.WriteLine("                     -----------------");
                    _services.LimpiarPrecargaMercaderia();
                    Console.ReadKey(true);
                    Console.Clear();
                    return false;
                case 1:
                    Console.WriteLine("                ---------------------------");
                    Console.WriteLine("               | 1. ENVIAR PEDIDO AL SALON |");
                    Console.WriteLine("                ---------------------------");
                    formaEntrega = 1;
                    Console.ReadKey(true);
                    Console.Clear();
                    return false;
                case 2:
                    Console.WriteLine("              -------------------------------");
                    Console.WriteLine("             | 2. ENVIAR PEDIDO CON DELIVERY |");
                    Console.WriteLine("              -------------------------------");
                    formaEntrega = 2;
                    Console.ReadKey(true);
                    Console.Clear();
                    return false;
                case 3:
                    Console.WriteLine("                  ----------------------");
                    Console.WriteLine("                 | 3. RETIRA PEDIDOS YA |");
                    Console.WriteLine("                  ----------------------");
                    formaEntrega = 3;
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
