using TP1_ORM_Scholz_Veronica.Create;

namespace TP1_ORM_Scholz_Veronica.Menu
{
    public class SubMenuFiltro : MenuTemplate
    {
        protected readonly AllServices _services;
        protected int platosPorTipo;

        public SubMenuFiltro(AllServices services) {
            _services = services;
            platosPorTipo = 0;

        }
        public void ShowMenu(int op)
        {
            Console.WriteLine("                      --------------------");
            Console.WriteLine("                     | Agregar Mercaderia |");
            Console.WriteLine("                      --------------------");
            platosPorTipo = _services.GetCantidadMercaderiasPorTipo(op);
            //lista de Mercaderia por TipoMercaderia
            int i = 1;
            foreach (var item in _services.GetMercaderiasPorTipo(op))
            {
                Console.WriteLine("             {0}. {1} (${2})", i, item.Nombre, item.Precio);
                i++;
            }
            Console.WriteLine("             0. Volver");
            Console.Write("\n               Ingrese un numero: ");
        }
        override public bool ChooseOpt(int opt)
        {
            if (0 < opt && opt < platosPorTipo)
            {
                //AGREGAR opt a una lista de mercaderias seleccionadas
                Console.WriteLine("Entra en el if: opt = {0}", opt);
                Console.ReadKey(true);
                Console.Clear();
                return true;
            }
            else
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
}
