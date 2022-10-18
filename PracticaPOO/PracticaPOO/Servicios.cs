using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    internal class Servicios
    {

        private static Dictionary<string, string> servicio = new Dictionary<string, string>()
        {
           {"1", "pago de servicios publicos"},
           {"2", "Cambio de cheques"},
           {"3", "Cambio de cheques"},
           {"4", "tarjetas"},
           {"5", "Chequeras"},
           {"6", "Creditos"}
        };

        
        public static void ListadoServicios()
        {
            foreach (var ser in servicio)
            {
                Console.WriteLine($"Codigo:{ser.Key} Descripcion: {ser.Value}");
            }
        }

        public static String SeleccionarServicio(string value)
        {
            string result;
            if (servicio.TryGetValue(value, out result))
            {
                Console.WriteLine(result);
            }
            return value;
        }

    }

}

