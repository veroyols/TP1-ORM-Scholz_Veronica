using TP1_ORM_Scholz_Veronica.Create;

namespace TP1_ORM_Scholz_Veronica.Menu
{
    public class SubMenuFiltro : MenuTemplate
    {
        protected readonly AllServices _services;
        protected int platosPorTipo;
        protected int idMercaderia;

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
            foreach (var item in _services.GetMercaderiasPorTipo(op))
            {
                Console.WriteLine("             {0}. {1} (${2})", item.MercaderiaId, item.Nombre, item.Precio);
                idMercaderia = item.MercaderiaId;
            }
            Console.WriteLine("             0. Volver");
            Console.Write("\n               Ingrese un numero: ");
        }
        override public bool ChooseOpt(int idMercaderiaSeleccionada)
        {
            if (idMercaderia-platosPorTipo < idMercaderiaSeleccionada && idMercaderiaSeleccionada <= idMercaderia)
            {
                //AGREGAR idMercaderiaSeleccionada a una lista con cantidad
                _services.PrecargaMercaderia(idMercaderiaSeleccionada);
                Console.ReadKey(true);
                Console.Clear();
                return true;
            }
            else
            {
                switch (idMercaderiaSeleccionada)
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
