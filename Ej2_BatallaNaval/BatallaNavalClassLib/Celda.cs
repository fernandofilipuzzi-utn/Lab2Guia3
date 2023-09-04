using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaNavalClassLib
{
    public class Celda
    {
        public Jugador.TipoAcierto Acierto { get; private set; }
        public bool EstaOculta { get; private set; }
        public Embarcacion EstaOcupada { get; private set; }
    }
}
