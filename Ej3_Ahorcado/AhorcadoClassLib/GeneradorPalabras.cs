using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhorcadoClassLib
{
    public class GeneradorPalabras
    {
        string [] palabras;
        int cantidad;
        static Random azar = new Random();

        public GeneradorPalabras()
        {
            palabras = new string [] { "Universidad", "Extraordinario", "Biblioteca", "Inmediatamente", 
                                    "Incertidumbre", "Revolucionario", "Elefante", "Contradicción",
                                    "Proporcionar", "Experiencia", "Dificultades", "Disposición", 
                                    "Consecuencia", "Espectacular", "Comunicación", "Incomprensible", 
                                    "Controversia", "Perseverancia", "Satisfactorio", "Infinitamente",
                                    "Paralelepípedo", "Circunstancia", "Melancolía", "Trascendental", 
                                    "Desafortunado", "Fenomenología", "Aventurero", "Constitución", 
                                    "Involuntario", "Conspiración", "Precipitación", "Oportunidad",  
                                    "Astronomía", "Legendaria", "Esperanzador", "Incuestionable", 
                                    "Transparencia", "Agrupamiento", "Meticuloso", "Misteriosamente"};
            cantidad = palabras.Length;
        }

        public string ExtraerPalabra()
        {
            int idx = azar.Next(0, cantidad);
            string palabra = palabras[idx];
            palabras[idx] = palabras[--cantidad];
            return palabra;
        }
    }
}
