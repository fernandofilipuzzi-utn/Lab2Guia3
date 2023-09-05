
using GeneradorClassLib;
using System.Collections;

namespace BatallaNavalClassLib
{
    public class BatallaNaval
    {
        public Jugador Jugador1 { get; private set; }
        public Jugador Jugador2 { get; private set; }

        public int CantFilas { get; private set; }
        public int CantColumnas { get; private set; }

        Generador generadorTiros;

        public BatallaNaval(string nombre, int CantFilas, int CantColumnas)
        {
            generadorTiros = new Generador(CantFilas, CantColumnas);

            this.CantFilas = CantFilas;
            this.CantColumnas = CantColumnas;

            #region factoria jugador 1
            Celda [, ]mar = new Celda[CantFilas, CantColumnas];
            for (int m = 0; m< CantFilas; m++)
            {
                for (int n = 0; n < CantColumnas; n++)
                {
                    mar[m, n] = new Celda();
                }
            }
            Jugador1 = new Jugador(nombre, mar);
            #endregion

            #region factoria jugador 2
            mar = new Celda[CantFilas, CantColumnas];
            for (int m = 0; m < CantFilas; m++)
            {
                for (int n = 0; n < CantColumnas; n++)
                {
                    mar[m, n] = new Celda();
                }
            }
            Jugador2 = new Jugador("Máquina", mar);
            #endregion
        }

        public void Jugar(int fila, int columna)
        {
            Jugador1[fila, columna].MarcarCelda();
        }

        public void Jugar()
        {
            int fila, columna;
            generadorTiros.Extraer(out fila, out columna);
            Jugar(fila, columna);
        }

        public bool Finalizado()
        {
            return false;
        }

    }
}
