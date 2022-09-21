using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_Scholz_Veronica.Entities
{
    public class Cliente
    {
        public Cliente() { }
        public Cliente(string dNI, string nombre, string apellido, string direccion, string telefono)
        {
            DNI = dNI;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
        }
        [Key]
        public int ClienteId { get; set; }
        [MaxLength(10)]
        public string DNI { get; set; }
        [MaxLength(25)] 
        public string Nombre { get; set; }
        [MaxLength(25)]
        public string Apellido { get; set; }
        public string Direccion { get; set; }  
        [MaxLength(13)] 
        public string Telefono { get; set; }
        //Relacion
        public IList<Carrito> Carritos { get; set; }
    }
}
