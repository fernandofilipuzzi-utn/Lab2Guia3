using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaMinasDesktop.Modelo
{
    class Partida
    {
        public string Participante { get; set; }
        public int Tiempo { get; set; }

        public Partida(string ganador, int ganadas)
        {
            this.Participante = ganador;
            this.Tiempo = ganadas;
        }
    }
}
