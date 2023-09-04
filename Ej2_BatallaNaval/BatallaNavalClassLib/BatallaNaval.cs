
using System.Collections;

namespace BatallaNavalClassLib
{
    public class BatallaNaval
    {
        Jugador jugador1;
        Jugador jugador2;

        public int CantFilas;
        public int CantColumnas;

        public BatallaNaval(string nombre, int CantFilas, int CantColumnas)
        {
            #region factoria jugador 1
            Celda [, ]mar = new Celda[CantFilas, CantColumnas];
            for (int n = 0; n < CantFilas; n++)
            {
                for (int m = 0; m < CantFilas; m++)
                {
                    mar[n, m] = new Celda();
                }
            }
            jugador1 = new Jugador(nombre, mar);
            #endregion

            #region factoria jugador 2
            mar = new Celda[CantFilas, CantColumnas];
            for (int n = 0; n < CantFilas; n++)
            {
                for (int m = 0; m < CantFilas; m++)
                {
                    mar[n, m] = new Celda();
                }
            }
            jugador2 = new Jugador("Máquina", mar);
            #endregion
        }
    }
}
