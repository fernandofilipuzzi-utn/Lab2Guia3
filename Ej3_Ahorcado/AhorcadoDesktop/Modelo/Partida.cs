using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoDesktop.Modelo
{
    class Partida
    {
        public string Nombre { get; set; }
        public int Ganadas { get; set; }
        public int Jugadas { get; set; }

        public Partida(string ganador)
        {
            this.Nombre = ganador;
            this.Ganadas = 0;
            this.Jugadas = 1;
        }
    }
}
