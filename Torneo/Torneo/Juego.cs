using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
{
    class Juego
    {
        private int _numero;
        private string _equipoVisitante;
        private string _equipoLocal;
        public Dictionary<int, Equipo> Equipos = new Dictionary<int, Equipo>();
        private static Random gen = new Random();

        public Juego(int numero, string equipoVisitante, string equipoLocal)
        {
            _numero = numero;
            _equipoVisitante = equipoVisitante;
            _equipoLocal = equipoLocal;
        }

        public int Numero
        {
            get { return _numero; }
        }

        public string EquipoVisitante
        {
            get { return _equipoVisitante; }
        }

        public string EquipoLocal
        {
            get { return _equipoLocal; }
        }

        public void agregarEquipo(string equipo, int numero)
        {
            Equipos.Add(numero, new Equipo(equipo));
        }

        public void eliminarEquipo(int numero)
        {
            Equipos.Remove(numero);
        }
        public string Jugar()
        {
            int golesLocal, golesVisitante;
            golesLocal = gen.Next(10);
            golesVisitante = gen.Next(10);
            if(golesLocal>golesVisitante)
            {
                return "El marcador fue: " + " Local: " + golesLocal.ToString() + " - "
                    + " Visitante: " + golesVisitante.ToString() + Environment.NewLine + "Ganador: Local";
            }
            else if(golesLocal==golesVisitante)
            {
                return "El marcador fue: " + " Local: " + golesLocal.ToString() + " - "
                   + " Visitante: " + golesVisitante.ToString() + Environment.NewLine + "Empate";
            }
            else
            {
                return "El marcador fue: " + " Local: " + golesLocal.ToString() + " - "
                   + " Visitante: " + golesVisitante.ToString() + Environment.NewLine + "Ganador: Visitante";
            }
        }

    }
}
