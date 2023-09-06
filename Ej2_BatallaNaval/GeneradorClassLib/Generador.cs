using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace GeneradorClassLib
{
    public class Generador
    {
        public int[] numeros;
        int filas, columnas;
        int cantidad;

        static Random azar = new Random();
        public Generador(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;
            cantidad = filas * columnas;

            numeros = new int[cantidad];

            for (int n = 0; n < cantidad; n++)
            {
                numeros[n] = n;
            }
        }

        public int Extraer(out int fila, out int columna)
        {
            fila = -1;
            columna = -1;
            int numero = -1;

            if (cantidad > 0)
            {
                int nro = azar.Next(0, cantidad);
                numero = numeros[nro];
                numeros[nro] = numeros[--cantidad];

                fila = numero / this.columnas;
                columna = numero % this.columnas;
            }

            return numero;
        }

        public void Descartar(int fila,int columna)
        {
            int celda= fila * columnas + columna;

            int idx = -1;
            int n = 0;
            while (n<cantidad && idx==-1)
            {
                if (celda == numeros[n])
                    idx = n;
                else
                    n++;
            }

            if (idx > -1)
            {
                numeros[idx] = numeros[--cantidad];
            }
        }
    }
}
