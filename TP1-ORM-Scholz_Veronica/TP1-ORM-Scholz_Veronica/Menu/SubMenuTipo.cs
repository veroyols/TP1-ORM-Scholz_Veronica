using TP1_ORM_Scholz_Veronica.Create;

namespace TP1_ORM_Scholz_Veronica.Menu
{
    public class SubMenuTipo : MenuTemplate
    {
        protected readonly AllServices _services;
        protected readonly SubMenuFiltro _subMenuFiltro;
        protected readonly SubMenu_FormaEntrega _subMenuFormaEntrega;

        public SubMenuTipo(AllServices services) {
            _services = services;
            _subMenuFiltro = new SubMenuFiltro(services);
            _subMenuFormaEntrega = new SubMenu_FormaEntrega();
        }

        override public void ShowMenu()
        {
            Console.WriteLine("Consulta al _services.GetAllTiposMercaderia();");
            Console.WriteLine("                      ---------------------");
            Console.WriteLine("                     |  REGISTRAR COMANDA  |");
            Console.WriteLine("                      ---------------------");
            foreach (var item in _services.GetAllTiposMercaderia())
            {
                Console.WriteLine("             {0}. {1}", item.TipoMercaderiaId, item.Descripcion);
            }
            Console.WriteLine("\n                      ---------------------");
            Console.WriteLine("                     | 0. GUARDAR COMANDA. |");
            Console.WriteLine("                      ---------------------");
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
                    Console.WriteLine("\n                      -------------------");
                    Console.WriteLine("                     |  GUARDAR COMANDA. |");
                    Console.WriteLine("                      -------------------");
                    //Ingresar forma de entrega
                    bool viewSubMenuFormaEntrega = true;
                    do
                    {
                        _subMenuFormaEntrega.ShowMenu();
                        viewSubMenuFormaEntrega = _subMenuFormaEntrega.ChooseOpt(_subMenuFormaEntrega.InsertOption(-1));
                    }
                    while (viewSubMenuFormaEntrega);
                    Console.Clear();
                    return false;
                case 1:
                    Console.WriteLine("lista de mercaderias del tipo 1"); 
                    bool viewSubMenuFiltro = true;
                    do
                    {
                        _subMenuFiltro.ShowMenu(1);
                        viewSubMenuFiltro = _subMenuFiltro.ChooseOpt(_subMenuFiltro.InsertOption(-1));
                    }
                    while (viewSubMenuFiltro);
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
