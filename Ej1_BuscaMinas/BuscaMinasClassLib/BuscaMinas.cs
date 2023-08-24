using GeneradorClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaMinasClassLib
{
    public class BuscaMinas
    {
        Celda[,] tablero;

        public int Filas { get; private set; }
        public int Columnas { get; private set; }
        public string Jugador { get; set; }

        public Celda this[int m, int n] 
        {
            get 
            {
                return tablero[m, n];
            }
        }

        public BuscaMinas(string jugador, int filas, int columnas, int minas)
        {
            Filas = filas;
            Columnas = columnas;
            tablero = new Celda[filas, columnas];
            for (int n = 0; n < filas; n++)
                for (int m = 0; m < filas; m++)
                    tablero[n, m] = new Celda() { Estado = Celda.TipoEstado.Oculta, HayMina = false, MinasAlrededor = 0 };

            Generador azar = new Generador(filas, columnas);

            for (int n = 0; n < minas; n++)
            {
                int p,q;
                int nro = azar.Extraer(out p, out q);
                tablero[p, q].HayMina = true;
            }

            for (int n = 0; n < filas; n++)
            {
                for (int m = 0; m < filas; m++)
                {
                    //
                    for (int p = n-1; p < n+1; p++)
                    {
                        for (int q = m-1; q < m+1; q++)
                        {
                            if (p >= 0 && q >= 0 && (p==1 && q==1)==false )
                            {
                                tablero[m, n].MinasAlrededor++;
                            }
                        }
                    }
                    //
                }
            }

        }

        public void DestaparCelda(int m, int n)
        {
            if (this[m, n].HayMina != false)
                DestaparCeldasVecinas(m, n);
        }

        public void DestaparCeldasVecinas(int m, int n)
        {
            if(this[m, n].HayMina != false)
                this[m, n].Estado = Celda.TipoEstado.Despejado;

            if (this[m, n].MinasAlrededor == 0 && this[m, n].HayMina != false)
            {
                for (int p = n - 1; p < n + 1; p++)
                {
                    for (int q = m - 1; q < m + 1; q++)
                    {
                        if (p >= 0 && q >= 0 && (p == 1 && q == 1) == false)
                        {
                            DestaparCeldasVecinas(p, q);
                        }
                    }
                }
            }
        }
    }
}
