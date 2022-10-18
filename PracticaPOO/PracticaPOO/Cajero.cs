using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    public class Cajero
    {
        private string cedula { get; set; }
        private string nombre { get; set; }
        private string telefono { get; set; }
        private string direccion { get; set; }

        public Cajero(String cedula, String nombre, String telefono, String direccion) {
            this.direccion = direccion;
            this.cedula = cedula;
            this.nombre = nombre;
            this.telefono = telefono;
        }

        public Cajero() { }  
        public void CrearCajero()
        {
            Console.WriteLine("Digite la cedula:");   cedula = Console.ReadLine();
            Console.WriteLine("Digite la nombre: ");   nombre = Console.ReadLine();
            Console.WriteLine("Digite la telefono: "); telefono = Console.ReadLine();
            Console.WriteLine("Digite la cedula: ");   direccion = Console.ReadLine();
 
            Console.WriteLine($"El cajero ha sido creado: \n Cedula: {cedula} \n Nombre: {nombre}  \n" +
                $"Telefono: {telefono}  \n Direccion: {direccion} ");
        }

        public void AsignarCajeroaCaja()
        {
            Console.WriteLine("Asignar  cajero");
        }

        public void Cierrecaja()
        {
            Console.WriteLine("Cierre de caja");
        }


    }
}
