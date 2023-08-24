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

        private void btnJugar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormDatos fDato = new FormDatos();

            if (fDato.ShowDialog() == DialogResult.OK)
            {
                int filas = Convert.ToInt32( fDato.numericUpDown1.Value) ;
                int columnas = Convert.ToInt32(fDato.numericUpDown2.Value);
                int minas = = Convert.ToInt32(fDato.numericUpDown3.Value);

                nuevo = new BuscaMinas(fDato.tbNombre.Text,filas, columnas, minas);

                IniciarTablero();
                PintarTablero();
            }
        }
        
    

        private void btnListarHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial fHistorial = new FormHistorial();

            foreach (Partida p in ListarPartidasOrdenadas())
                fHistorial.listBox1.Items.Add($"{ p.Ganador}  {p.Ganadas}");

            fHistorial.ShowDialog();

            fHistorial.Dispose();
        }
                
        public void AgregarPartida(string nombre)
        {
            //buscar el registro
            Partida buscado = null;
            for (int n = 0; n < partidas.Count && buscado == null; n++)
            {
                Partida p = (Partida)partidas[n];
                if (p.Ganador == nombre)
                    buscado = p;
            }

            if (buscado != null)
                buscado.Ganadas++;
            else
                partidas.Add(new Partida(nombre, 1));
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

        public void IniciarTablero()
        {
            dataGridView1.RowCount = nuevo.Filas;
            dataGridView1.ColumnCount = nuevo.Filas;


        }
        public void PintarTablero() 
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
         
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            if (e.Button == MouseButtons.Left)
            {
            }
        }
        }
    }
}
