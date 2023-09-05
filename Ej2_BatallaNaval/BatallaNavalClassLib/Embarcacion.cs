using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaNavalClassLib
{
    public class Embarcacion
    {
        public enum TipoEmbarcacion { Lancha = 1, Crucero, Submarino, Buque, Portaaviones }

        List<Celda> celdas = new List<Celda>();

        public Celda this[int n]
        {
            get
            {
                return celdas[n];
            }
        }
        public TipoEmbarcacion Tipo { get; private set; }

        public Embarcacion(TipoEmbarcacion tipo)
        {
            this.Tipo = tipo;
        }

        public bool FueHundido 
        {
            get 
            {
                bool fueHundido = true;
                int n = 0;
                while (n < celdas.Count && fueHundido)
                {
                    fueHundido |= celdas[n].HuboImpacto;
                    n++;
                }
                return fueHundido;
            }
        }

        public bool AgregarCelda(Celda celda)
        {
            bool esContigua = true;

            if(esContigua)
                celdas.Add(celda);

            //verificar que esten alineadas 

            //verificar que sean contiguas

            //eliminar las que no cumplen

            return esContigua;
        }

        public bool FueUbicada()
        {
            return (int)Tipo>0 && celdas.Count == (int)Tipo;
        }
    }
}
