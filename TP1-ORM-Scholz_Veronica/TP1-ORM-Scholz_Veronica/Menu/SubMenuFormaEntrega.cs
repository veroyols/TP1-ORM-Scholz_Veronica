using TP1_ORM_Scholz_Veronica.Create;

namespace TP1_ORM_Scholz_Veronica.Menu
{
    public class SubMenuFormaEntrega : MenuTemplate
    {
        protected readonly AllServices _services;

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
        override public bool ChooseOpt(int opt)
        {
            switch (opt)
            {
                case -1:
                    return true;
                case 0:
                    Console.WriteLine("                    -------------------");
                    Console.WriteLine("                   | SALIR SIN GUARDAR |");
                    Console.WriteLine("                    -------------------");
                    _services.LimpiarPrecargaMercaderia();
                    Console.ReadKey(true);
                    Console.Clear();
                    return false;
                case 1:
                    Console.WriteLine("                ---------------------------");
                    Console.WriteLine("               | 1. ENVIAR PEDIDO AL SALON |");
                    Console.WriteLine("                ---------------------------");
                    Console.ReadKey(true);
                    Console.Clear();
                    return false;
                case 2:
                    Console.WriteLine("              -------------------------------");
                    Console.WriteLine("             | 2. ENVIAR PEDIDO CON DELIVERY |");
                    Console.WriteLine("              -------------------------------");
                    Console.ReadKey(true);
                    Console.Clear();
                    return false;
                case 3:
                    Console.WriteLine("                  ----------------------");
                    Console.WriteLine("                 | 3. RETIRA PEDIDOS YA |");
                    Console.WriteLine("                  ----------------------");
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
