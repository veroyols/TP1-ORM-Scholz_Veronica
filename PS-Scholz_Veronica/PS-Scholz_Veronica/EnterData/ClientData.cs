using PS_Scholz_Veronica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.EnterData
{
    public class ClientData
    {
        public static Cliente EnterClientData()
        {
            string dNI, nombre, apellido, direccion, telefono = "";
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Ingrese su dni: ");
            dNI = Console.ReadLine();
            Console.Write("Ingrese su direccion: ");
            direccion = Console.ReadLine();
            Console.Write("Ingrese su telefono: ");
            telefono = Console.ReadLine();
            return new Cliente(dNI, nombre, apellido, direccion, telefono);
        }
    }
}
