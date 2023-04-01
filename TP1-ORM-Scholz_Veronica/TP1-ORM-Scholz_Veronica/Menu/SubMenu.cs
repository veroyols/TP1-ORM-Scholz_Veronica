using TP1_ORM_Scholz_Veronica.Create;

namespace TP1_ORM_Scholz_Veronica.Menu
{
    public class SubMenu : MenuTemplate
    {
        protected readonly AllServices _services;

        protected readonly SubMenu_Entrada _subMenuEntrada;
        protected readonly SubMenu_Minuta _subMenuMinuta;
        protected readonly SubMenu_Pastas _subMenuPastas;
        protected readonly SubMenu_Parrilla _subMenuParrilla;
        protected readonly SubMenu_Pizzas _subMenuPizzas;
        protected readonly SubMenu_Sandwich _subMenuSandwich;
        protected readonly SubMenu_Ensalada _subMenuEnsalada;
        protected readonly SubMenu_Bebidas _subMenuBebidas;
        protected readonly SubMenu_Cerveza _subMenuCerveza;
        protected readonly SubMenu_Postres _subMenuPostres;
        protected readonly SubMenu_FormaEntrega _subMenuFormaEntrega;

        public SubMenu(AllServices services) {
            _services = services;

            _subMenuEntrada = new SubMenu_Entrada();
            _subMenuMinuta = new SubMenu_Minuta();
            _subMenuPastas = new SubMenu_Pastas();
            _subMenuParrilla = new SubMenu_Parrilla();
            _subMenuPizzas = new SubMenu_Pizzas ();
            _subMenuSandwich = new SubMenu_Sandwich();
            _subMenuEnsalada = new SubMenu_Ensalada();
            _subMenuBebidas = new SubMenu_Bebidas();
            _subMenuCerveza = new SubMenu_Cerveza();
            _subMenuPostres = new SubMenu_Postres();
            _subMenuFormaEntrega =  new SubMenu_FormaEntrega();
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
                    bool viewSubMenuFormaEntrega = true;
                    do
                    {
                        _subMenuFormaEntrega.ShowMenu();
                        viewSubMenuFormaEntrega = _subMenuFormaEntrega.ChooseOpt(_subMenuFormaEntrega.InsertOption(-1));
                    }
                    while (viewSubMenuFormaEntrega);
                    Console.Clear();
                    return false;
                case 1: //entrada
                    bool viewSubMenuEntrada = true;
                    do
                    {
                        _subMenuEntrada.ShowMenu();
                        viewSubMenuEntrada = _subMenuEntrada.ChooseOpt(_subMenuEntrada.InsertOption(-1));
                    }
                    while (viewSubMenuEntrada);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 2: //minutas
                    bool viewSubMenuMinuta = true;
                    do
                    {
                        _subMenuMinuta.ShowMenu();
                        viewSubMenuMinuta = _subMenuMinuta.ChooseOpt(_subMenuMinuta.InsertOption(-1));
                    }
                    while (viewSubMenuMinuta);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 3: //pastas
                    bool viewSubMenuPastas = true;
                    do
                    {
                        _subMenuPastas.ShowMenu();
                        viewSubMenuPastas = _subMenuPastas.ChooseOpt(_subMenuPastas.InsertOption(-1));
                    }
                    while (viewSubMenuPastas);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 4: //parrilla
                    bool viewSubMenuParrilla = true;
                    do
                    {
                        _subMenuParrilla.ShowMenu();
                        viewSubMenuParrilla = _subMenuParrilla.ChooseOpt(_subMenuParrilla.InsertOption(-1));
                    }
                    while (viewSubMenuParrilla);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 5: //pizzas
                    bool viewSubMenuPizzas = true;
                    do
                    {
                        _subMenuPizzas.ShowMenu();
                        viewSubMenuPizzas = _subMenuPizzas.ChooseOpt(_subMenuPizzas.InsertOption(-1));
                    }
                    while (viewSubMenuPizzas);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 6: //sandwich
                    bool viewSubMenuSandwich = true;
                    do
                    {
                        _subMenuSandwich.ShowMenu();
                        viewSubMenuSandwich = _subMenuSandwich.ChooseOpt(_subMenuSandwich.InsertOption(-1));
                    }
                    while (viewSubMenuSandwich);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 7: //ensalada
                    bool viewSubMenuEnsalada = true;
                    do
                    {
                        _subMenuEnsalada.ShowMenu();
                        viewSubMenuEnsalada = _subMenuEnsalada.ChooseOpt(_subMenuEnsalada.InsertOption(-1));
                    }
                    while (viewSubMenuEnsalada);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 8: //bebidas
                    bool viewSubMenuBebidas = true;
                    do
                    {
                        _subMenuBebidas.ShowMenu();
                        viewSubMenuBebidas = _subMenuBebidas.ChooseOpt(_subMenuBebidas.InsertOption(-1));
                    }
                    while (viewSubMenuBebidas);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 9: //cerveza artesanal
                    bool viewSubMenuCerveza = true;
                    do
                    {
                        _subMenuCerveza.ShowMenu();
                        viewSubMenuCerveza = _subMenuCerveza.ChooseOpt(_subMenuCerveza.InsertOption(-1));
                    }
                    while (viewSubMenuCerveza);
                    Console.ReadKey(true);
                    Console.Clear();
                    return true;
                case 10: //postres
                    bool viewSubMenuPostres = true;
                    do
                    {
                        _subMenuPostres.ShowMenu();
                        viewSubMenuPostres = _subMenuPostres.ChooseOpt(_subMenuPostres.InsertOption(-1));
                    }
                    while (viewSubMenuPostres);
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
