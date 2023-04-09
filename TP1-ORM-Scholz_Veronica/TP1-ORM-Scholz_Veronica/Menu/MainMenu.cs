using TP1_ORM_Scholz_Veronica.Create;

namespace TP1_ORM_Scholz_Veronica.Menu
{
    public class MainMenu : MenuTemplate
    {
        protected readonly AllServices _services;
        protected readonly SubMenuType _subMenuType;

        public MainMenu(AllServices services) {
            _subMenuType = new SubMenuType(services);
            _services = services;
        } 

        public void ShowMenu()
        {
            Console.WriteLine("\n -------------------------------------------------------------");
            Console.WriteLine("                            MENU             ");
            Console.WriteLine(" -------------------------------------------------------------\n");
            Console.WriteLine("             1. Registrar una Comanda");
            Console.WriteLine("             2. Enlistar Comandas");
            Console.WriteLine("\n             0. Salir \n");
            Console.Write("\n               Ingrese un numero: ");
        }
        public override bool ChooseOpt(int opt)
        {
            switch (opt)
            {
                case -1:
                    return true;
                case 0:
                    Console.Clear();
                    Console.WriteLine("\n -------------------------------------------------------------");
                    Console.WriteLine("              GRACIAS POR UTILIZAR ESTE SERVICIO.             ");
                    Console.WriteLine(" -------------------------------------------------------------");
                    return false;
                case 1: //lista de tipos de mercaderia
                    _services.ClearMerchandisePreload();
                    bool viewSubMenuTipo = true;
                    do
                    {
                        _subMenuType.ShowMenu(1);
                        viewSubMenuTipo = _subMenuType.ChooseOpt(_subMenuType.InsertOption(-1));
                    }
                    while (viewSubMenuTipo);
                    Console.Clear();
                    return true;
                case 2:
                    _services.AllComandas();
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                default:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("       Ha ingresado un numero incorrecto. \n" +
                                      "       Revise el menu e ingrese un valor entre 1 y 2: \n");
                    return true;
            }
        }
    }
}
