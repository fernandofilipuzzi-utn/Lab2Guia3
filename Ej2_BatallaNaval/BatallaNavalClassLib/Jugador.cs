using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace BatallaNavalClassLib
{
    public class Jugador
    {
        public enum TipoAcierto { Agua=1, Impacto, Hundido}
        public string Nombre { get; private set; }

        Celda[,] mar;

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
                if (mar != null)
                    celda = mar[fila, columna];
                return celda;
            }
        }
    }
}
