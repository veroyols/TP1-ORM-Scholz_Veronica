
using TP1_ORM_Scholz_Veronica.Create;

namespace TP1_ORM_Scholz_Veronica.Menu
{
    public class SubMenuFiltro : MenuTemplate
    {
        protected readonly AllServices _services;

        public SubMenuFiltro(AllServices services) {
            _services = services;

        }
        public override void ShowMenu() { }
        public void ShowMenu(int op)
        {
            Console.WriteLine("Consulta al _services.GetMercaderiasPorTipo();");
            Console.WriteLine("                      --------------------");
            Console.WriteLine("                     | Agregar Mercaderia |");
            Console.WriteLine("                      --------------------");
            foreach (var item in _services.GetMercaderiasPorTipo(op))
            {
                Console.WriteLine("             {0}. {1} (${2})", item.MercaderiaId, item.Nombre, item.Precio);
            }
            Console.WriteLine("             0. Volver");
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
                    Console.WriteLine("\n                     ---------------------------------");
                    Console.WriteLine("                     | Saliendo de Agregar Mercaderia. |");
                    Console.WriteLine("                      ---------------------------------");
                    return false;
                case 1:
                    Console.WriteLine("CASE 1-------------------");
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                default:
                    Console.Clear();
                    Console.WriteLine("       -------------------------------------------------");
                    Console.WriteLine("      | Ha ingresado un numero incorrecto.              |" +
                                    "\n      | Revise el menu e ingrese un valor entre 1 y 10. |" +
                                    "\n       -------------------------------------------------");
                    return true;
            }
        }
    }
}
