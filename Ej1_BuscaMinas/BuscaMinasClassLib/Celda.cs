using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaMinasClassLib
{
    public class Celda
    {
        public enum TipoEstado { Oculta, Despejado, Marcada }
        public TipoEstado Estado { get; set; }
        public bool HayMina { get; set; }
        public bool HaDetonado { get; set; }
        public int MinasAlrededor { get; set; }

        public Celda()
        { 
        }
    }
}
