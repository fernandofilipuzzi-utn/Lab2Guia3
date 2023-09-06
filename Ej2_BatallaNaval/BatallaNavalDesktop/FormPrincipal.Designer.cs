
namespace BatallaNavalDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvTableroJ1 = new System.Windows.Forms.DataGridView();
            this.dgvTableroJ2 = new System.Windows.Forms.DataGridView();
            this.cbTipoEmbarcacion = new System.Windows.Forms.ComboBox();
            this.lbNombreJ1 = new System.Windows.Forms.Label();
            this.lbNombreJ2 = new System.Windows.Forms.Label();
            this.lbMensajes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableroJ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableroJ2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "N.png");
            this.imageList1.Images.SetKeyName(1, "O.png");
            this.imageList1.Images.SetKeyName(2, "X.png");
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(825, 93);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 55);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(825, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "Listar Historial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnListarHistorial_Click);
            // 
            // dgvTableroJ1
            // 
            this.dgvTableroJ1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableroJ1.Enabled = false;
            this.dgvTableroJ1.Location = new System.Drawing.Point(7, 93);
            this.dgvTableroJ1.Name = "dgvTableroJ1";
            this.dgvTableroJ1.Size = new System.Drawing.Size(390, 481);
            this.dgvTableroJ1.TabIndex = 13;
            this.dgvTableroJ1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ConstruirAgregarBarcoJug1);
            // 
            // dgvTableroJ2
            // 
            this.dgvTableroJ2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableroJ2.Enabled = false;
            this.dgvTableroJ2.Location = new System.Drawing.Point(413, 93);
            this.dgvTableroJ2.Name = "dgvTableroJ2";
            this.dgvTableroJ2.Size = new System.Drawing.Size(390, 481);
            this.dgvTableroJ2.TabIndex = 14;
            this.dgvTableroJ2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Jugar);
            // 
            // cbTipoEmbarcacion
            // 
            this.cbTipoEmbarcacion.Enabled = false;
            this.cbTipoEmbarcacion.FormattingEnabled = true;
            this.cbTipoEmbarcacion.Items.AddRange(new object[] {
            "Lancha",
            "Lancha",
            "Crucero",
            "Submarino",
            "Buque",
            "Portaaviones"});
            this.cbTipoEmbarcacion.Location = new System.Drawing.Point(239, 66);
            this.cbTipoEmbarcacion.Name = "cbTipoEmbarcacion";
            this.cbTipoEmbarcacion.Size = new System.Drawing.Size(158, 21);
            this.cbTipoEmbarcacion.TabIndex = 16;
            // 
            // lbNombreJ1
            // 
            this.lbNombreJ1.AutoSize = true;
            this.lbNombreJ1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreJ1.Location = new System.Drawing.Point(10, 71);
            this.lbNombreJ1.Name = "lbNombreJ1";
            this.lbNombreJ1.Size = new System.Drawing.Size(108, 18);
            this.lbNombreJ1.TabIndex = 17;
            this.lbNombreJ1.Text = "lbNombreJ1";
            // 
            // lbNombreJ2
            // 
            this.lbNombreJ2.AutoSize = true;
            this.lbNombreJ2.Enabled = false;
            this.lbNombreJ2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreJ2.Location = new System.Drawing.Point(419, 69);
            this.lbNombreJ2.Name = "lbNombreJ2";
            this.lbNombreJ2.Size = new System.Drawing.Size(108, 18);
            this.lbNombreJ2.TabIndex = 18;
            this.lbNombreJ2.Text = "lbNombreJ2";
            // 
            // lbMensajes
            // 
            this.lbMensajes.Enabled = false;
            this.lbMensajes.FormattingEnabled = true;
            this.lbMensajes.Location = new System.Drawing.Point(10, 15);
            this.lbMensajes.Name = "lbMensajes";
            this.lbMensajes.Size = new System.Drawing.Size(792, 43);
            this.lbMensajes.TabIndex = 19;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 581);
            this.Controls.Add(this.lbMensajes);
            this.Controls.Add(this.lbNombreJ2);
            this.Controls.Add(this.lbNombreJ1);
            this.Controls.Add(this.cbTipoEmbarcacion);
            this.Controls.Add(this.dgvTableroJ2);
            this.Controls.Add(this.dgvTableroJ1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Batalla Naval";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableroJ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableroJ2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvTableroJ1;
        private System.Windows.Forms.DataGridView dgvTableroJ2;
        private System.Windows.Forms.ComboBox cbTipoEmbarcacion;
        private System.Windows.Forms.Label lbNombreJ1;
        private System.Windows.Forms.Label lbNombreJ2;
        private System.Windows.Forms.ListBox lbMensajes;
    }
}

