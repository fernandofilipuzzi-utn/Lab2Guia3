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

        List<Celda> posiciones = new List<Celda>();

        public int Longitud { get { return posiciones.Count; } }

        public Celda this[int n]
        {
            get
            {
                return posiciones[n];
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
                while (n < posiciones.Count && fueHundido==true)
                {
                    fueHundido &= posiciones[n].HuboImpacto;
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
            if (posiciones.Count < 2)
            {
                esAlineada = true;
            }
            else 
            {               
                esAlineada |= (posiciones[posiciones.Count - 1].Columna == posiciones[posiciones.Count - 2].Columna) &&
                                     (celda.Columna == posiciones[posiciones.Count - 1].Columna);

                esAlineada |= (posiciones[posiciones.Count - 1].Fila == posiciones[posiciones.Count - 2].Fila) &&
                                        (celda.Fila == posiciones[posiciones.Count - 1].Fila);
            }

            //verificar que sean contiguas
            if (posiciones.Count < 1)
            {
                esContigua = true;
            }
            else
            {
                Celda last = posiciones.Last();
                Celda first = posiciones.First();

                esContigua = Math.Abs(first.Columna - celda.Columna) == 1 ||
                                Math.Abs(last.Columna - celda.Columna) == 1 ||
                                Math.Abs(first.Fila - celda.Fila) == 1 ||
                                Math.Abs(last.Fila - celda.Fila) == 1;
            }

            //eliminar las que no cumplen
            for (int n = 0; n < posiciones.Count; n++)
            {
                estaYaIncluida &= posiciones[n] == celda;
            }

            if (esContigua && esAlineada && estaYaIncluida==false)
            {
                posiciones.Add(celda);
            }

            return esContigua;
        }

        public bool FueUbicada()
        {
            return (int)Tipo>0 && posiciones.Count == (int)Tipo;
        }
    }
}
