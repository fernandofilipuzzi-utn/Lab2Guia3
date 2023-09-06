
using GeneradorClassLib;
using System.Collections;

using System.Collections.Generic;

namespace BatallaNavalClassLib
{
    public class BatallaNaval
    {
        public Embarcacion.TipoEmbarcacion[] ModelosEmbarcaciones
        {
            get {
                return new Embarcacion.TipoEmbarcacion[] 
                    {
                            Embarcacion.TipoEmbarcacion.Lancha,
                            Embarcacion.TipoEmbarcacion.Lancha,
                            Embarcacion.TipoEmbarcacion.Crucero,
                            Embarcacion.TipoEmbarcacion.Submarino,
                            Embarcacion.TipoEmbarcacion.Buque,
                            Embarcacion.TipoEmbarcacion.Portaaviones
                    };
            }
        }

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
            Celda [, ] mar = new Celda[CantFilas, CantColumnas];
            for (int m = 0; m< CantFilas; m++)
            {
                for (int n = 0; n < CantColumnas; n++)
                {
                    mar[m, n] = new Celda() { Fila = m, Columna = n, EstaOculta = false };
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
                    mar[m, n] = new Celda() { Fila = m, Columna = n, EstaOculta = true };
                }
            }
            Jugador2 = new Jugador("Máquina", mar);
            Jugador2.AutoInicializar(ModelosEmbarcaciones);
            #endregion
        }

        public void Jugar(int fila, int columna)
        {
            int fila1, columna1;
            generadorTiros.Extraer(out fila1, out columna1);
            Jugador1[fila1, columna1].MarcarCelda();
            
            Jugador2[fila, columna].MarcarCelda();
        }

        public bool HaFinalizado()
        {
            return Jugador1.QuedaAlgunaEmbarcacion()==false || Jugador2.QuedaAlgunaEmbarcacion()==false;
        }

    }
}
