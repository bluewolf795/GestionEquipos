using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipos
{
    class Jugador
    {
        private string nombre;
        private string posicion;
        private int dorsal;
        private Club club;
        private Equipo equipo;
        
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Posicion { get { return posicion; } set { posicion = value; } }
        public int Dorsal { get { return dorsal; } set { Dorsal = value; } }

        public Jugador() { }
        public Jugador(string nombre, string posicion, int dorsal, Club club, Equipo equipo)
        {
            Nombre = nombre;
            Posicion = posicion;
            Dorsal = dorsal;
            Club = club;
            Equipo = equipo;
        }
    }
}
