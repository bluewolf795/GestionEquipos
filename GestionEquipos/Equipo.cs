using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipos
{
    class Equipo
    {
        private static List<Jugador> jugadores;
        private string nombre;
        private string categoria;

        public string Nombre { get => nombre; set => nombre = value;}
        public string Categoria { get => categoria; set => categoria = value;}
        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }

        public Equipo()
        {

        }
        public Equipo(string nombre,string categoria)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            jugadores = new List<Jugador>();
        }
        

        public static void ListarJugadores()
        {
            foreach (var jugador in jugadores)
            {
                string nombre = jugador.Nombre;
                Console.WriteLine(nombre);
            }
        }

        public static void AñadirJugador()
        {
            Console.WriteLine("Que nombre tiene su jugador?");
            string nombre = Console.ReadLine();

            Console.WriteLine("Que dorsal tiene su jugador?");
            int dorsal = int.Parse(Console.ReadLine());

            Console.WriteLine("Que posicion tiene su jugador?");
            string posicion = Console.ReadLine();

            Console.WriteLine("En que equipo jugara este jugador?");
            string nombreEquipo = Console.ReadLine();


            foreach (Equipo equipo in Club.Equipos)
            {
                if(nombreEquipo == equipo.Nombre)
                {
                    Equipo Guardado = equipo;

                    Jugador jugador = new Jugador(nombre, posicion, dorsal, Guardado);
                }
            }

        }

        public static void EliminarJugador()
        {
            Console.WriteLine("Que nombre tiene su jugador?");
            string nombre = Console.ReadLine();

            Console.WriteLine("Que dorsal tiene su jugador?");
            int dorsal = int.Parse(Console.ReadLine());

            Console.WriteLine("En que equipo jugara este jugador?");
            string nombreEquipo = Console.ReadLine();

            Equipo guardado = new Equipo();

            foreach (Equipo equipo in Club.Equipos)
            {
                if (nombreEquipo == equipo.Nombre)
                {
                    guardado = equipo;
                }
            }

            foreach (Jugador jugador in guardado.Jugadores)
            {
                if( jugador == jugador(nombre,posicion,dorsal,Guardado)
            }

            Equipo.jugadores.Remove()
        }
        public static void TransferirJugador()
        {
            Console.WriteLine("Elige el equipo de origen");
            Club.ListarJugadores();
            string nombreEquipo = Console.ReadLine();
            Equipo equipoOrigen = new Equipo();

            foreach (Equipo equipo in Club.Equipos)
            {
                if (nombreEquipo == equipo.Nombre)
                {
                    equipoOrigen = equipo;
                }
            }

            Console.WriteLine("Elige el jugador");
            Equipo.ListarJugadores();
            


            Console.WriteLine("Elige el equipo de destino");
            string nombreEquipo2 = Console.ReadLine();
            Equipo equipoDestino = new Equipo();

            foreach (Equipo equipo in Club.Equipos)
            {
                if (nombreEquipo2 == equipo.Nombre)
                {
                    equipoDestino = equipo;
                }
            }

            
        }
    }
}
