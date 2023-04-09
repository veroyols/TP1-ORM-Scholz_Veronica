using TP1_ORM_Scholz_Veronica.Create;

namespace TP1_ORM_Scholz_Veronica.Menu
{
    public class SubMenuType : MenuTemplate
    {
        protected readonly AllServices _services;
        protected readonly SubMenuFilter _subMenuFilter;
        protected readonly SubMenuMethod _subMenuMethod;
        protected int cdadDeTipos;

        public SubMenuType(AllServices services) {
            _services = services;
            _subMenuFilter = new SubMenuFilter(services);
            _subMenuMethod = new SubMenuMethod(services);
            cdadDeTipos = 0;
        }

        public void ShowMenu(int op)
        {
            Console.WriteLine(" -------------------------------------------------------------");
            Console.WriteLine("                   1. REGISTRAR COMANDA");
            Console.WriteLine(" -------------------------------------------------------------\n");
            cdadDeTipos = _services.GetAmountOfType(op).Result;
            //lista de TipoMercaderia
            foreach (var item in _services.GetAllTipoMercaderia().Result)
            {
                Console.WriteLine("             {0}. {1}", item.TipoMercaderiaId, item.Descripcion);
            }
            Console.WriteLine("\n             0. Finalizar");
            Console.Write("\n                   Ingrese un numero: ");
        }
        public override bool ChooseOpt(int type)
        {
            if (0 < type && type <= cdadDeTipos)
            {
                bool viewSubMenuFilter = true;
                do
                {
                    _subMenuFilter.ShowMenu(type);
                    viewSubMenuFilter = _subMenuFilter.ChooseOpt(_subMenuFilter.InsertOption(-1));
                }
                while (viewSubMenuFilter);
                Console.Clear();
                return true;
            }
            else
            {
                switch (type)
                {
                    case -1:
                        return true;
                    case 0:
                        Console.Clear();
                        //Ingresar forma de entrega
                        bool viewSubMenuMethod = true;
                        do
                        {
                            _subMenuMethod.ShowMenu();
                            viewSubMenuMethod = _subMenuMethod.ChooseOpt(_subMenuMethod.InsertOption(-1));
                        }
                        while (viewSubMenuMethod);
                        _services.SaveOrder(_subMenuMethod.method);
                        Console.Clear();
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
