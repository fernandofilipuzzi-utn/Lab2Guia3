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
        int despejadasYMarcadas;
        public int Filas { get; private set; }
        public int Columnas { get; private set; }
        public string Jugador { get; set; }

        public Celda this[int fila, int columna] 
        {
            get 
            {
                Celda celda=null;

                if(fila>=0 && columna>=0 && fila < Filas && columna < Columnas)
                    celda=tablero[fila, columna];

                return celda;
            }
        }

        public BuscaMinas(string jugador, int filas, int columnas, int minas)
        {
            Jugador = jugador;
            Filas = filas;
            Columnas = columnas;

            tablero = new Celda[Filas, Columnas];
            for (int m = 0; m < Filas; m++)
            {
                for (int n = 0; n < Columnas; n++)
                {
                    tablero[m, n] = new Celda() { Estado = Celda.TipoEstado.Oculta, HayMina = false, MinasAlrededor = 0 };
                }
            }

            #region minado el terreno!
            Generador azar = new Generador(filas, columnas);
            for (int n = 0; n < minas; n++)
            {
                int p,q;
                azar.Extraer(out p, out q);
                if(this[p, q]!=null)
                    this[p, q].HayMina = true;
            }
            #endregion

            #region contando la vencidad con minas
            for (int m = 0; m < Filas; m++)
            {
                for (int n = 0; n < Columnas; n++)
                {
                    if (this[m, n].HayMina == false)
                    {
                        for (int p = m - 1; p < m + 2; p++)
                        {
                            for (int q = n - 1; q < n + 2; q++)
                            {
                                if (this[p, q]!=null && (p == m && q == n) == false && this[p, q].HayMina == true)
                                {
                                    this[m, n].MinasAlrededor++;
                                }
                            }
                        }
                    }
                    //
                }
            }
            #endregion
        }

        public void MarcarCelda(int fila, int columna)
        {
            if (this[fila, columna].Estado == Celda.TipoEstado.Marcada)
            {
                this[fila, columna].Estado = Celda.TipoEstado.Oculta;
                if (this[fila, columna].HayMina==true)
                {
                    despejadasYMarcadas--;
                }
            }
            else if (this[fila, columna].Estado == Celda.TipoEstado.Oculta)
            {
                this[fila, columna].Estado = Celda.TipoEstado.Marcada;
                if (this[fila, columna].HayMina==true)
                {
                    despejadasYMarcadas++;
                }
            }
        }

        public void DestaparCelda(int fila, int columna)
        {
            if (this[fila, columna].HayMina == false)
            {
                DestaparCeldasVecinas(fila, columna);
            }
            else
            {
                haFinalizado = true;
                this[fila, columna].HaDetonado = true;
                MostrarMinasRestantes(this[fila, columna]);
            }
        }

        bool haFinalizado = false;
        public bool HaFinalizado()
        {
            return haFinalizado || despejadasYMarcadas == Filas * Columnas;
        }

        private void DestaparCeldasVecinas(int fila, int columna)
        {
            if (this[fila, columna].HayMina == false && this[fila, columna].Estado != Celda.TipoEstado.Despejado)
            {
                this[fila, columna].Estado = Celda.TipoEstado.Despejado;
                despejadasYMarcadas++;

                if (this[fila, columna].MinasAlrededor == 0)
                {
                    for (int p = fila - 1; p < fila + 2; p++)
                    {
                        for (int q = columna - 1; q < columna + 2; q++)
                        {
                            if (this[p,q]!=null && (p == fila && q == columna) == false)
                            {
                                DestaparCeldasVecinas(p, q);
                            }
                        }
                    }
                }
            }
        }

        private void MostrarMinasRestantes(Celda minaDetonada)
        {
            for (int m = 0; m < Filas; m++)
            {
                for (int n = 0; n < Columnas; n++)
                {
                    if (this[m, n].HayMina == true && this[m, n]!=minaDetonada && this[m,n].Estado!=Celda.TipoEstado.Marcada)
                    {
                        this[m, n].Estado = Celda.TipoEstado.Despejado;
                    }
                }
            }
        }
    }
}
