using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
{
    class Equipo
    {
        private string _nombre;
        public Dictionary<int, Jugador> Jugadores = new Dictionary<int, Jugador>();

        public Equipo( string nombre)
        {
            _nombre = nombre;
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public void agregarJugador(string jugador, int numero)
        {
            Jugadores.Add(numero, new Jugador(jugador, numero));
        }

        public void eliminarJugador(int numero)
        {
            Jugadores.Remove(numero);
        }
           
    }
}
