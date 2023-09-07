using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using GeneradorClassLib;

namespace BatallaNavalClassLib
{
    public class Jugador
    {     
        public string Nombre { get; private set; }
                
        List<Embarcacion> embarcaciones = new List<Embarcacion>();

        Celda[,] mar;

        public Celda this[int fila, int columna]
        {
            get
            {
                Celda celda = null;
                if (mar != null && fila>=0 && fila < mar.GetLength(0)  && columna>=0 && columna< mar.GetLength(1))
                    celda = mar[fila, columna];
                return celda;
            }
        }

        public Jugador(string nombre, Celda[,] mar)
        {
            Nombre = nombre;
            this.mar = mar;
        }

        static Random azar = new Random();

        public void AutoInicializar(Embarcacion.TipoEmbarcacion[] modelosEmbarcaciones)
        {
            Generador ubicaciones = new Generador(mar.GetLength(0), mar.GetLength(1));

            Embarcacion nueva=null;
            int n = 0;
            int fila0 = 0, columna0 = 0;
            while (n < modelosEmbarcaciones.Length)
            {
                bool esVertical = false;

                if (nueva == null)
                {
                    esVertical = azar.Next(0, 2) == 0 ;
                    nueva = new Embarcacion(modelosEmbarcaciones[n]);
                    ubicaciones.Extraer(out fila0, out columna0);
                }

                if (this.HayCeldasOcupadasContiguas(fila0, columna0) == true)
                {
                    nueva = null;
                }
                else
                {
                    Celda celda = this[fila0, columna0];

                    if (nueva.AgregarCelda(celda) == true)
                    {
                        ubicaciones.Descartar(fila0, columna0);

                        if (esVertical)
                        {
                            fila0++;
                            if (this[fila0, columna0] == null)
                            {
                                //fila0 -= 2;
                                nueva = null;
                            }
                        }
                        else
                        {
                            columna0++;
                            if (this[fila0, columna0] == null)
                            {
                                //columna0 -= 2;
                                nueva = null;
                            }
                        }
                    }
                    else
                    {
                        nueva = null;
                    }
                }
                
                if (nueva != null && nueva.FueUbicada() == true)
                {
                    this.AgregarEmbarcacion(nueva);
                    n++;
                    nueva = null;
                }
            }
        }

        public void Marcar(int fila, int columna)
        {
            if(this[fila, columna]!=null)
                this[fila, columna].MarcarCelda();
        }

        /// <summary>
        /// si hay alguna celda contigua ocupada
        /// </summary>
        public bool HayCeldasOcupadasContiguas(int fila, int columna)
        {
            bool hayVecina = false;
            for (int m = fila-1; m < fila+2 && hayVecina == false; m++)
            {
                for (int n = columna-1; n < columna+2 && hayVecina == false; n++)
                {
                    hayVecina |= (this[m, n] != null) && this[m, n].Embarcacion!=null;
                }
            }
            return hayVecina;
        }

        public void AgregarEmbarcacion(Embarcacion nueva)
        {
            embarcaciones.Add(nueva);
            for (int m = 0; m < (int)nueva.Tipo; m++)
                nueva[m].Embarcacion = nueva;
        }

        public bool QuedaAlgunaEmbarcacion()
        {
            bool quedaAlgunaEmbarcacion = false;
            int n = 0;
            while ( n<embarcaciones.Count && quedaAlgunaEmbarcacion==false)
            {
                quedaAlgunaEmbarcacion |= embarcaciones[n].FueHundido == false;
                n++;
            }
            return quedaAlgunaEmbarcacion;
        }
    }
}
