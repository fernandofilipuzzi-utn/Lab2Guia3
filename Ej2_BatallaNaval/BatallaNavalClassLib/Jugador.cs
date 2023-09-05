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

        Celda[,] mar;

        List<Embarcacion> embarcaciones = new List<Embarcacion>();

        public Jugador(string nombre, Celda[,] mar)
        {
            Nombre = nombre;
            this.mar = mar;
        }

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

        public void AutoInicializar()
        {
            Generador ubicaciones = new Generador(mar.GetLength(0), mar.GetLength(1));

            int fila, columna;
            ubicaciones.Extraer(out fila, out columna);

            Embarcacion lancha = new Embarcacion(Embarcacion.TipoEmbarcacion.Lancha);
            lancha.AgregarCelda(this[fila, columna]);

            //completar inicialización!
        }

        public void Marcar(int fila, int columna)
        {
            if(this[fila, columna]!=null)
                this[fila, columna].MarcarCelda();
        }

        /// <summary>
        /// si hay alguna celda contigua ocupada
        /// </summary>
        public bool HayCeldaOcupadasContiguas(int fila, int columna)
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
    }
}
