using PS_Scholz_Veronica.Entities;
using PS_Scholz_Veronica.Interfaces;

namespace PS_Scholz_Veronica.EnterData
{
    public class ClientData
    {
        public static Cliente EnterClientData(IQueryClient queryClient)
        {
            string dNI, nombre, apellido, direccion, telefono = "";
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();

            do
            {
                Console.Write("Ingrese su dni: ");
                dNI = Console.ReadLine();
            } while (queryClient.ExistsDni(dNI));

            Console.Write("Ingrese su direccion: ");
            direccion = Console.ReadLine();
            Console.Write("Ingrese su telefono: ");
            telefono = Console.ReadLine();
            return new Cliente(dNI, nombre, apellido, direccion, telefono);
        }
    }
}
