using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GestionEquipos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Club Splai = new Club();

            do
            {
                Console.WriteLine("Bienvenido usuario: ");
                Console.WriteLine("--------------------");

                Console.WriteLine("Que desea hacer ?");
                Console.WriteLine("1. Añadir un Equipo.");
                Console.WriteLine("3. Añadir un Jugador.");

                Console.WriteLine("4. Listar jugadores de un equipo.");
                Console.WriteLine("5. Listar jugadores de un club.");

                Console.WriteLine("6. Eliminar un Club.");
                Console.WriteLine("7. Eliminar un Equipo.");
                Console.WriteLine("8. Eliminar un Jugador.");
                Console.WriteLine("                      ");
                Console.WriteLine("9. Transferir Jugador");
                Console.WriteLine("10. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: 
                    default:
                        break;
                }

            }while (opcion != 10) ;

        }

        public static void CrearJugador()
        {
            Console.WriteLine("Que nombre tiene su jugador?");
            string nombre = Console.ReadLine();

            Console.WriteLine("Que dorsal tiene su jugador?");
            string dorsal = Console.ReadLine();

            Console.WriteLine("Que posicion tiene su jugador?");
            string posicion = Console.ReadLine();

            Console.WriteLine("En que equipo jugara este jugador?");
            string nombreEquipo = Console.ReadLine();
            
        }
    }
}
