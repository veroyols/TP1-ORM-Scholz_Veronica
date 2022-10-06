using PS_Scholz_Veronica.Servicios;

namespace PS_Scholz_Veronica.EnterData
{
    public class EnterId
    {
        public static int Cliente(Service service)
        {
            bool read = false;
            int id = 0;
            do
            {
                try
                {
                    Console.WriteLine("\n       ----------------------------------------------");
                    Console.Write("       *Ingrese su Cliente ID: ");
                    id = int.Parse(Console.ReadLine());
                    if (!service.ValidarClienteId(id))
                    {
                        throw new IdInexistenteException("No existe cliente con ese ID.");
                    }
                    read = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("       ----------------------------------------------");
                    Console.WriteLine("        Debe ingresar un numero " +
                        "\n        ({0}) " +
                        "\n        Press any key to continue . . . ", e.Message);
                    Console.ReadKey(true); 
                    read = true;
                }
                catch (IdInexistenteException e)
                {
                    Console.WriteLine("       ----------------------------------------------");
                    Console.WriteLine("        Debe ingresar un numero de cliente valido. " +
                        "\n        ({0}) " +
                        "\n        Press any key to continue . . . ", e.Message);
                    Console.ReadKey(true);
                    read = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("       ----------------------------------------------");
                    Console.WriteLine("        Por favor ingrese un numero de cliente valido.");
                    Console.ReadKey(true);
                    read = true;
                }
                Console.Clear();
                Console.WriteLine("               --------------------");
                Console.WriteLine("              | 2. Registrar Venta |");
                Console.WriteLine("               --------------------");

            } while (read);

            return id;
        }
        public static int Producto(Service service)
        {
            bool read = false;
            int productId = 0;
            do
            {
                try
                {
                    Console.WriteLine("       ----------------------------------------------------");
                    Console.Write("       *Ingrese el ID de Producto que desea comprar: ");
                    productId = int.Parse(Console.ReadLine());
                    if (!service.ValidarProductoId(productId))
                    {
                        throw new IdInexistenteException("No existe un producto con ese ID.");
                    }
                    read = false;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("       ----------------------------------------------");
                    Console.WriteLine("       Debe ingresar un numero " +
                        "\n        ({0}) " +
                        "\n        Press any key to continue . . . ", e.Message);
                    Console.ReadKey(true);
                    read = true;
                }
                catch (IdInexistenteException e)
                {
                    Console.WriteLine("       ----------------------------------------------");
                    Console.WriteLine("        Debe ingresar un numero de producto valido. " +
                        "\n        ({0}) " +
                        "\n        Press any key to continue . . . ", e.Message);
                    Console.ReadKey(true);
                    read = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("       ----------------------------------------------");
                    Console.WriteLine("       Por favor ingrese un numero de producto valido.");
                    Console.ReadKey(true);
                    read = true;
                }
            } while (read);

            return productId;
        }
        public static int Cantidad(Service service)
        {
            bool read = false;
            int cdad = 0;
            do
            {
                    Console.Write("\n       *Ingrese la cantidad: ");
                try
                {
                    cdad = int.Parse(Console.ReadLine());
                    read = false;
                    if (cdad<1)
                    {
                        throw new CantidadException("Debe ingresar un numero mayor que cero.");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("       ----------------------------------------------");
                    Console.WriteLine("       Debe ingresar un numero entero." +
                        "\n        ({0}) " +
                        "\n        Press any key to continue . . . ", e.Message);
                    Console.ReadKey(true);
                    read = true;
                }
                catch (CantidadException e)
                {
                    Console.WriteLine("       ----------------------------------------------");
                    Console.WriteLine("        Debe ingresar un numero entero valido. " +
                        "\n        ({0}) " +
                        "\n        Press any key to continue . . . ", e.Message);
                    Console.ReadKey(true);
                    read = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("       ----------------------------------------------");
                    Console.WriteLine("       Por favor ingrese una cantidad valida.");
                    Console.ReadKey(true);
                    read = true;
                }
            } while (read);

            return cdad;
        }

    }
    public class IdInexistenteException : Exception
    {
        public IdInexistenteException(string message) : base(message) { }
    }
    public class CantidadException : Exception
    {
        public CantidadException(string message) : base(message) { }
    }
}