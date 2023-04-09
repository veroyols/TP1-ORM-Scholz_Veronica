using TP1_ORM_Scholz_Veronica.Create;

namespace TP1_ORM_Scholz_Veronica.Menu
{
    public class SubMenuFilter : MenuTemplate
    {
        protected readonly AllServices _services;
        protected int platosPorTipo;
        protected int lastId;

        public SubMenuFilter(AllServices services) {
            _services = services;
            platosPorTipo = 0;

        }
        public void ShowMenu(int op)
        {
            string tipo = _services.GetType(op).Result;
            Console.WriteLine(" -------------------------------------------------------------");
            Console.WriteLine("                   2. AGREGAR {0}", tipo.ToUpper());
            Console.WriteLine(" -------------------------------------------------------------\n");
            platosPorTipo = _services.AmountByType(op).Result;
            //lista de Mercaderia por TipoMercaderia
            foreach (var item in _services.GetMercaderiasByType(op).Result) 
            {
                Console.WriteLine("             {0}. {1} (${2})", item.MercaderiaId, item.Nombre, item.Precio);
                lastId = item.MercaderiaId;
            }
            Console.WriteLine("\n             0. Volver");
            Console.Write("\n               Ingrese un numero: ");
        }
        public override bool ChooseOpt(int idMercaderiaSeleccionada)
        {
            if (lastId - platosPorTipo < idMercaderiaSeleccionada && idMercaderiaSeleccionada <= lastId)
            {
                //AGREGAR idMercaderiaSeleccionada a una lista con cantidad
                int price = _services.GetPrice(idMercaderiaSeleccionada).Result;
                _services.AddToSelected(idMercaderiaSeleccionada, price);
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
