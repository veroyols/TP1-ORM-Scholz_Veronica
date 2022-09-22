using PS_Scholz_Veronica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Menu
{
    abstract public class MenuTemplate
    {
        protected readonly Service _service;

        protected MenuTemplate(Service service)
        {
            _service = service;
        }
        abstract public void ShowMenu();
        public int InsertOption(int op)
        {
            try
            {
                op = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            catch (FormatException e)
            {
                Console.Write("Debe ingresar un numero (" + e.Message + ") \nPress any key to continue . . . ");
                Console.ReadKey(true);
            }
            catch (OverflowException e)
            {
                Console.Write(e.Message + " \nPress any key to continue . . . ");
                Console.ReadKey(true);
            }
            catch (Exception e)
            {
                Console.Write(e.Message + " \nPress any key to continue . . . ");
                Console.ReadKey(true);
            }
            finally
            {
                Console.Clear();
            }
            return op;
        }
        abstract public bool ChooseOpt(int opt);
    }
}
