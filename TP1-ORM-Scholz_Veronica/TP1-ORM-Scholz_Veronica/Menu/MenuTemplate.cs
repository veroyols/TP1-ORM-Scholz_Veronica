namespace TP1_ORM_Scholz_Veronica.Menu
{
    abstract public class MenuTemplate
    {
        abstract public void ShowMenu();
        abstract public bool ChooseOpt(int opt);
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
                Console.Write("Debe ingresar un numero (" + e.Message + ") \nPress any key to continue . . . ");
                Console.ReadKey(true);
            }
            catch (Exception e)
            {
                Console.Write("Debe ingresar un numero (" + e.Message + ") \nPress any key to continue . . . ");
                Console.ReadKey(true);
            }
            finally
            {
                Console.Clear();
            }
            return op;
        }
    }
}
