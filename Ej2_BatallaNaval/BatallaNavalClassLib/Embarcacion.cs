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

        public int Longitud { get { return celdas.Count; } }

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
            bool esContigua = false;
            bool esAlineada = false;
            bool estaYaIncluida = false;

            //verificar que esten alineadas 
            if (celdas.Count < 2)
            {
                esAlineada = true;
            }
            else 
            {               
                esAlineada |= (celdas[celdas.Count - 1].Columna == celdas[celdas.Count - 2].Columna) &&
                                     (celda.Columna == celdas[celdas.Count - 1].Columna);

                esAlineada |= (celdas[celdas.Count - 1].Fila == celdas[celdas.Count - 2].Fila) &&
                                        (celda.Fila == celdas[celdas.Count - 1].Fila);
            }

            //verificar que sean contiguas
            if (celdas.Count < 1)
            {
                esContigua = true;
            }
            else
            {
                Celda last = celdas.Last();
                Celda first = celdas.First();

                esContigua = Math.Abs(first.Columna - celda.Columna) == 1 ||
                                Math.Abs(last.Columna - celda.Columna) == 1 ||
                                Math.Abs(first.Fila - celda.Fila) == 1 ||
                                Math.Abs(last.Fila - celda.Fila) == 1;
            }

            //eliminar las que no cumplen
            for (int n = 0; n < celdas.Count; n++)
            {
                estaYaIncluida &= celdas[n] == celda;
            }

            if (esContigua && esAlineada && estaYaIncluida==false)
            {
                celdas.Add(celda);
            }

            return esContigua;
        }

        public bool FueUbicada()
        {
            return (int)Tipo>0 && celdas.Count == (int)Tipo;
        }
    }
}
