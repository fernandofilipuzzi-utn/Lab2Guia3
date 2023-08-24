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
        public int[] numeros = new int[52];
        int filas, columnas;
        int cantidad;

        static Random azar = new Random();
        public Generador(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;
            cantidad = filas * columnas;

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
            
            if (cantidad>0)
            {
                int nro = azar.Next(0, cantidad);
                numero = numeros[nro];
                numeros[nro] = numeros[--cantidad];
            }
            return numero;
        }
    }
}
