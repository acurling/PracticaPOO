using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    internal class Persona
    {
        public int cedula { get; set; }
        public string nombre { get; set; }

        public Persona (int ced, string nomb)
        {
            cedula=ced;
            nombre = nombre;
        }
    }
}
