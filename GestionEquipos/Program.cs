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
                Console.WriteLine("2. Añadir un Jugador.");
                Console.WriteLine("3. Listar jugadores de un equipo.");
                Console.WriteLine("4. Listar jugadores de un club.");
                Console.WriteLine("5. Eliminar un Equipo.");
                Console.WriteLine("6. Eliminar un Jugador.");
                Console.WriteLine("7. Transferir Jugador");
                Console.WriteLine("8. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Club.AñadirEquipo();
                    case 2: Equipo.AñadirJugador();
                    case 3: Equipo.ListarJugadores();
                    case 4: Club.ListarJugadores();
                    case 5: Club.EliminarEquipo();
                    case 6: Equipo.EliminarJugador();
                    case 7: Equipo.EliminarJugador();
                    case 8: break;


                    default:
                        break;
                }

            }while (opcion != 8) ;

        }

    }
}
