using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaNavalClassLib
{
    public class Celda
    {
        public bool EstaOculta { get; private set; }
        public Embarcacion Embarcacion{ get; set; }
        public bool HuboImpacto 
        {
            get 
            {
                return Embarcacion!=null && EstaOculta==false;
            }
        }

        public void MarcarCelda()
        {
            EstaOculta = false;
        }
    }
}
