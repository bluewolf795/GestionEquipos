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
                Console.WriteLine("4. Listar jugadores de todo el club.");
                Console.WriteLine("5. Eliminar un Equipo.");
                Console.WriteLine("6. Eliminar un Jugador.");
                Console.WriteLine("7. Transferir Jugador");
                Console.WriteLine("8. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: 
                        Club.AñadirEquipo();
                        break;
                    case 2: Equipo.AñadirJugador();
                        break;
                    case 3: Equipo.ListarJugadores();
                        break;
                    case 4: Club.ListarJugadores();
                        break;
                    case 5: Club.EliminarEquipo();
                        break;
                    case 6: Equipo.EliminarJugador();
                        break;


                    default:
                        break;
                }

            }while (opcion != 8) ;

        }

    }
}
