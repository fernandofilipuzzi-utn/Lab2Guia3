using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AhorcadoClassLib;
using System.Collections;
using AhorcadoDesktop.Modelo;

namespace AhorcadoDesktop
{
    public partial class FormPrincipal : Form
    {
        Ahorcado juego;
        ArrayList partidas = new ArrayList();

        public FormPrincipal()
        {
            InitializeComponent();
        }
                
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GeneradorPalabras gen = new GeneradorPalabras();

            juego = new Ahorcado(gen.ExtraerPalabra(),7);

            string palabra="";
            for (int n = 0; n < juego.CantidadLetras; n++)
            {
                palabra += juego.VerLetra(n);
            }

            lbIntentos.Text = $"Intentos: {juego.IntentosRestantes}";

            btnNuevo.Enabled = false;
            btnJugar.Enabled = true;
        }

        private void btnJugar_Click_1(object sender, EventArgs e)
        {
            if (juego.HaFinalizado == false)
            {
                char letra = tbLetra.Text[0];
                juego.Adivinar(letra);

                string palabra = "";
                for (int n = 0; n < juego.CantidadLetras; n++)
                {
                    palabra += juego.VerLetra(n);
                }
                tbPalabra.Text = palabra;

                lbIntentos.Text = $"Intentos: {juego.IntentosRestantes}";
            }
            else
            {
                FormDatos fDatos = new FormDatos();
                if (fDatos.ShowDialog() == DialogResult.OK)
                {
                    string nombre = fDatos.tbNombre.Text;
                    AgregarPartida(nombre, juego.HaGanado);
                }

                btnNuevo.Enabled = true;
                btnJugar.Enabled = false;
            }
        }
        
                
        public void AgregarPartida(string nombre, bool gano)
        {
            //buscar el registro
            Partida buscado = null;
            for (int n = 0; n < partidas.Count && buscado == null; n++)
            {
                Partida p = (Partida)partidas[n];
                if (p.Nombre == nombre)
                    buscado = p;
            }

            if (buscado != null)
            {
                if (gano == true) buscado.Ganadas++;
                buscado.Jugadas++;
            }
            else
            {
                Partida nueva = new Partida(nombre);
                if (gano == true) nueva.Ganadas = 1;
                partidas.Add(nueva);
            }
        }

        public ArrayList ListarPartidasOrdenadas()
        {
            for (int n = 0; n < partidas.Count - 1; n++)
            { 
                for (int m = n+1; m < partidas.Count; m++)
                {
                    Partida p = (Partida)partidas[n];
                    Partida q = (Partida)partidas[m];

                    if (p.Ganadas < q.Ganadas)
                    {
                        object aux = partidas[n];
                        partidas[n] = partidas[m];
                        partidas[m] = aux;
                    }
                }
            }
            return partidas;
        }

       
    }
}
