namespace TP1_ORM_Scholz_Veronica.Menu
{
    abstract public class MenuTemplate
    {
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
                Console.Clear();
                Console.WriteLine("  Debe ingresar un numero \n(" + e.Message + ")");

            }
            catch (OverflowException e)
            {
                Console.Clear();
                Console.WriteLine("  Debe ingresar un numero \n(" + e.Message + ")");
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("  Debe ingresar un numero \n(" + e.Message + ")");
            }
            return op;
        }
    }
}
