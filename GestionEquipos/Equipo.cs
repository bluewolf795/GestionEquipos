using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipos
{
    class Equipo
    {
        List<Jugador> jugadores;

        public Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public static ListarJugadores()
        {
            foreach (var jugador in jugadores)
            {
                string nombre = jugador.Nombre;
                console.WriteLine(nombre);
            }
        }

        public static AñadirJugador()
        {

        }
    }
}
