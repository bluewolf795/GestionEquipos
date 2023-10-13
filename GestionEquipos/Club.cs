using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipos
{
    class Club
    {
        private List<Equipo> equipos;
        private string nombre;
        private int anoFundacion;
        private string nombreEstadio;

        public List<Equipo> Equipos { get { return equipos; } set { value = equipos; } }
        public string Nombre { get { return nombre; } set { value = nombre; } }
        public int AnoFundacion { get { return anoFundacion; } set { value = anoFundacion; } }
        public string NombreEstadio { get { return nombreEstadio; } set { value = nombreEstadio; } }
        public Club()
        {
            equipos = new List<Equipo>();
        }
        
        public Club(string nombre, int anoFundacion, string nombreEstadio)
        {
            this.nombre = nombre;
            this.anoFundacion = anoFundacion;
            this.nombreEstadio = nombreEstadio;
        }


    }
}
