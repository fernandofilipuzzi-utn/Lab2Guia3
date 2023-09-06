using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

using BatallaNavalClassLib;
using BatallaNavalDesktop.Modelo;

namespace BatallaNavalDesktop
{ 
    public partial class FormPrincipal : Form

    {
        BatallaNaval juego;

        ArrayList partidas = new ArrayList();
     
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormDatos fDato = new FormDatos();

            if (fDato.ShowDialog() == DialogResult.OK)
            {
                string nombreJugador = fDato.tbNombre.Text;

                juego = new BatallaNaval(nombreJugador,20,10);

                IniciarTablero(dgvTableroJ1, lbNombreJ1, juego.Jugador1);
                IniciarTablero(dgvTableroJ2, lbNombreJ2, juego.Jugador2);

                lbMensajes.Items.Clear();
                lbMensajes.Items.Add("Seleccione y ubique los barcos en su tablero.");

                cbTipoEmbarcacion.Enabled = true;
                cbTipoEmbarcacion.Items.Clear();
                foreach(Embarcacion.TipoEmbarcacion tipo in juego.ModelosEmbarcaciones)
                    cbTipoEmbarcacion.Items.Add(tipo.ToString());

                dgvTableroJ1.Enabled = true;                 

                btnNuevo.Enabled = false;
            }            
        }
               
        private void btnListarHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial fHistorial = new FormHistorial();

            foreach (Partida p in ListarPartidasOrdenadas())
                fHistorial.lbResultados.Items.Add($"{p.Ganador}  {p.Ganadas}");

            fHistorial.ShowDialog();

            fHistorial.Dispose();
        }

        //

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

        public void AgregarPartida(string nombre)
        {
            #region buscar el registro primero!
            Partida buscado = null;
            for (int n = 0; n < partidas.Count && buscado == null; n++)
            {
                Partida p = (Partida)partidas[n];
                if (p.Ganador == nombre)
                    buscado = p;
            }
            #endregion

            #region lo actualizo silo encuentro sono lo agrego 
            if (buscado != null)
                buscado.Ganadas++;
            else
                partidas.Add(new Partida(nombre, 1));
            #endregion
        }              

        private void dgvTableroJ2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = e.RowIndex;
            int columna=e.ColumnIndex;

            if (e.Button == MouseButtons.Left)
            {
                juego.Jugar(fila, columna);
            }

            PintarTablero(dgvTableroJ1, juego.Jugador1);
            PintarTablero(dgvTableroJ2, juego.Jugador2);
        }

        Embarcacion nueva;
        private void dgvTableroJ1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = e.RowIndex;
            int columna = e.ColumnIndex;

            #region selección tipo de embarcación
            string tipo = cbTipoEmbarcacion.SelectedItem as string;
            Embarcacion.TipoEmbarcacion tipoBarco=0;
            if (tipo == Embarcacion.TipoEmbarcacion.Lancha.ToString())
            {
                tipoBarco = Embarcacion.TipoEmbarcacion.Lancha;
            }
            else if (tipo == Embarcacion.TipoEmbarcacion.Crucero.ToString())
            {
                tipoBarco = Embarcacion.TipoEmbarcacion.Crucero;
            }
            else if (tipo == Embarcacion.TipoEmbarcacion.Submarino.ToString())
            {
                tipoBarco = Embarcacion.TipoEmbarcacion.Submarino;
            }
            else if (tipo == Embarcacion.TipoEmbarcacion.Buque.ToString())
            {
                tipoBarco = Embarcacion.TipoEmbarcacion.Buque;
            }
            else if (tipo == Embarcacion.TipoEmbarcacion.Portaaviones.ToString())
            {
                tipoBarco = Embarcacion.TipoEmbarcacion.Portaaviones;
            }
            else
            {
                return;
            }
            #endregion

            if (e.Button == MouseButtons.Left)
            {
                //logica de ubicación de las Embarcaciones sin que queden contiguas 

                if (nueva==null)
                {
                    nueva = new Embarcacion(tipoBarco);
                }

                if (juego.Jugador1.HayCeldaOcupadasContiguas(fila, columna) == false)
                {
                    nueva.AgregarCelda(juego.Jugador1[fila, columna]);
                }
                else
                {
                    MessageBox.Show("no no!");
                }

                if (nueva.FueUbicada() == true)
                {
                    juego.Jugador1.AgregarEmbarcacion(nueva);
                    nueva = null;
                    cbTipoEmbarcacion.Items.Remove(tipo);
                    cbTipoEmbarcacion.SelectedIndex = -1;
                    cbTipoEmbarcacion.Text = "";
                }
            }

            PintarTablero(dgvTableroJ1, juego.Jugador1);

            if (nueva!=null && nueva.FueUbicada() == false)
            {
                for (int n = 0; n < nueva.Longitud; n++)
                {
                    Celda celda = nueva[n];
                    dgvTableroJ1[celda.Columna, celda.Fila].Value = "x";
                }
            }

            if (cbTipoEmbarcacion.Items.Count == 0)
            {
                //inicializar jugador 2
                PintarTablero(dgvTableroJ2, juego.Jugador2);

                //comienza el juego

                cbTipoEmbarcacion.Enabled = false;
                dgvTableroJ1.Enabled = false;

                dgvTableroJ2.Enabled = true;

                lbMensajes.Items.Clear();
                lbMensajes.Items.Add("Dispare! en el tablero de su oponente");
            }
        }

        public void IniciarTablero(DataGridView dgv, Label lbNombreJug, Jugador jug)
        {
            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.None;
            dgv.BackgroundColor = Color.Gray;

            dgv.RowCount = juego.CantFilas;
            dgv.ColumnCount = juego.CantColumnas;

            for (int m = 0; m < dgv.RowCount; m++)
            {
                dgv.Rows[m].Height = (dgvTableroJ1.ClientSize.Height)/dgvTableroJ1.RowCount;
                dgv.Rows[m].Resizable = DataGridViewTriState.False;

                for (int n = 0; n < dgvTableroJ1.ColumnCount; n++)
                {
                    dgv.Columns[n].Width = (dgvTableroJ1.ClientSize.Width)/dgvTableroJ1.ColumnCount;
                    dgv.Columns[n].Resizable = DataGridViewTriState.False;

                    dgv[n, m].Style.Font = new Font("Courier New", 12);
                    dgv[n, m].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv[n, m].Style.BackColor = Color.Gray;
                }
            }
            dgv.Enabled = true;

            lbNombreJug.Text = jug.Nombre;

            PintarTablero(dgv,jug);
        }

        public void PintarTablero(DataGridView dgv, Jugador jug)
        {
            for (int m = 0; m < dgv.RowCount; m++)
            {
                for (int n = 0; n < dgv.ColumnCount; n++)
                {
                    Celda c = jug[m, n];

                    if (c.EstaOculta == false)
                    {
                        if(c.Embarcacion!=null)
                            dgv[n, m].Value = "█";

                        if (c.HuboImpacto)
                            dgv[n, m].Value = "X";
                        else if (c.HuboDisparo)
                            dgv[n, m].Value = "o";
                    }
                    else
                    {
                        if (c.HuboImpacto)
                            dgv[n, m].Value = "X";
                        else if (c.HuboDisparo)
                            dgv[n, m].Value = "X";
                    }
                }
            }
        }
    }
}
