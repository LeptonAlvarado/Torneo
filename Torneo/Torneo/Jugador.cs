using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
{
    class Jugador
    {
        private string _nombre;
        private int _numero;

        public Jugador(string nombre, int numero)
        {
            _nombre = nombre;
            _numero = numero;
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public int Numero
        {
            get { return _numero; }
        }

        public override string ToString()
        {
            return "Numero: " + _numero.ToString() + " Nombre: " + _nombre.ToString() + Environment.NewLine;
        }
    }
}
