using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaPOO;

namespace PracticaPOO
{
    public class Cajero1 : Cajero , Icajero1
    {

        Cajero caja1 = new Cajero();
        public Cajero1() { }
        public void metodo1() { }
        public void cobrar()
        {
            Console.WriteLine("Cajero 2 Cobra");
        }
        
    }
    
}
