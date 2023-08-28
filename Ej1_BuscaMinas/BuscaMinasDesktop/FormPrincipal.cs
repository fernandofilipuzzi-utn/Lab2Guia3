using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BuscaMinasClassLib;
using System.Collections;
using BuscaMinasDesktop.Modelo;

namespace BuscaMinasDesktop
{
    public partial class FormPrincipal : Form
    {
        BuscaMinas nuevo;
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
            FormDatos fDato = new FormDatos();

            if (fDato.ShowDialog() == DialogResult.OK)
            {
                string nombreJugador = fDato.tbNombre.Text;

                int filas = 0;
                int columnas = 0;
                int minas = 0;
                if (fDato.cbNivel.SelectedIndex == 0)
                {
                    filas = 8;
                    columnas = 8;
                    minas = 10;
                }
                else if (fDato.cbNivel.SelectedIndex == 1)
                {
                    filas = 16;
                    columnas = 16;
                    minas = 40;
                }
                else if (fDato.cbNivel.SelectedIndex == 2)
                {
                    filas = 16;
                    columnas = 30;
                    minas = 99;
                }
                else 
                {
                    filas = Convert.ToInt32(fDato.nudFilas.Value);
                    columnas = Convert.ToInt32(fDato.nudColumnas.Value);
                    minas = Convert.ToInt32(fDato.nudMinas.Value);
                }

                nuevo = new BuscaMinas(nombreJugador,filas, columnas, minas);

                IniciarTablero();
                PintarTablero();
            }
        }

        private void btnListarHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial fHistorial = new FormHistorial();

            foreach (Partida p in ListarPartidasOrdenadas())
                fHistorial.listBox1.Items.Add($"{ p.Participante}  {p.Tiempo}");

            fHistorial.ShowDialog();

            fHistorial.Dispose();
        }
                
        public void AgregarPartida(string nombre, int tiempo)
        {
            Partida buscado = null;
            for (int n = 0; n < partidas.Count && buscado == null; n++)
            {
                Partida p = (Partida)partidas[n];
                if (p.Participante == nombre)
                    buscado = p;
            }

            if (buscado != null)
                buscado.Tiempo=tiempo;
            else
                partidas.Add(new Partida(nombre, tiempo));
        }

        public ArrayList ListarPartidasOrdenadas()
        {
            for (int n = 0; n < partidas.Count - 1; n++)
            { 
                for (int m = n+1; m < partidas.Count; m++)
                {
                    Partida p = (Partida)partidas[n];
                    Partida q = (Partida)partidas[m];

                    if (p.Tiempo > q.Tiempo)
                    {
                        object aux = partidas[n];
                        partidas[n] = partidas[m];
                        partidas[m] = aux;
                    }
                }
            }
            return partidas;
        }

        public void IniciarTablero()
        {
            dgvTablero.ColumnHeadersVisible = false;
            dgvTablero.RowHeadersVisible = false;
            dgvTablero.ScrollBars = ScrollBars.None;
            dgvTablero.BackgroundColor = Color.Gray;

            dgvTablero.RowCount = nuevo.Filas;
            dgvTablero.ColumnCount = nuevo.Columnas;

            for (int m = 0; m < dgvTablero.RowCount; m++)
            {
                dgvTablero.Rows[m].Height = (dgvTablero.ClientSize.Height) / dgvTablero.RowCount;
                dgvTablero.Rows[m].Resizable = DataGridViewTriState.False;
                
                for (int n = 0; n < dgvTablero.ColumnCount; n++)
                {
                    dgvTablero.Columns[n].Width = (dgvTablero.ClientSize.Width) / dgvTablero.ColumnCount;
                    dgvTablero.Columns[n].Resizable = DataGridViewTriState.False;
                    
                    dgvTablero[n, m].Style.Font = new Font("Courier New", 12);
                    dgvTablero[n, m].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvTablero[n, m].Style.BackColor = Color.Gray;
                }
            }

            timer1.Stop();

            timer1.Interval = 1000;
            timer1.Start();
            tiempo = 0;

            dgvTablero.Enabled = true;
        }
        public void PintarTablero()
        {
            for (int m = 0; m < dgvTablero.RowCount; m++)
            {
                for (int n = 0; n < dgvTablero.ColumnCount; n++)
                {
                    Celda c = nuevo[m, n];
                    if (c.Estado == Celda.TipoEstado.Oculta)
                    {
                        dgvTablero[n, m].Value = "█";
                    }
                    else if (c.Estado == Celda.TipoEstado.Despejado)
                    {
                        if (c.MinasAlrededor != 0)
                        {
                            dgvTablero[n, m].Value = c.MinasAlrededor.ToString();
                            dgvTablero[n, m].Style.BackColor = Color.LightGray;
                        }
                        else
                        {
                            if (c.HayMina == true)
                            {
                                dgvTablero[n, m].Value = "◍";
                            }
                            else
                            {
                                dgvTablero[n, m].Value = "";
                                dgvTablero[n, m].Style.BackColor = Color.LightGray;
                            }
                        }
                    }
                    else
                    {
                        dgvTablero[n, m].Value = "☠";
                    }
                }
            }
        }

        private void dgvTablero_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            if (e.Button == MouseButtons.Left)
            {
                nuevo.DestaparCelda(row, col);
            }
            if (e.Button == MouseButtons.Right)
            {
                nuevo.MarcarCelda(row, col);
            }

            PintarTablero();

            if (nuevo.HaFinalizado() == true)
            {
                timer1.Stop();
                AgregarPartida(nuevo.Jugador, tiempo);
                dgvTablero.Enabled = false;
            }
        }

        int tiempo=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTiempo.Text = (tiempo++).ToString("0000") ; 
        }
    }
}
