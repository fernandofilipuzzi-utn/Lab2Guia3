
namespace BuscaMinasDesktop
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVerHistorial = new System.Windows.Forms.Button();
            this.dgvTablero = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTiempo = new System.Windows.Forms.Label();
            this.lbMarcas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(391, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(56, 50);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.Location = new System.Drawing.Point(734, 7);
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Size = new System.Drawing.Size(104, 40);
            this.btnVerHistorial.TabIndex = 12;
            this.btnVerHistorial.Text = "Ver Historial";
            this.btnVerHistorial.UseVisualStyleBackColor = true;
            this.btnVerHistorial.Click += new System.EventHandler(this.btnListarHistorial_Click);
            // 
            // dgvTablero
            // 
            this.dgvTablero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablero.Location = new System.Drawing.Point(12, 58);
            this.dgvTablero.Name = "dgvTablero";
            this.dgvTablero.Size = new System.Drawing.Size(826, 497);
            this.dgvTablero.TabIndex = 13;
            this.dgvTablero.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTablero_CellMouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.BackColor = System.Drawing.SystemColors.Window;
            this.lbTiempo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempo.Location = new System.Drawing.Point(548, 19);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(0, 18);
            this.lbTiempo.TabIndex = 14;
            // 
            // lbMarcas
            // 
            this.lbMarcas.AutoSize = true;
            this.lbMarcas.BackColor = System.Drawing.SystemColors.Window;
            this.lbMarcas.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarcas.Location = new System.Drawing.Point(66, 19);
            this.lbMarcas.Name = "lbMarcas";
            this.lbMarcas.Size = new System.Drawing.Size(0, 18);
            this.lbMarcas.TabIndex = 15;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 567);
            this.Controls.Add(this.lbMarcas);
            this.Controls.Add(this.lbTiempo);
            this.Controls.Add(this.dgvTablero);
            this.Controls.Add(this.btnVerHistorial);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "BuscaMinasDesktop";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVerHistorial;
        private System.Windows.Forms.DataGridView dgvTablero;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.Label lbMarcas;
    }
}

