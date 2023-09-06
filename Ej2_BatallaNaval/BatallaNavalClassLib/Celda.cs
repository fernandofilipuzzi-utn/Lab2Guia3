using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaNavalClassLib
{
    public class Celda
    {
        public bool EstaOculta { get; set; }
        
        public int Fila { get; set; }
        public int Columna { get; set; }
        
        public bool HuboDisparo { get; set; }

        public bool HuboImpacto 
        {
            get 
            {
                return Embarcacion!=null && HuboDisparo == true && Embarcacion.FueUbicada();
            }
        }

        public Celda() { }

        public Embarcacion Embarcacion { get; set; }

        public void MarcarCelda()
        {
            EstaOculta = false;
            HuboDisparo = true;
        }

        public override bool Equals(object obj)
        {
            Celda otro = obj as Celda;
            return otro != null && otro.Fila == Fila && otro.Columna == Columna;
        }
    }
}
