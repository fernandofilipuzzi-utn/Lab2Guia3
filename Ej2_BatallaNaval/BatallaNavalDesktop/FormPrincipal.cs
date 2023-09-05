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

                IniciarTablero(dgvTableroJ1);
                IniciarTablero(dgvTableroJ2);

                btnNuevo.Enabled = false;
            }            
        }

       
        private void btnListarHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial fHistorial = new FormHistorial();

            foreach (Partida p in ListarPartidasOrdenadas())
                fHistorial.lbResultados.Items.Add($"{ p.Ganador}  {p.Ganadas}");

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
            
        }

        Embarcacion nueva;
        private void dgvTableroJ1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int fila = e.RowIndex;
            int columna = e.ColumnIndex;


            string tipo = comboBox1.SelectedItem as string;
            Embarcacion.TipoEmbarcacion tipoBarco=0;
            if (tipo == "Lancha")
            {
                tipoBarco = Embarcacion.TipoEmbarcacion.Lancha;
            }
            //faltan los otros

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

                //falta verificar largo

                juego.Jugador1.AgregarEmbarcacion(nueva);
                nueva = null;
                comboBox1.Items.Remove(tipo);
                comboBox1.SelectedIndex = -1;
            }

            PintarTableroJ1();
        }

        public void IniciarTablero(DataGridView dgv)
        {
            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.None;
            dgv.BackgroundColor = Color.Gray;

            dgv.RowCount = juego.CantFilas;
            dgv.ColumnCount = juego.CantColumnas;

            for (int m = 0; m < dgv.RowCount; m++)
            {
                dgv.Rows[m].Height = (dgvTableroJ1.ClientSize.Height) / dgvTableroJ1.RowCount;
                dgv.Rows[m].Resizable = DataGridViewTriState.False;

                for (int n = 0; n < dgvTableroJ1.ColumnCount; n++)
                {
                    dgv.Columns[n].Width = (dgvTableroJ1.ClientSize.Width) / dgvTableroJ1.ColumnCount;
                    dgv.Columns[n].Resizable = DataGridViewTriState.False;

                    dgv[n, m].Style.Font = new Font("Courier New", 12);
                    dgv[n, m].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv[n, m].Style.BackColor = Color.Gray;
                }
            }

            dgv.Enabled = true;

            PintarTableroJ1();
        }

        public void PintarTableroJ1()
        {
            for (int m = 0; m < dgvTableroJ1.RowCount; m++)
            {
                for (int n = 0; n < dgvTableroJ1.ColumnCount; n++)
                {
                    Celda c = juego.Jugador1[m, n];
                    if (c.Embarcacion!=null)
                    {
                        dgvTableroJ1[n, m].Value = "X";
                    }
                }
            }
        }
    }
}
