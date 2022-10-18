using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPOO
{
    static class Menu
    {
        static  Menu() { }

        public static void Principal()
        {
            byte opcion = 1;
            do
            {  Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*********** Menu Principal ********");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("1- ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Seleccione Servicio");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("2- ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Seleccione Cajero");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("3- ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Administracion de Cajeros");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("4- ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Salir");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("********************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: SubMenuServicios(); break;
                    case 2: SubmenuCajeros(); break;
                    case 3: break;
                    case 4:
                        Console.WriteLine("Gracias,  Adios");
                        break;
                    default:
                        break;
                }
            } while (opcion!=4);

        }

        public static void SubMenuServicios()
        {
            byte opcion = 1;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*********** Sub Menu Servicios ********");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("1- ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Servicios Publicos");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("2- ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Cambio Cheques");
                Console.ForegroundColor = ConsoleColor.Blue ;
                Console.Write("3- ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Depositos");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("4- ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Tarjetas credito y debito");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("5- ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Chequeras");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("6- ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Creditos");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("7- ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Salir");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("********************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: 
                    case 2:
                    case 3: Console.WriteLine("Cajero 1 2 y 3 Disponibles"); break;
                    case 4:
                        Console.WriteLine("Cajero 1 Disponible"); break;
                    case 5:
                        Console.WriteLine("Cajero 2 Disponible"); break;
                    case 6:
                        Console.WriteLine("Cajero 3 Disponible"); break;
                    case 7:
                        Menu.Principal(); break;
                    default:
                        break;
                }
            } while (opcion != 7);

        }
        public static void SubmenuCajeros()
        {
            byte opcion = 1;
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*********** Sub Menu Cajeros ********");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("1- ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Cajero 1");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("2- ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Cajero 2");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("3- ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Cajero 3");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("4- ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Salir");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("********************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();

                
                switch (opcion)
                {
                    case 1: Servicios.SeleccionarServicio("1"); break;
                    case 2: Servicios.SeleccionarServicio("2"); break;
                    case 3: Servicios.SeleccionarServicio("3"); break;
                    case 4: Menu.Principal(); break;

                        break;
                    default:
                        break;
                }
            } while (opcion != 4);

        }
    }
}
