using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;


namespace JuegoDeLaVidaClassLib
{
    public class Poquer
    {
        
        ArrayList jugadores = new ArrayList();
        public int CantidadJugadores { get; private set; }

        public int Ronda{get; private set;}

        public int CantCartasComunitarias = 0;

        public Poquer(string nombre, int cantidadJugadores) 
        {
            Jugador nuevo = null;
            this.CantidadJugadores = cantidadJugadores;
            
            nuevo = new Jugador(this, nombre);
            jugadores.Add(nuevo);

            for (int n = 0; n < cantidadJugadores - 1; n++)
            {
                nuevo = new Jugador(this, "Máquina " + n);
                jugadores.Add(nuevo);
            }
        }

        public void IniciarRonda()
        {
            
        }

        public bool Jugar(Jugador.TipoAccion accion,int fichas)
        {
            return false;
        }

        public Jugador[] VerificarApuestas()
        {
            Jugador [] aSolicitar=new Jugador[0];

            return aSolicitar;
        }

        public Jugador VerJugador(int nro)
        {
            return (Jugador)(jugadores[nro]);
        }
    }
}
