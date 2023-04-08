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

        public void ShowMenu() 
        {
            Console.WriteLine(" -------------------------------------------------------------");
            Console.WriteLine("                SELECCIONE FORMA DE ENTREGA");
            Console.WriteLine(" -------------------------------------------------------------\n");
            Console.WriteLine("             1. Salon");
            Console.WriteLine("             2. Delivery");
            Console.WriteLine("             3. PedidosYa");
            Console.WriteLine("\n             0. Descartar Pedido \n");
            Console.Write("\n               Ingrese un numero: ");
        }
        public override bool ChooseOpt(int opt)
        {
            if(opt > 0 && opt <= 3)
            {
                formaEntrega = opt;
                return false;
            }
            switch (opt)
            {
                case -1:
                    return true;
                case 0:
                    Console.WriteLine(" -------------------------------------------------------------");
                    Console.WriteLine("                      CANCELANDO PEDIDO");
                    Console.WriteLine(" -------------------------------------------------------------\n");
                    _services.LimpiarPrecargaMercaderia();
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
