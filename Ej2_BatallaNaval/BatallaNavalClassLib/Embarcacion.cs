using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaNavalClassLib
{
    public class Embarcacion
    {
        List<Celda> celdas = new List<Celda>();
       
        public int Tamaño { get; private set; }

        public Embarcacion(int tamaño)
        {
            Tamaño = tamaño;
        }

        public bool FueHundido
        {
            get {
                bool fueHundido=true;
                int n = 0;
                while (n<celdas.Count && fueHundido)
                {
                    fueHundido |= celdas[n].Acierto == Jugador.TipoAcierto.Impacto;
                    n++;
                }
                return fueHundido;
            }
        }

        public bool AgregarCelda(Celda celda)
        {
            bool esContigua = true;
            if(esContigua)
                celdas.Add(celda);

            return esContigua;
        }



    }
}
