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

        public Equipo(string nombre,string categoria)
        {
            this.Nombre = nombre;
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

        public static void AñadirJugador(Jugador jugador)
        {
            Equipo.jugadores.Add(jugador);
        }

        public static void EliminarJugador(Jugador jugador)
        {
            Equipo.jugadores.Remove(jugador);
        }
    }
}
