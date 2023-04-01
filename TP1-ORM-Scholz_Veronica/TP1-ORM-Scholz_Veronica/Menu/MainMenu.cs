using TP1_ORM_Scholz_Veronica.Create;

namespace TP1_ORM_Scholz_Veronica.Menu
{
    public class MainMenu : MenuTemplate
    {
        protected readonly AllServices _services;
        protected readonly SubMenu _subMenu;

        public MainMenu(AllServices services) {
            _subMenu = new SubMenu(services);
            _services = services;
        } 

        override public void ShowMenu()
        {
            Console.WriteLine("                      ------------------");
            Console.WriteLine("                     | MENU DE OPCIONES |");
            Console.WriteLine("                      ------------------");
            Console.WriteLine("             1. Registrar una Comanda");
            Console.WriteLine("             2. Enlistar Comandas");
            Console.WriteLine("             0. Salir");
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
                    Console.WriteLine("\n               -------------------------------------");
                    Console.WriteLine("              | GRACIAS POR UTILIZAR ESTE SERVICIO. |");
                    Console.WriteLine("               -------------------------------------");
                    return false;
                case 1:
                    bool viewSubMenu = true;
                    do
                    {
                        _subMenu.ShowMenu();
                        viewSubMenu = _subMenu.ChooseOpt(_subMenu.InsertOption(-1));
                    }
                    while (viewSubMenu);
                    Console.Clear();
                    return true;
                case 2:
                    Console.WriteLine("                  -----------------------");
                    Console.WriteLine("                 | 2. ENLISTAR COMANDAS |");
                    Console.WriteLine("                 |    Fecha " + DateTime.Now.ToShortDateString() + "   |");
                    Console.WriteLine("                  -----------------------\n");
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                default:
                    Console.Clear();
                    Console.WriteLine("       ----------------------------------------------------");
                    Console.WriteLine("       Ha ingresado un numero incorrecto. " +
                        "\n       Revise el menu e ingrese un valor entre 1 y 2:" +
                        "\n       ----------------------------------------------------");
                    return true;
            }
        }
    }
}
