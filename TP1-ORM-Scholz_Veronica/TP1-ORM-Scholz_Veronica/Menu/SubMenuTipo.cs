﻿using TP1_ORM_Scholz_Veronica.Create;

namespace TP1_ORM_Scholz_Veronica.Menu
{
    public class SubMenuTipo : MenuTemplate
    {
        protected readonly AllServices _services;
        protected readonly SubMenuFiltro _subMenuFiltro;
        protected readonly SubMenuFormaEntrega _subMenuFormaEntrega;
        protected int cdadDeTipos;

        public SubMenuTipo(AllServices services) {
            _services = services;
            _subMenuFiltro = new SubMenuFiltro(services);
            _subMenuFormaEntrega = new SubMenuFormaEntrega(services);
            cdadDeTipos = 0;
        }

        public void ShowMenu(int op)
        {
            Console.WriteLine("                      ---------------------");
            Console.WriteLine("                     |  REGISTRAR COMANDA  |");
            Console.WriteLine("                      ---------------------");

            //refactorizar en AllServicios
            cdadDeTipos = _services.GetCantidadDeTipos(op);
            //lista de TipoMercaderia
            foreach (var item in _services.GetAllTiposMercaderia())
            {
                Console.WriteLine("             {0}. {1}", item.TipoMercaderiaId, item.Descripcion);
            }
            Console.WriteLine("             0. Volver");
            Console.Write("\n               Ingrese un numero: ");
        }
        override public bool ChooseOpt(int tipo)
        {
            if (0 < tipo && tipo <= cdadDeTipos)
            {
                bool viewSubMenuFiltro = true;
                do
                {
                    _subMenuFiltro.ShowMenu(tipo);
                    viewSubMenuFiltro = _subMenuFiltro.ChooseOpt(_subMenuFiltro.InsertOption(-1));
                }
                while (viewSubMenuFiltro);
                Console.Clear();
                return true;
            }
            else
            {
                switch (tipo)
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
