
using System.Collections;

namespace BatallaNavalClassLib

{
    public class BatallaNaval
    {
        Jugador jugador1;
        Jugador jugador2;

        Celda[,] mar;

        public Celda this[int fila, int columna]
        {
            get
            {
                Celda celda = null;
                if(mar!=null)
                    celda= mar[fila, columna];
                return celda;
            }
        }

        public int CantFilas;
        public int CantColumnas;

        public BatallaNaval(string nombre, int CantFilas, int CantColumnas)
        {
            mar = new Celda[CantFilas, CantColumnas];
            for (int n = 0; n < CantFilas; n++)
            {
                for (int m = 0; m < CantFilas; m++)
                {
                    mar[n, m] = new Celda();
                }
            }
        }

       
    }
}
