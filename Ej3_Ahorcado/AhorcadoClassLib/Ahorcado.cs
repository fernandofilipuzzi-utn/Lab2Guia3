using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoClassLib
{
    public class Ahorcado
    {
        string palabra;
        bool[] letrasAdivinadas;
        public int IntentosRestantes { get; private set; }

        public int CantidadLetras
        {
            get
            {
                return palabra.Length;
            }
        }

        public bool HaFinalizado 
        {
            get
            {
                return IntentosRestantes <= 0;
            }
        }

        public bool HaGanado
        {
            get
            {
                bool haAdivinado = true;
                for(int n=0; n< CantidadLetras && haAdivinado; n++)
                {
                    haAdivinado |= letrasAdivinadas[n];
                }
                return haAdivinado;
            }
        }

        public Ahorcado(string palabra, int intentos)
        {
            IntentosRestantes = intentos;
            this.palabra = palabra.ToUpper();

            letrasAdivinadas = new bool[palabra.Length];
            for (int n = 0; n < palabra.Length; n++)
                letrasAdivinadas[n] = false;
        }

        public void Adivinar(char letra)
        {
            int encontradas = 0;
            for (int n = 0; n < palabra.Length; n++)
            {
                if (Char.ToUpper(letra) == palabra[n])
                {
                    letrasAdivinadas[n] = true;
                    encontradas++;
                }
            }
            if (encontradas > 0)
                IntentosRestantes--;
        }

        public bool VerSiAdivino(int idx)
        {
            bool adivino = false;
            if (idx >= 0 && idx < palabra.Length)
                adivino = letrasAdivinadas[idx];
            return adivino;
        }

        public char VerLetra(int idx)
        {
            char letra = '-';
            if (letrasAdivinadas[idx] == true)
                letra=palabra[idx];
            return letra;
        }

        
    }
}
