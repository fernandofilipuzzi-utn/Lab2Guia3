﻿
using System.Collections;

namespace BatallaNavalClassLib

{
    public class BatallaNaval
    {
        ArrayList jugadores = new ArrayList();
        ArrayList elementos = new ArrayList();

        public int CantidadJugadores { get{ return jugadores.Count; } }
        public int CantidadElementos { get { return elementos.Count; } }

        public BatallaNaval(int cantJugadores) : this("Máquina 1", cantJugadores)
        {
        }

        public BatallaNaval(string Nombre, int cantJugadores)
        {
            jugadores.Add(new Jugador(Nombre));

            for (int n = 2; n <= cantJugadores; n++)
            {
                jugadores.Add(new Jugador("Máquina " + n));
            }

            for (int n = 1; n <= 7; n++)
            {
                elementos.Add(new Embarcacion(Embarcacion.TipoElemento.Escalera));
                elementos.Add(new Embarcacion(Embarcacion.TipoElemento.Serpiente));
            }
        }

        public void Jugar()
        {
            foreach (Jugador jugador in jugadores)
            {
                jugador.Mover();

                foreach (Embarcacion elemento in elementos)
                {
                    elemento.Evaluar(jugador);
                }
            }
        }

        public Jugador VerJugador(int idx)
        {
            Jugador jug = null;
            if (idx >= 0 && idx < CantidadJugadores)
            {
                jug=(Jugador)jugadores[idx];
            }
            return jug;
        }

        public Embarcacion VerElemento(int idx)
        {
            Embarcacion elem = null;
            if (idx >= 0 && idx < CantidadElementos)
            {
                elem = (Embarcacion)elementos[idx];
            }
            return elem;
        }
              
        public bool HaFinalizado()
        {
            bool haFinalizado=false;
            foreach (Jugador jugador in jugadores)
            {
                if (jugador.HaLLegado==true)
                {
                    haFinalizado |= true;
                }
            }
            return haFinalizado;
        }
    }
}
